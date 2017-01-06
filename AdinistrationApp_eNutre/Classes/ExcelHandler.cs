using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using AdinistrationApp_eNutre.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace AdinistrationApp_eNutre.Classes
{
    public static class ExcelHandler
    {
        public static XmlDocument createXml(string path)
        {
            XmlDocument doc = new XmlDocument();

            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook workBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet workSheet = workBook.Worksheets.get_Item(1);

            try
            {
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);

                XmlElement root = doc.CreateElement("foods");
                doc.AppendChild(root);

                int id = 1;

                for (int line = 2; line <= workSheet.UsedRange.Rows.Count; line++)
                {
                    string restaurantName = workSheet.Cells[line, 1].Value;

                    XmlElement restaurantNode = doc.CreateElement("restaurant");
                    restaurantNode.SetAttribute("name", restaurantName);

                    XmlElement plateNode = doc.CreateElement("plate");
                    plateNode.SetAttribute("id", id.ToString());

                    XmlElement itemNode = doc.CreateElement("item");
                    itemNode.InnerText = workSheet.Cells[line, 2].Value;

                    XmlElement quantityNode = doc.CreateElement("quantity");

                    string qUP = workSheet.Cells[line, 3].Value;
                    string[] quantityArray = qUP.Split(' ');

                    XmlElement quatityValue = doc.CreateElement("value");
                    XmlElement quantityDosage = doc.CreateElement("dosage");

                    if (quantityArray.Length == 1)
                    {
                        quatityValue.InnerText = "1";
                        quantityDosage.InnerText = quantityArray[0];
                    }
                    else
                    {
                        quatityValue.InnerText = quantityArray[0];
                        quantityDosage.InnerText = quantityArray[1];
                    }

                    quantityNode.AppendChild(quatityValue);
                    quantityNode.AppendChild(quantityDosage);

                    if (quantityArray.Length == 3)
                    {
                        if (!quantityArray[2].Equals(""))
                        {
                            string[] quantityArrayAux = quantityArray[2].Split('(', ')');
                            string extraDosage = quantityArrayAux[1];

                            XmlElement quantityExtraDosage = doc.CreateElement("extraDosage");
                            quantityExtraDosage.InnerText = extraDosage;
                            quantityNode.AppendChild(quantityExtraDosage);
                        }
                    }

                    XmlElement caloriesNode = doc.CreateElement("calories");

                    string c = workSheet.Cells[line, 4].Value;
                    string[] caloriesArray = c.Split(' ');

                    XmlElement caloriesValue = doc.CreateElement("value");
                    caloriesValue.InnerText = caloriesArray[0];
                    caloriesNode.AppendChild(caloriesValue);

                    XmlElement caloriesUnity = doc.CreateElement("unity");
                    caloriesUnity.InnerText = caloriesArray[1];
                    caloriesNode.AppendChild(caloriesUnity);

                    plateNode.AppendChild(itemNode);
                    plateNode.AppendChild(quantityNode);
                    plateNode.AppendChild(caloriesNode);

                    id++;

                    restaurantNode.AppendChild(plateNode);

                    for (int lineAux = line + 1; lineAux <= workSheet.UsedRange.Rows.Count; lineAux++)
                    {
                        string restaurantNameAux = workSheet.Cells[lineAux, 1].Value;

                        if (restaurantNameAux.Equals(restaurantName))
                        {
                            XmlElement plateNodeSecond = doc.CreateElement("plate");
                            plateNodeSecond.SetAttribute("id", id.ToString());

                            XmlElement itemNodeSecond = doc.CreateElement("item");
                            itemNodeSecond.InnerText = workSheet.Cells[line, 2].Value;

                            XmlElement quantityNodeSecond = doc.CreateElement("quantity");

                            string q = workSheet.Cells[line, 3].Value;
                            string[] quantityArraySecond = q.Split(' ');

                            XmlElement quatityValueSecond = doc.CreateElement("value");

                            XmlElement quantityDosageSecond = doc.CreateElement("dosage");

                            if (quantityArraySecond.Length == 1)
                            {
                                quatityValueSecond.InnerText = "1";
                                quantityDosageSecond.InnerText = quantityArraySecond[0];
                            }
                            else
                            {
                                quatityValueSecond.InnerText = quantityArraySecond[0];
                                quantityDosageSecond.InnerText = quantityArraySecond[1];
                            }

                            quantityNodeSecond.AppendChild(quatityValueSecond);
                            quantityNodeSecond.AppendChild(quantityDosageSecond);

                            if (quantityArraySecond.Length == 3)
                            {
                                if (!quantityArraySecond[2].Equals(""))
                                {
                                    string[] quantityArraySecondAux = quantityArraySecond[2].Split('(', ')');
                                    string extraDosage = quantityArraySecondAux[1];

                                    XmlElement quantityExtraDosage = doc.CreateElement("extraDosage");
                                    quantityExtraDosage.InnerText = extraDosage;
                                    quantityNodeSecond.AppendChild(quantityExtraDosage);
                                }
                            }

                            XmlElement caloriesNodeSecond = doc.CreateElement("calories");

                            string cAux = workSheet.Cells[line, 4].Value;
                            string[] caloriesArraySecond = cAux.Split(' ');

                            XmlElement caloriesValueSecond = doc.CreateElement("value");
                            caloriesValueSecond.InnerText = caloriesArraySecond[0];
                            caloriesNodeSecond.AppendChild(caloriesValueSecond);

                            XmlElement caloriesUnitySecond = doc.CreateElement("unity");
                            caloriesUnitySecond.InnerText = caloriesArraySecond[1];
                            caloriesNodeSecond.AppendChild(caloriesUnitySecond);

                            plateNodeSecond.AppendChild(itemNodeSecond);
                            plateNodeSecond.AppendChild(quantityNodeSecond);
                            plateNodeSecond.AppendChild(caloriesNodeSecond);
                            restaurantNode.AppendChild(plateNodeSecond);

                            id++;

                            line++;
                        }
                    }

                    root.AppendChild(restaurantNode);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            return doc;
        }
       
    }
}
