using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    class Vegetable
    {
        private string name;
        private string extraInfo;
        private string quantity;
        private int calories;

        public Vegetable(string name, string quantity, int calories)
        {
            this.name = name;
            this.quantity = quantity;
            this.calories = calories;
        }

        public Vegetable(string name, string extraInfo, string quantity, int calories)
        {
            this.name = name;
            this.extraInfo = extraInfo;
            this.quantity = quantity;
            this.calories = calories;
        }

        public string getName()
        {
            return name;
        }

        public string getExtraInfo()
        {
            return extraInfo;
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
