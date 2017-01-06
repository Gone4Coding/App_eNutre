﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AdinistrationApp_eNutre.Forms;
using Microsoft.Office.Core;

namespace AdinistrationApp_eNutre.Classes
{
    public static class TxtHandler
    {
        public static XmlDocument createXml(string path)
        {
            XmlDocument doc = new XmlDocument();

            try
            {
                string ficheiroTXT = System.IO.File.ReadAllText(path);
                string[] vegetables = ficheiroTXT.Split('\n');

                List<string> listVeg = new List<string>(vegetables);
                int conta = 0;
                int id = 0;
                
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);

                // ROOT
                XmlElement root = doc.CreateElement("foods");
                doc.AppendChild(root);

                foreach (string veg in listVeg)
                {
                    conta++;
                    id++;
                    int nomeIndex;
                    string[] porEspaco = veg.Split(' ');
                    string[] porP = veg.Split('(');
                    int ultimo = porP.Count() - 1;

                    XmlElement food = doc.CreateElement("food");
                    XmlElement vegetable = doc.CreateElement("vegetable");

                   
                    food.SetAttribute("id",id.ToString());

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
                    food.AppendChild(quantity);
                    XmlElement value = doc.CreateElement("value");
                    XmlElement unity = doc.CreateElement("unity");

                    string[] a = porP[ultimo].Split(' ');
                    int last = a.Count() - 1;

                    value.InnerText = a[0];

                    if (listVeg.Count() == conta)
                    {
                            unity.InnerText= tiraParentesis(a[last-1], 2);
                    }
                    else
                    {
                            unity.InnerText = tiraParentesis(a[last-1], 2);
                    }
                   
                    quantity.AppendChild(value);
                    quantity.AppendChild(unity);
                    

                    XmlElement calories = doc.CreateElement("calories");
                    food.AppendChild(calories);
                    XmlElement caloriesValue = doc.CreateElement("value");
                    XmlElement caloriesUnity = doc.CreateElement("unity");

                   
                    caloriesValue.InnerText = porEspaco[1];
                    if (porEspaco[2].Equals("calorias"))
                    {
                        caloriesUnity.InnerText = "cal";
                    }
                    else
                    {
                        caloriesUnity.InnerText = "kcal";
                    }
                    calories.AppendChild(caloriesValue);
                    calories.AppendChild(caloriesUnity);

                    root.AppendChild(food);
                }
            }
            catch (Exception)
            {
                return null;
            }
            return doc;
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
