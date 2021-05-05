using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using VegetableWarehouse.Classes.Exceptions;

namespace VegetableWarehouse.Classes.Entities
{
    /// <summary>
    /// Class for work with container.
    /// </summary>
    public class Container
    {
        #region FieldsAndProperties

        private readonly Random _random = new Random();

        /// <summary>
        /// Min weight for generate container max weight.
        /// </summary>
        private const int MinWeight = 50;

        /// <summary>
        /// Max weight for generate container max weight.
        /// </summary>
        private const int MaxWeight = 1000;

        /// <summary>
        /// Container weight.
        /// </summary>
        private int _weight;
        
        /// <summary>
        /// Container storage cost.
        /// </summary>
        private double _addStorageCost;


        /// <summary>
        /// Container id in warehouse.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property for work with field _weight.
        /// </summary>
        public int Weight
        {
            get => _weight;
            set
            {
                // Check user input.
                if (value > CurrentMaxWeight)
                {
                    throw new ConstraintException("Container is already full.");
                }

                _weight = value;
            }
        }

        /// <summary>
        /// Container max weight.
        /// </summary>
        public int CurrentMaxWeight { get; }

        /// <summary>
        /// Amount (price) whole container (all boxes). 
        /// </summary>
        public double Amount => Boxes.Sum(box => box.Amount);

        /// <summary>
        /// Property for work with field _addStorageCost.
        /// </summary>
        public double StorageCost
        {
            get => _addStorageCost + Amount / WarehousePercentage;
            set => _addStorageCost = value;
        }

        /// <summary>
        /// Warehouse's percent, which warehouse get from each container's amount.
        /// </summary>
        public int WarehousePercentage { get; set; }

        /// <summary>
        /// Container number of boxes.
        /// </summary>
        public int NumberOfBoxes { get; private set; }
        
        /// <summary>
        /// Container boxes.
        /// </summary>
        public List<Box> Boxes { get; }

        /// <summary>
        /// Boxes damage degree after transfer.
        /// </summary>
        public double DamageDegree { get; set; }

        #endregion


        #region Constructors

        /// <summary>
        /// Constructor for creating empty container.
        /// </summary>
        public Container()
        {
            CurrentMaxWeight = _random.Next(MinWeight, MaxWeight + 1);

            NumberOfBoxes = 0;
            Weight = 0;

            Boxes = new List<Box>();
        }
        
        /// <summary>
        /// Copy constructor for creating new container.
        /// </summary>
        /// <param name="container"></param>
        public Container(Container container)
        {
            CurrentMaxWeight = container.CurrentMaxWeight;
            Boxes = new List<Box>();

            for (var indexOfBox = 1; indexOfBox < container.NumberOfBoxes+1; indexOfBox++)
            {
                AddNewBox(container[indexOfBox]);
            }
        }

        #endregion


        #region WorkWithObject

        /// <summary>
        /// Indexer for work with container's box.
        /// </summary>
        /// <param name="id">Box id in container.</param>
        /// <returns>Necessary box.</returns>
        public Box this[int id] => Boxes.Single(box => box.Id == id);

        /// <summary>
        /// Add new box in current container.
        /// </summary>
        /// <param name="box">Adding box.</param>
        public void AddNewBox(Box box)
        {
            var newBox = new Box(box);

            Weight += newBox.Weight;
            NumberOfBoxes++;

            newBox.Id = NumberOfBoxes;
            // Add new box in lit Boxes.
            Boxes.Add(newBox);
        }

        /// <summary>
        /// Remove specially box from current container.
        /// </summary>
        /// <param name="id">Removing box's id.</param>
        public void RemoveBox(int id)
        {
            // Check user box's id
            if (Boxes.All(box => box.Id != id))
            {
                throw new BoxException($"The box with id {id} does not exist.");
            }

            Weight -= this[id].Weight;
            NumberOfBoxes--;

            // Remove specially box from current container.
            Boxes.Remove(this[id]);

            // Change left boxes' id.
            foreach (var box in Boxes)
            {
                box.Id = box.Id > id ? box.Id - 1 : box.Id;
            }
        }

        /// <summary>
        /// Print container properties.
        /// </summary>
        /// <returns>Container properties in string.</returns>
        public override string ToString()
        {
            return string.Format(
                new CultureInfo("en-US"), 
                "ID: {0}; NUMBER_OF_BOXES: {1}; WEIGHT: {2}kg; MAX_WEIGHT: {3}kg; AMOUNT: {4:C2}; STORAGE_COST: {5:C2}",
                Id, NumberOfBoxes, Weight, CurrentMaxWeight, Amount, StorageCost
            ); 
        }

        #endregion
    }
}