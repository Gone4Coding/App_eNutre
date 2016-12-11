using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using AdinistrationApp_eNutre.Forms;
using AdministrationApp_eNutre.Classes;
using Excel = Microsoft.Office.Interop.Excel;


namespace AdinistrationApp_eNutre.Classes
{
    public static class ExcelHandler
    {
        public static string createXml(string path)
        {
            bool isValid = true;
            string msg1 = "";
            string msg2;

            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook workBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet workSheet = workBook.Worksheets.get_Item(1);

            try
            {
                XmlDocument doc = new XmlDocument();
                XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
                doc.AppendChild(dec);

                XmlElement root = doc.CreateElement("foods");
                doc.AppendChild(root);
                
                for (int line = 2; line <= workSheet.UsedRange.Rows.Count; line++)
                {
                    string restaurantName = workSheet.Cells[line, 1].Value;

                    XmlElement restaurantNode = doc.CreateElement("restaurant");
                    restaurantNode.SetAttribute("name", restaurantName);

                    XmlElement plateNode = getPlate(line, path);
                    restaurantNode.AppendChild(plateNode);

                    for(int lineAux = line + 1; lineAux <= workSheet.UsedRange.Rows.Count; lineAux++)
                    {
                        string restaurantNameAux = workSheet.Cells[lineAux, 1].Value;

                        if (restaurantNameAux.Equals(restaurantName))
                        {
                            XmlElement plateNodeAux = getPlate(lineAux, path);
                            restaurantNode.AppendChild(plateNodeAux);

                            line++;
                        }
                    }
                }
                
                doc.Save(@"..\\..\\XML\\Xml_Files\\restaurants.xml");

                XmlReaderSettings settings = new XmlReaderSettings();
                settings.Schemas.Add(null, @"..\\..\\XML\\Schemas\\restaurantsSchema.xsd");
                settings.ValidationType = ValidationType.Schema;

                XmlReader reader = XmlReader.Create(@"..\\..\\XML\\Xml_Files\\restaurants.xml", settings);
                doc.Load(reader);

                MessageBox.Show("Ficheiro Xml criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                workBook.Close();
                excelApplication.Quit();
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

        private static int id = 1;
        private static XmlElement getPlate(int line, string path)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook workBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet workSheet = workBook.Worksheets.get_Item(1);

            XmlDocument doc = new XmlDocument();
            XmlElement plateNode = doc.CreateElement("plate");
            plateNode.SetAttribute("id", id.ToString());

            XmlElement itemNode = doc.CreateElement("item");
            itemNode.InnerText = workSheet.Cells[line, 2].Value;

            XmlElement quantityNode = doc.CreateElement("quantity");

            string q = workSheet.Cells[line, 3].Value;
            string[] quantityArray = q.Split(' ');

            XmlElement quatityValue = doc.CreateElement("value");
            quatityValue.InnerText = quantityArray[0];
            quantityNode.AppendChild(quatityValue);

            XmlElement quantityDosage = doc.CreateElement("dosage");
            quantityDosage.InnerText = quantityArray[1];
            quantityNode.AppendChild(quantityDosage);

            if (!quantityArray[3].Equals(""))
            {
                string[] noLeftParentsis = quantityArray[3].Split('(');
                string[] noRightParentsis = noLeftParentsis[0].Split(')');
                string extraDosage = noRightParentsis[0];

                XmlElement quantityExtraDosage = doc.CreateElement("extraDosage");
                quantityExtraDosage.InnerText = extraDosage;
                quantityNode.AppendChild(quantityExtraDosage);
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

            return plateNode;
        }

    }
}
