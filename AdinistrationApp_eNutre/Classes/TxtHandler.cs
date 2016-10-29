using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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


        public void carregarTXT(string path)
        {
            try
            {
                string ficheiroTXT = System.IO.File.ReadAllText(path);
                vegetables = ficheiroTXT.Split('\n');
                List<string> listVeg = new List<string>(vegetables);
                createXml(listVeg);
            }
            catch (FileNotFoundException)
            {

                MessageBox.Show("Ficheiro texto nao encontrado", "Aviso", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning);
            }//criar para xml mal criado
        }

        private void createXml(List<string> listVeg)
        {
            int conta = 0;
            XmlDocument doc = new XmlDocument();
            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
            doc.AppendChild(dec);
            // ROOT
            XmlElement root = doc.CreateElement("foods");
            doc.AppendChild(root);

            foreach (string veg in listVeg)
            {
                conta++;
                int nomeIndex;
                string[] porEspaco = veg.Split(' ');
                string[] porP = veg.Split('(');
                int ultimo = porP.Count() - 1;

                XmlElement food = doc.CreateElement("food");
                XmlElement vegetable = doc.CreateElement("vegetable");
                food.AppendChild(vegetable);
                XmlElement name = doc.CreateElement("name");
                vegetable.AppendChild(name);

                for (nomeIndex = 4; nomeIndex < porEspaco.Length; nomeIndex++)
                {
                    if (porEspaco[nomeIndex].StartsWith("("))
                    {
                        for (int x = 4; x < nomeIndex; x++)
                        {
                            if (x == nomeIndex - 1)
                            {
                                name.InnerText += porEspaco[x];
                            }
                            else
                            {
                                name.InnerText += porEspaco[x] + " ";
                            }
                        }
                        break;
                    }
                }

                if (porP.Count() > 2)
                {
                    for (int extraIndex = 1; extraIndex < porP.Length - 1; extraIndex++)
                    {
                        XmlElement extraInfo = doc.CreateElement("extraInfo");
                        extraInfo.InnerText = tiraParentesis(porP[extraIndex], 2);
                        vegetable.AppendChild(extraInfo);
                    }
                }

                XmlElement quantity = doc.CreateElement("quantity");
                if (listVeg.Count() == conta)
                {
                    quantity.InnerText = tiraParentesis(porP[ultimo],3);
                }
                else
                {
                    quantity.InnerText = tiraParentesis(porP[ultimo],4);
                }
                vegetable.AppendChild(quantity);

                XmlElement calories = doc.CreateElement("calories");
                calories.InnerText = porEspaco[1];
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
