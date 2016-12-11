using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    class Plate
    {
        private string name;
        private string restaurantName;
        private string quantity;
        private int calories;

        public Plate(string name, string restaurantName, string quantity, int calories)
        {
            this.name = name;
            this.restaurantName = restaurantName;
            this.quantity = quantity;
            this.calories = calories;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string RestaurantName
        {
            get { return restaurantName; }
            set { restaurantName = value; }
        }

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Calories
        {
            get { return calories; }
            set { calories = value; }
        }

        public override string ToString()
        {
            return "Name: " + name + "; Restaurant: " + restaurantName + "; Quantity: " + quantity + "; Calories: " + calories;
        }
    }
}
