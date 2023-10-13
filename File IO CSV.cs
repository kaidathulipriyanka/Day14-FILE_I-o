using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_On_TXT_CSV_And_JSON
{
    internal class File_IO_CSV
    {
        public void File_IO__CSV() {

            // Example data for CSV file
            string FilePath = @"C:\\Users\\HP\\OneDrive\\Desktop\\RFP(Remap)\\File IO On TXT,CSV And JSON\\CSV.csv";

            string csvData = "Name,Age,Location\nSai,22,india\nbattu,25,Los Angeles\nram,35,Chicago";

            // Write to a CSV file
            File.WriteAllText(FilePath, csvData);

            // Read from a CSV file
            string csvContent = File.ReadAllText(FilePath);

            Console.WriteLine("CSV File Content:\n" + csvContent);


        }
    }
}
