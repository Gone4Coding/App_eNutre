using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministrationApp_eNutre.Classes;
using Newtonsoft.Json;

namespace AdinistrationApp_eNutre.Classes
{
    class JsonHandler
    {
        private void deserialize(string jsonFile, string type)
        {
            //type; // Act; Res; Veg; 

            string json = System.IO.File.ReadAllText(jsonFile);
            switch (type)
            {
                case "Act":
                    List<Activity> activitiesList = new List<Activity>();
                    activitiesList = JsonConvert.DeserializeObject<List<Activity>>(json);
                    createXmlFile();
                    break;
                case "Res":
                    List<Restaurant> restaurantsList = new List<Restaurant>();
                    restaurantsList = JsonConvert.DeserializeObject<List<Restaurant>>(json);
                    createXmlFile();
                    break;
                case "Veg":
                    List<Vegetable> vegetablesList = new List<Vegetable>();
                    vegetablesList = JsonConvert.DeserializeObject<List<Vegetable>>(json);
                    createXmlFile();
                    break;
            }
        }

        private void createXmlFile()
        {
            
        }
    }
}
