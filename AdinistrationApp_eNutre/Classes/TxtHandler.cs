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
        private string[] vegetables;
        private List<string> listVeg;

        public void carregarTXT(string path)
        {
            string ficheiroTXT = System.IO.File.ReadAllText(path);

            vegetables = ficheiroTXT.Split('\n');
            listVeg = new List<string>(vegetables);
            createXml(listVeg);
        }

        private void createXml(List<string> listVeg)
        {

            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);

            // ROOT
            XmlElement root = doc.CreateElement("foods");
            doc.AppendChild(root);

            foreach (string veg in listVeg)
            {
                string[] porEspaco = veg.Split(' ');
                string[] porP = veg.Split('(');
                int ultimo = porP.Count() - 1;

                XmlElement food = doc.CreateElement("food");
                XmlElement vegetable = doc.CreateElement("vegetable");
                XmlElement name = doc.CreateElement("name");
                name.InnerText = porEspaco[4];
                XmlElement extraInfo = doc.CreateElement("extraInfo");
                if (porP.Count() == 2)
                {
                    extraInfo.InnerText = "";
                }
                else
                {
                    extraInfo.InnerText = tiraParentesis(porP[1],2);
                }
                XmlElement quantity = doc.CreateElement("quantity");
                quantity.InnerText = tiraParentesis(porP[ultimo],4);
                XmlElement calories = doc.CreateElement("calories");
                calories.InnerText = porEspaco[1];
                food.AppendChild(vegetable);
                vegetable.AppendChild(name);
                vegetable.AppendChild(extraInfo);
                vegetable.AppendChild(quantity);
                vegetable.AppendChild(calories);
                root.AppendChild(food);
            }
            doc.Save(@"..\\..\\XML\\Xml_Files\\vegetables.xml");
        }

        public string tiraParentesis(string str,int ultimosChars)
        {
            int startIndex = 0;
            int parentesis = str.Length - ultimosChars;
            string substring = str.Substring(startIndex, parentesis);
            return substring;
        }
    }
}
