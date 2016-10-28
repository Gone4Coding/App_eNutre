using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    class Restaurant
    {
        private string name;
        private string item;
        private string quantity;
        private int calories;

        public Restaurant(string name, string item, string quantity, int calories)
        {
            this.name = name;
            this.item = item;
            this.quantity = quantity;
            this.calories = calories;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Item
        {
            get { return item; }
            set { item = value; }
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
            return "Name: " + name + "; Item: " + item + "; Quantity: " + quantity + "; Calories: " + calories;
        }
    }
}
