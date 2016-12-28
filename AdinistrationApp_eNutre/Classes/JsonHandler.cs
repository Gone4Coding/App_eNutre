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
        private class InnerActivity
        {
            private string nome;
            private int calorias;
            private double met;

            public InnerActivity(string nome, int calorias, double met)
            {
                this.nome = nome;
                this.met = met;
                this.calorias = calorias;
            }

            public string Nome
            {
                get { return nome; }
                set { nome = value; }
            }

            public int Calorias
            {
                get { return calorias; }
                set { calorias = value; }
            }

            public double Met
            {
                get { return met; }
                set { met = value; }
            }

            public override string ToString()
            {
                return "Activity: " + nome + "; MET: " + met + "; Cals/h: " + calorias;
            }
        }

        public static string createXml(string path)
        {
            bool isValid = true;
            string msg1 = "";
            string msg2;
            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);

                List<InnerActivity> activitiesList = new List<InnerActivity>();
                string file = System.IO.File.ReadAllText(path);
                activitiesList = JsonConvert.DeserializeObject<List<InnerActivity>>(file);

                // ROOT
                XmlElement root = doc.CreateElement("exercises");
                doc.AppendChild(root);

                int id = 1;

                foreach (InnerActivity act in activitiesList)
                {
                    XmlElement exerciseNode = doc.CreateElement("exercise");
                    exerciseNode.SetAttribute("id", id.ToString());

                    XmlElement activityNode = doc.CreateElement("activity");
                    activityNode.InnerText = act.Nome;

                    XmlElement metNode = doc.CreateElement("met");

                    XmlElement metNodeName = doc.CreateElement("name");
                    metNodeName.InnerText = "Metabolic Equivalent";
                    metNode.AppendChild(metNodeName);

                    XmlElement metNodeValue = doc.CreateElement("value");
                    metNodeValue.InnerText = act.Met.ToString().Replace(',', '.');
                    metNode.AppendChild(metNodeValue);

                    XmlElement caloriesNode = doc.CreateElement("calories");

                    XmlElement caloriesNodeValue = doc.CreateElement("value");
                    caloriesNodeValue.InnerText = act.Calorias.ToString();
                    caloriesNode.AppendChild(caloriesNodeValue);

                    XmlElement caloriesNodeUnity = doc.CreateElement("unity");
                    caloriesNodeUnity.InnerText = "kcal";
                    caloriesNode.AppendChild(caloriesNodeUnity);
                    

                    exerciseNode.AppendChild(activityNode);
                    exerciseNode.AppendChild(metNode);
                    exerciseNode.AppendChild(caloriesNode);
                    root.AppendChild(exerciseNode);

                    id++;
                }
                
                doc.Save(@"..\\..\\XML\\Xml_Files\\exercises.xml");

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, @"..\\..\\XML\\Schemas\\activitiesSchema.xsd");
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(@"..\\..\\XML\\Xml_Files\\exercises.xml",settings);
                doc.Load(reader);

                MessageBox.Show("Ficheiro Xml criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                isValid = false;
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                msg2 = isValid ? "O doc é valido!" : "O doc é invalido...";
            }
            return msg2;
        }

    }
}




