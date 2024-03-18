/*
 * Filename:    Service.cs
 * Author:      Colin Eade
 * Date:        November 5, 2023
 * Description: Handles the Service class
 */

namespace CarServiceShopReservation
{
    /// <summary>
    /// Represents a car service entry
    /// </summary>
    internal class Service
    {
        // Constants
        // Public so a form function can dynamically set the cost output field
        public const decimal EngOilChgCost = 60.00m;
        public const decimal TransOilChgCost = 120.00m;
        public const decimal AirFilterChgCost = 40.50m;

        // Properties
        public static int Count { get; private set; }
        public int IdentificationNumber { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long PhoneNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Colour { get; set; }
        public bool EngOilChange { get; set; }
        public bool TransOilChange { get; set; }
        public bool AirFilterChange { get; set; }
        public decimal Price { get; private set; }

        /// <summary>
        /// Inititializes a new instance of the Service Class with a unique identification number
        /// The identification number is automatically generated and incremented 
        /// </summary>
        public Service()
        {
            Count++;
            IdentificationNumber = Count;
        }

        /// <summary>
        /// Initializes a new instance of the Service class with customer and service details
        /// </summary>
        /// <param name="firstName">The first name of the customer</param>
        /// <param name="lastName">The last name of the customer</param>
        /// <param name="phoneNumber">The customer's phone number</param>
        /// <param name="make">The manufacturer of the customer's car</param>
        /// <param name="model">The model of the customer's car</param>
        /// <param name="year">The manufacturing year of the customer's car</param>
        /// <param name="colour">The colour of the customer's car</param>
        /// <param name="engOilChange">Checks whether an engine oil change is required</param>
        /// <param name="transOilChange">Checks whether a transmission oil change is required</param>
        /// <param name="airFilterChange">Checks whether an air filter change is required</param>
        /// <param name="price">The price of the service</param>
        public Service(string firstName, string lastName, long phoneNumber, string make, string model, int year,
                       string colour, bool engOilChange, bool transOilChange, bool airFilterChange, decimal price) : this()
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
            EngOilChange = engOilChange;
            TransOilChange = transOilChange;
            AirFilterChange = airFilterChange;
            Price = CalculatePrice();
        }

        /// <summary>
        /// Calculates the total price of the service
        /// total is computed by adding predefined costs for each selected service
        /// </summary>
        /// <returns></returns>
        private decimal CalculatePrice()
        {
            // Variables
            decimal calculatedPrice = 0.00m;

            if (EngOilChange)
            {
                calculatedPrice += EngOilChgCost;     // Add charge if engine oil change is required
            }
            if (TransOilChange)
            {
                calculatedPrice += TransOilChgCost;   // Add charge if transmission oil change is required
            }
            if (AirFilterChange)
            {
                calculatedPrice += AirFilterChgCost;  // Add charge if air filter change is required
            }
            return calculatedPrice;                   // Return the sum of all required services
        }

        /// <summary>
        /// Updates the price for when a service entry is updated
        /// </summary>
        public void UpdatePrice()
        {
            Price = CalculatePrice();
        }

        /// <summary>
        /// Constructs a formatted string containing all the details of the service
        /// </summary>
        /// <returns>A formatted string with each service detail on its own line</returns>
        public string GetServiceData()
        {
            return $"Identification Number: {IdentificationNumber}\n" +
                   $"First Name: {FirstName}\n" +
                   $"Last Name: {LastName}\n" +
                   $"Phone Number: {PhoneNumber}\n" +
                   $"Make: {Make}\n" +
                   $"Model: {Model}\n" +
                   $"Year: {Year}\n" +
                   $"Colour: {Colour}\n" +
                   $"Engine Oil Change: {(EngOilChange ? "Yes" : "No")}\n" +
                   $"Transmission Oil Change: {(TransOilChange ? "Yes" : "No")}\n" +
                   $"Air Filter Change: {(AirFilterChange ? "Yes" : "No")}\n" +
                   $"Price: $ {Price}";
        }
    }
}
