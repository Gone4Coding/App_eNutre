using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using AdinistrationApp_eNutre.Forms;
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
                    XmlElement food = doc.CreateElement("food");

                    XmlElement restaurant = doc.CreateElement("restaurant");
                    restaurant.InnerText = workSheet.Cells[line, 1].Value;

                    XmlElement item = doc.CreateElement("item");
                    item.InnerText = workSheet.Cells[line, 2].Value;

                    XmlElement quantity = doc.CreateElement("quantity");
                    quantity.InnerText = workSheet.Cells[line, 3].Value;

                    XmlElement calories = doc.CreateElement("calories");
                    string cal = workSheet.Cells[line, 4].Value;
                    string[] split = cal.Split(' ');
                    calories.InnerText = split[0];

                    food.AppendChild(restaurant);
                    food.AppendChild(item);
                    food.AppendChild(quantity);
                    food.AppendChild(calories);
                    root.AppendChild(food);
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


    }
}
