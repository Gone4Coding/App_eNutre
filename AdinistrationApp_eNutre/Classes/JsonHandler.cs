using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AdministrationApp_eNutre.Classes;
using Newtonsoft.Json;

namespace AdinistrationApp_eNutre.Classes
{
    public static class JsonHandler
    {
        public static int deserialize(string path)
        {
            List<Activity> activitiesList = new List<Activity>();
            activitiesList = JsonConvert.DeserializeObject<List<Activity>>(path);
            int res = createXml(activitiesList);

            return res;
        }

        private static int createXml(List<Activity> list)
        {
            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // ROOT
            XmlElement root = doc.CreateElement("exercises");
            doc.AppendChild(root);

            foreach (Activity act in list)
            {
                XmlElement exercise = doc.CreateElement("exercise");

                XmlElement activity = doc.CreateElement("activity");
                activity.InnerText = act.Nome;
                XmlElement met = doc.CreateElement("met");
                met.InnerText = act.Met.ToString();
                XmlElement calories = doc.CreateElement("calories");
                calories.InnerText = act.Calorias.ToString();

                exercise.AppendChild(activity);
                exercise.AppendChild(met);
                exercise.AppendChild(calories);
                root.AppendChild(exercise);
            }
            doc.Save(@"..\\..\\XML\\Xml_Files\\exercises.xml");

            return 1;
        }
    }
}
