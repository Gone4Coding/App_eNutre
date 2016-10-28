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

        public string getName()
        {
            return name;
        }

        public string getItem()
        {
            return item;
        }

        public string getQuantity()
        {
            return quantity;
        }

        public int getCalories()
        {
            return calories;
        }
    }
}
