using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
namespace File_IO_On_TXT_CSV_And_JSON
{
    internal class File_IO_TXT
    {
        public void file_IO_Text()
        {
            string filePath = @"C:\\Users\\HP\\OneDrive\\Desktop\\RFP(Remap)\\File IO On TXT,CSV And JSON\\Text.txt";

            string txtData = "This is example text data for a TXT file.";


            File.WriteAllText(filePath, txtData);

            string txtContent = File.ReadAllText(filePath);
            Console.WriteLine("TXT File Content:\n" + txtContent);

        }
    }
}
