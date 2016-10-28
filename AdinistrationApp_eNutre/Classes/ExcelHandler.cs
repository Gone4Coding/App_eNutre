using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace AdinistrationApp_eNutre.Classes
{
    public static class ExcelHandler
    {
        public static void createXml(string path)
        {
            Excel.Application excelApplication = new Excel.Application();
            excelApplication.Visible = false;

            Excel.Workbook workBook = excelApplication.Workbooks.Open(path);
            Excel.Worksheet workSheet = workBook.Worksheets.get_Item(1);

            List<String> resutList = new List<string>();
            for (int line = 1; line <= workSheet.Rows.Count; line++)
            {
                string result = "";

                for (int colunm = 1; colunm <= 4; colunm++)
                {
                    result += ""+ workSheet.Cells[line, colunm].Value;
                }
            
                resutList.Add(result);
                //Console.WriteLine(result);
            }
        }
    }
}
