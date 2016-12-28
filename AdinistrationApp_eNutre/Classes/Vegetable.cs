using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdinistrationApp_eNutre.Classes;

namespace AdministrationApp_eNutre.Classes
{
    public class Vegetable
    {
        private int id;
        private string name;
        private List<string> extraInfo;
        private string quantityValue;
        private string unityQuantity;
        private int caloriesValue;
        private string unityCal;


        public Vegetable(int id, string name, List<string> extraInfo, string quantityValue, string unityQuantity, int caloriesValue, string unityCal)
        {
            this.id = id;
            this.name = name;
            this.extraInfo = extraInfo;
            this.quantityValue = quantityValue;
            this.unityQuantity = unityQuantity;
            this.caloriesValue = caloriesValue;
            this.unityCal = unityCal;
        }
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        public List<string> ExtraInfo
        {
            get { return extraInfo; }
            set { extraInfo = value; }
        }
        

        public string QuantityValue
        {
            get { return quantityValue; }
            set { quantityValue = value; }
        }
        

        public string UnityQuantity
        {
            get { return unityQuantity; }
            set { unityQuantity = value; }
        }
        

        public int CaloriesValue
        {
            get { return caloriesValue; }
            set { caloriesValue = value; }
        }
        

        public string UnityCal
        {
            get { return unityCal; }
            set { unityCal = value; }
        }
    }
}
