using System.Globalization;
using System.Linq;
using VegetableWarehouse.Classes.Exceptions;

namespace VegetableWarehouse.Classes.Entities
{
    /// <summary>
    /// Class for work with boxes.
    /// </summary>
    public class Box
    {
        #region FieldsAndProperties

        /// <summary>
        /// Available vegetables for creating boxes.
        /// </summary>
        public static readonly string[] Vegetables = {"potato", "cucumber", "carrot", "cabbage", "tomato", "pepper", "pumpkin", "parsley", "fennel", "sorrel"};

        /// <summary>
        /// Box name - vegetable.
        /// </summary>
        private string _name;

        /// <summary>
        /// Box weight.
        /// </summary>
        private int _weight;

        /// <summary>
        /// Box price for one kg.
        /// </summary>
        private double _price;


        /// <summary>
        /// Box id in container
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Property for work with field _name. 
        /// </summary>
        public string Name
        {
            get => _name;
            private set
            {
                // Check user input.
                if (Vegetables.All(vegetable => value.ToLower() != vegetable))
                {
                    throw new BoxException("This vegetable was not found in the system");
                }

                _name = value.ToLower();
            }
        }

        /// <summary>
        /// Property for work with field _weight.
        /// </summary>
        public int Weight
        {
            get => _weight;
            private set
            {
                // Check user input.
                if (_weight < 0)
                {
                    throw new BoxException("Weight cannot be negative");
                }

                _weight = value;
            }
        }

        /// <summary>
        /// Property for work with field _price.
        /// </summary>
        public double Price
        {
            get => _price;
            set
            {
                // Check user input.
                if (value < 0)
                {
                    throw new BoxException("Price cannot be negative");
                }

                _price = value;
            }
        }

        /// <summary>
        /// Amount (price) whole box.
        /// </summary>
        public double Amount => Price * Weight;

        #endregion


        #region Constructors

        /// <summary>
        /// Constructor for creating box.
        /// </summary>
        /// <param name="name">Box name - vegetable.</param>
        /// <param name="weight">Box weight.</param>
        /// <param name="price">Box price for one kg.</param>
        public Box(string name, int weight, double price)
        {
            Name = name;
            Weight = weight;
            Price = price;
        }

        /// <summary>
        /// Copy constructor for creating box.
        /// </summary>
        /// <param name="box">Box for copy.</param>
        public Box(Box box)
        {
            Name = box.Name;
            Weight = box.Weight;
            Price = box.Price;
        }

        #endregion


        #region WorkWithObject

        /// <summary>
        /// Print object properties.
        /// </summary>
        /// <returns>Object properties in string.</returns>
        public override string ToString()
        {
            return string.Format(
                new CultureInfo("en-US"), 
                "ID: {0}; VEGETABLE: {1}; WEIGHT: {2}kg; PRICE: {3:C2}; AMOUNT: {4:C2}", 
                Id, Name, Weight, Price, Amount
            );
        }

        #endregion
    }
}