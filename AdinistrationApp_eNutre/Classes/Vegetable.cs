using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdinistrationApp_eNutre.Classes;

namespace AdministrationApp_eNutre.Classes
{
    class Vegetable
    {
        private string name;
        private string extraInfo;
        private string quantity;
        private string calories;

        public Vegetable(string name, string quantity, string calories)
        {

            this.name = name;
            this.quantity = quantity;
            this.calories = calories;
        }

        public Vegetable(string name, string extraInfo, string quantity, string calories)
        {
            this.name = name;
            this.quantity = quantity;
            this.calories = calories;
            this.extraInfo = extraInfo;
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

        public string getCalories()
        {
            return calories;
        }
    }
}
