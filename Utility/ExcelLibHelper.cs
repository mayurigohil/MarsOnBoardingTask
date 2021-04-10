using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MarsOnboardingTask.Utility
{
    class ExcelLibHelper
    {
        private static DataTable ExcelToDataTable(string filename)
        {
           
            FileStream stream = File.Open(filename, FileMode.Open, FileAccess.Read);
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            

            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            //ExcelReaderFactory.CreateBinaryReader(stream);
            

            DataSet resultset = excelReader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                }
            });

            DataTableCollection table = resultset.Tables;
            DataTable resultTable = table["Credentials"];
            return resultTable;
        }
      
        public class Datacollection
        {
            public int rowNumber { get; set; }
            public string colName { get; set; }
            public string colValue { get; set; }
        }

        static List<Datacollection> dataCol = new List<Datacollection>();
        public static void PopulateInDataCollection(string filename)
        {
            DataTable table = ExcelToDataTable(filename);
            for (int row = 1; row <= table.Rows.Count; row++) 
            {
                for (int col = 0; col < table.Columns.Count; col++) 
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        rowNumber = row,
                        colName = table.Columns[col].ColumnName,
                        colValue = table.Rows[row - 1][col].ToString()

                    };
                    dataCol.Add(dtTable);
                }

            }
        }

        public static string ReadData(int rowNumber, string columnName)
        {
            try
            {
                rowNumber = rowNumber - 1;
                var data = (from colData in dataCol
                            where (colData.colName == columnName) && (colData.rowNumber == rowNumber)
                            select colData.colValue).SingleOrDefault();

              
                return data;

            }
            catch(Exception e)
            {
                return null;
            }

        }
    }

}

