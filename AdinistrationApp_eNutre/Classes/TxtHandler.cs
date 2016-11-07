using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AdinistrationApp_eNutre.Forms;
using AdministrationApp_eNutre.Classes;
using Microsoft.Office.Core;

namespace AdinistrationApp_eNutre.Classes
{
    public static class TxtHandler
    {


        public static string createXml(string path)
        {
            string msg1 = "";
            string msg2;
           
            bool isValid = true;
            string filenameXML = @"..\\..\\XML\\Xml_Files\\vegetables.xml";

            try
            {
                string ficheiroTXT = System.IO.File.ReadAllText(path);
                string[] vegetables = ficheiroTXT.Split('\n');

                List<string> listVeg = new List<string>(vegetables);
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

                    for (nomeIndex = 4; nomeIndex < porEspaco.Length; nomeIndex++)
                    {
                        if (porEspaco[nomeIndex].StartsWith("("))
                        {
                            for (int x = 4; x < nomeIndex; x++)
                            {
                                if (x == nomeIndex - 1)
                                {
                                    vegetable.InnerText += porEspaco[x];
                                }
                                else
                                {
                                    vegetable.InnerText += porEspaco[x] + " ";
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
                            food.AppendChild(extraInfo);
                        }
                    }

                    XmlElement quantity = doc.CreateElement("quantity");
                    if (listVeg.Count() == conta)
                    {
                        quantity.InnerText = tiraParentesis(porP[ultimo], 3);
                    }
                    else
                    {
                        quantity.InnerText = tiraParentesis(porP[ultimo], 4);
                    }
                    food.AppendChild(quantity);

                    XmlElement calories = doc.CreateElement("calories");
                    calories.InnerText = porEspaco[1];
                    food.AppendChild(calories);

                    root.AppendChild(food);
                }

                doc.Save(filenameXML);

                MessageBox.Show("Ficheiro Xml criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                XmlReaderSettings xsdReader = new XmlReaderSettings();
                string vegetablesXsd = @"..\\..\\XML\\Schemas\\vegetablesSchema.xsd";

                xsdReader.Schemas.Add(null, vegetablesXsd);
                xsdReader.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(filenameXML, xsdReader);
                doc.Load(reader);

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

        private static string tiraParentesis(string str, int ultimosChars)
        {
            int startIndex = 0;
            int parentesis = str.Length - ultimosChars;
            string substring = str.Substring(startIndex, parentesis);

            return substring;
        }


    }
}
