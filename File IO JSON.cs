using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_On_TXT_CSV_And_JSON
{
    internal class File_IO_JSON
    {
        public void File_IO__JSON() {

             var jsonData = new
            {
                Name = "Sai",
                Age =22,
                Location = "Hyderabad"
            };

            string FilePath = @"C:\Users\HP\OneDrive\Desktop\RFP(Remap)\File IO On TXT,CSV And JSON\JSON.json";

             string jsonContent = JsonConvert.SerializeObject(jsonData, Formatting.Indented);
            File.WriteAllText(FilePath, jsonContent);

             string jsonText = File.ReadAllText(FilePath);
            var deserializedData = JsonConvert.DeserializeObject(jsonText);

            Console.WriteLine("JSON File Content:");
            Console.WriteLine(JsonConvert.SerializeObject(deserializedData, Formatting.Indented));


        }
    }
}
