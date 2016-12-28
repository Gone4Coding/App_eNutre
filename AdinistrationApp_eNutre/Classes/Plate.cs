using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationApp_eNutre.Classes
{
    public class Plate
    {
        private string name;
        private string restaurantName;
        private string quantityValue;
        private string quantityDosage;
        private string quantityExtraDosage;
        private int caloriesValue;
        private string caloriasUnit;

        public Plate(string name, string restaurantName, string quantityValue, string quantityDosage, string quantityExtraDosage,
            int caloriesValue, string caloriasUnit)
        {
            this.name = name;
            this.restaurantName = restaurantName;
            this.quantityValue = quantityValue;
            this.quantityDosage = quantityDosage;
            this.quantityExtraDosage = quantityExtraDosage;
            this.caloriesValue = caloriesValue;
            this.caloriasUnit = caloriasUnit;
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
        
        public string QuantityValue
        {
            get { return quantityValue; }
            set { quantityValue = value; }
        }
        
        public string QuantityDosage
        {
            get { return quantityDosage; }
            set { quantityDosage = value; }
        }
        
        public string QuantityExtraDosage
        {
            get { return quantityExtraDosage; }
            set { quantityExtraDosage = value; }
        }
        
        public int CaloriesValue
        {
            get { return caloriesValue; }
            set { caloriesValue = value; }
        }
        
        public string CaloriasUnit
        {
            get { return caloriasUnit; }
            set { caloriasUnit = value; }
        }
    }
}
