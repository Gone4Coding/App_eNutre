using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Excel = Microsoft.Office.Interop.Excel;


namespace AdinistrationApp_eNutre.Classes
{
    public static class ExcelHandler
    {
        public static int createXml(string path)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook workBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet workSheet = workBook.Worksheets.get_Item(1);

            XmlDocument doc = new XmlDocument();

            XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", null, null);
            doc.AppendChild(dec);

            // ROOT
            XmlElement root = doc.CreateElement("foods");
            doc.AppendChild(root);

            for (int line = 1; line <= workSheet.Rows.Count; line++)
            {
                XmlElement food = doc.CreateElement("food");

                XmlElement restaurant = doc.CreateElement("restaurant");
                restaurant.InnerText = workSheet.Cells[line, 1].Value;
                XmlElement item = doc.CreateElement("item");
                item.InnerText = workSheet.Cells[line, 2].Value;
                XmlElement quantity = doc.CreateElement("quantity");
                quantity.InnerText = workSheet.Cells[line, 3].Value;
                XmlElement calories = doc.CreateElement("calories");
                calories.InnerText = workSheet.Cells[line, 4].Value;

                food.AppendChild(restaurant);
                food.AppendChild(item);
                food.AppendChild(quantity);
                food.AppendChild(calories);
                root.AppendChild(food);
            }
            doc.Save(@"..\\..\\XML\\Xml_Files\\restaurants.xml");

            workBook.Close();
            excelApplication.Quit();

            return 1;
        }

    }
}
