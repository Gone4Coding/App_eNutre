using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using AdministrationApp_eNutre.Classes;

namespace AdinistrationApp_eNutre.Classes
{
    class TxtHandler
    {
       // private List<string> vegetal;
        private string[] vegetalSplit;
        private string[] vegetalSplitP;
        private string[] vegetalSplitComma;
        private string[] vegetables;

        public void carregarTXT()
        {
            string ficheiroTXT =
                System.IO.File.ReadAllText(
                    @"C:\Users\j17vi\Source\Repos\App_eNutre\AdinistrationApp_eNutre\Info\calorias_vegetais.txt");

            vegetables = ficheiroTXT.Split('\n');
            // Vegetable vegetable = new Vegetable(vegetables); 
            for (int i = 0; i < vegetables.Length; i++)
            {
                vegetalSplit = vegetables[i].Split(' ');
                vegetalSplitP = vegetables[i].Split('(');
            }

        }

        public string devolveNome()
        {
            return vegetalSplit[4];
        }

        public string devolveCalorias()
        {
            return vegetalSplit[1];
        }
        
        public string devolveQuantidade()
        {
           // int a = vegetalSplitP.Count();
            if (vegetalSplitP.Count() == 2)
            {
                return vegetalSplitP[1];
            }
            else if (vegetalSplitP.Count() == 3)
            {
                return vegetalSplitP[2];
            }
            else
            {
                return vegetalSplitP[3];
            }
            
        }

        public string devolveExtaInfo()
        {
            if (vegetalSplitP.Count() == 2)
            {
                return "";
            }
            else
            {
                return vegetalSplitP[1];
            }  
        }

        private static void createXml(string[] vegetables, string[] vegetableSplitP, string[] vegetableSplitComma)
        {

            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // ROOT
            XmlElement root = doc.CreateElement("foods");
            doc.AppendChild(root);
            
           

            for (int i = 0; i < vegetables.Length ; i++)
            {
                XmlElement food = doc.CreateElement("food");
                XmlElement vegetable = doc.CreateElement("vegetable");
                //food.InnerText = 
                XmlElement name = doc.CreateElement("name");
                XmlElement extraInfo = doc.CreateElement("extraInfo");
                XmlElement quantity = doc.CreateElement("quantity");
                XmlElement calories = doc.CreateElement("calories");


                //activity.InnerText = act.Nome;

                // met.InnerText = act.Met.ToString();

                // calories.InnerText = act.Calorias.ToString();

                /*
                exercise.AppendChild(activity);
                exercise.AppendChild(met);
                exercise.AppendChild(calories);
                root.AppendChild(exercise);*/
            }
            doc.Save(@"..\\..\\XML\\Xml_Files\\vegetables.xml");
        }


    }
}
