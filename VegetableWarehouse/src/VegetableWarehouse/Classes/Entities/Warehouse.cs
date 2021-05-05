using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using VegetableWarehouse.Classes.Exceptions;

namespace VegetableWarehouse.Classes.Entities
{
    /// <summary>
    /// Class for work with warehouse.
    /// </summary>
    public class Warehouse
    {
        #region FieldsAndProperties

        private readonly Random _random = new Random();

        /// <summary>
        /// Eps for generate container damage degree.
        /// </summary>
        private const double Eps = 0.00000001;

        /// <summary>
        /// Min damage degree for generate container damage degree.
        /// </summary>
        private const double MinDamage = 0;

        /// <summary>
        /// Max damage degree for generate container damage degree.
        /// </summary>
        private const double MaxDamage = 0.5 - Eps;

        /// <summary>
        /// City, where warehouse locates.
        /// </summary>
        private string _city;

        /// <summary>
        /// Warehouse's max number of containers.
        /// </summary>
        private int _maxNumberOfContainers;

        /// <summary>
        /// Warehouse's percent, which warehouse get from each container's amount.
        /// </summary>
        private int _percentStorageCost;

        /// <summary>
        /// Current number of containers.
        /// </summary>
        private int _numberOfContainers;


        /// <summary>
        /// Available city for opening new warehouse.
        /// </summary>
        public static readonly string[] Cities = {"Moscow", "New-York", "London", "Tokyo", "Lisbon", "Beijing"};

        /// <summary>
        /// Warehouse cities' region.
        /// </summary>
        public static readonly string[] Regions = {"Eurasia", "North America", "Britain", "Japan"};

        /// <summary>
        /// Warehouse id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property for work with field _city.
        /// </summary>
        public string City
        {
            get => _city;
            set
            {
                // Check user input.
                foreach (var city in Cities)
                {
                    if (!string.Equals(value, city, StringComparison.CurrentCultureIgnoreCase))
                        continue;

                    _city = city;

                    return;
                }

                throw new WarehouseException($"We have not plan to open warehouse in {value}");
            }
        }

        /// <summary>
        /// Warehouse city's region.
        /// </summary>
        public string Region => GetWarehouseRegion();

        /// <summary>
        /// Internal method for getting city's region.
        /// </summary>
        /// <returns>City's region.</returns>
        private string GetWarehouseRegion()
        {
            switch (_city)
            {
                case "Moscow":
                case "Lisbon":
                case "Beijing":
                    return Regions[0];
                case "New-York":
                    return Regions[1];
                case "London":
                    return Regions[2];
                case "Tokyo":
                    return Regions[3];
                default:
                    return Regions[0];
            }
        }

        /// <summary>
        /// Property for work with field _maxNumberOfContainers.
        /// </summary>
        public int MaxNumberOfContainers
        {
            get => _maxNumberOfContainers;
            set
            {
                // Check user input.
                if (value < 1)
                {
                    throw new WarehouseException("Warehouse size cannot be less than 1 container.");
                }

                if (value < MaxNumberOfContainers)
                {
                    throw new WarehouseException("You cannot reduce warehouse size.");
                }

                _maxNumberOfContainers = value;
            }
        }

        /// <summary>
        /// Property for work with field _numberOfContainers.
        /// </summary>
        public int NumberOfContainers
        {
            get => _numberOfContainers;
            private set
            {
                // Check user input.
                if (value > MaxNumberOfContainers)
                {
                    throw new WarehouseException("Warehouse is full.");
                }

                _numberOfContainers = value;
            }
        }

        /// <summary>
        /// List of warehouse's containers.
        /// </summary>
        public List<Container> Containers { get; }

        /// <summary>
        /// Warehouse income - sum of all containers' storage cost.
        /// </summary>
        public double Income => Containers.Sum(container => container.StorageCost);

        /// <summary>
        /// Property for work with field _percentStorageCost.
        /// </summary>
        public int PercentStorageCost
        {
            get => _percentStorageCost;
            set
            {
                // Check user input.
                if (value < 1)
                {
                    throw new WarehouseException("Percentage cannot be less than 1.");
                }

                if (value > 99)
                {
                    throw new WarehouseException("Percentage cannot be equals to 100 or more");
                }

                _percentStorageCost = value;
            }
        }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructor for creating empty warehouse and next changes.
        /// </summary>
        public Warehouse()
        {
            Containers = new List<Container>();
        }

        /// <summary>
        /// Constructor for creating warehouse with some parameters.
        /// </summary>
        /// <param name="id">Warehouse's id.</param>
        /// <param name="city">Warehouse's city.</param>
        /// <param name="maxNumberOfContainers">Warehouse's max number of containers.</param>
        /// <param name="percentStorageCost">Warehouse's percent, which warehouse get from each container's amount.</param>
        public Warehouse(int id, string city, int maxNumberOfContainers, int percentStorageCost)
        {
            Id = id;
            City = city;
            MaxNumberOfContainers = maxNumberOfContainers;
            PercentStorageCost = percentStorageCost;
            Containers = new List<Container>();
        }

        /// <summary>
        /// Copy constructor for creating new warehouse.
        /// </summary>
        /// <param name="warehouse">Warehouse for copy.</param>
        public Warehouse(Warehouse warehouse)
        {
            Id = warehouse.Id;
            City = warehouse.City;
            MaxNumberOfContainers = warehouse.MaxNumberOfContainers;
            PercentStorageCost = warehouse.PercentStorageCost;
            Containers = new List<Container>();

            // Add container from warehouse for copy to current warehouse.
            for (var i = 0; i < warehouse.NumberOfContainers; i++)
            {
                AddContainer(warehouse[i]);
            }
        }

        #endregion


        #region WorkWithObject

        /// <summary>
        /// Indexer for work with warehouse's container.
        /// </summary>
        /// <param name="id">Necessary container's id.</param>
        /// <returns>Necessary container.</returns>
        public Container this[int id] => Containers.Single(container => container.Id == id);

        /// <summary>
        /// Add new container to current warehouse.
        /// </summary>
        /// <param name="container">Adding container.</param>
        public void AddContainer(Container container)
        {
            var newContainer = new Container(container);

            // Calculate container's damage and storage cost.
            newContainer.DamageDegree += _random.NextDouble() * (MaxDamage - MinDamage) + MinDamage;
            newContainer.WarehousePercentage = PercentStorageCost;

            // Reduce container's each box's price by damage degree. 
            for (var i = 1; i < newContainer.NumberOfBoxes + 1; i++)
            {
                newContainer[i].Price *= 1 - newContainer.DamageDegree;
            }

            // Check container's profitable. 
            if (newContainer.Amount < newContainer.StorageCost)
            {
                throw new ContainerException("Transportation fell through.\nContainer storage is unprofitable.");
            }


            NumberOfContainers++;

            newContainer.Id = NumberOfContainers;

            // Add new container to warehouse.
            Containers.Add(newContainer);
        }

        /// <summary>
        /// Remove necessary container from warehouse.
        /// </summary>
        /// <param name="id">Necessary container's id.</param>
        public void RemoveContainer(int id)
        {
            // Check user input.
            if (Containers.All(container => container.Id != id))
            {
                throw new ContainerException($"The container with id {id} does not exist.");
            }

            NumberOfContainers--;

            // Remove necessary container from warehouse.
            Containers.Remove(this[id]);

            // Change others boxes' id.
            foreach (var container in Containers)
            {
                container.Id = container.Id > id ? container.Id - 1 : container.Id;
            }
        }

        /// <summary>
        /// Move container from current warehouse to another.
        /// </summary>
        /// <param name="containerId">Necessary container's id.</param>
        /// <param name="warehouseDestination">Destination warehouse, which get necessary container.</param>
        public void MoveContainerToAnotherWarehouse(int containerId, Warehouse warehouseDestination)
        {
            warehouseDestination.AddContainer(this[containerId]);
            
            RemoveContainer(containerId);
            // Check warehouses' region and add 5 dollar to container's storage cost, if regions aren't equal.
            if (!Equals(Region, warehouseDestination.Region))
            {
                warehouseDestination[warehouseDestination.NumberOfContainers].StorageCost += 5;
            }
        }

        /// <summary>
        /// Print warehouse properties.
        /// </summary>
        /// <returns>Warehouse properties in string.</returns>
        public override string ToString()
        {
            return string.Format(
                new CultureInfo("en-US"),
                "ID: {0}; CITY: {1}; REGION: {2}; MAX_NUMBER_OF_CONTAINERS: {3}; NUMBER_OF_CONTAINERS: {4}; INCOME: {5:C2}",
                Id, City, Region, MaxNumberOfContainers, NumberOfContainers, Income
            );
        }

        #endregion
    }
}