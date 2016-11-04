using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using AdministrationApp_eNutre.Classes;
using Newtonsoft.Json;

namespace AdinistrationApp_eNutre.Classes
{
    public static class JsonHandler
    {
        public static string createXml(string path)
        {
            bool isValid = true;
            string msg1 = "";
            string msg2;
            string msg3 = "";
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);

                List<Activity> activitiesList = new List<Activity>();
                string file = System.IO.File.ReadAllText(path);
                activitiesList = JsonConvert.DeserializeObject<List<Activity>>(file);

                // ROOT
                XmlElement root = doc.CreateElement("exercises");
                doc.AppendChild(root);

                foreach (Activity act in activitiesList)
                {
                    XmlElement exercise = doc.CreateElement("exercise");

                    XmlElement activity = doc.CreateElement("activity");
                    activity.InnerText = act.Nome;
                    XmlElement met = doc.CreateElement("met");
                    met.InnerText = act.Met;
                    XmlElement calories = doc.CreateElement("calories");
                    calories.InnerText = act.Calorias.ToString();

                    exercise.AppendChild(activity);
                    exercise.AppendChild(met);
                    exercise.AppendChild(calories);
                    root.AppendChild(exercise);
                }
                
                doc.Save(@"..\\..\\XML\\Xml_Files\\exercises.xml");

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, @"..\\..\\XML\\Schemas\\activitiesSchema.xsd");
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(@"..\\..\\XML\\Xml_Files\\exercises.xml",settings);
                doc.Load(reader);

                MessageBox.Show("XML criado com sucesso");
            }
            catch (Exception ex)
            {
                isValid = false;
               MessageBox.Show(ex.Message);
            }
            finally
            {

                msg2 = isValid ? "O doc é valido!" : "O doc é invalido...";
                msg3 = msg1 + "\n" + msg2;
            }
            return msg3;
        }

    }
}




