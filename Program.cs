namespace File_IO_On_TXT_CSV_And_JSON
{
    internal class Program
    {  
        static void Main(string[] args)
        {
            Console.WriteLine("File IO On TEXT DATA ");
               File_IO_TXT file_IO_TXT = new File_IO_TXT();
               file_IO_TXT.file_IO_Text();
               Console.WriteLine();

              Console.WriteLine("File IO On CSV DATA ");
              File_IO_CSV file_IO_CSV = new File_IO_CSV();
              file_IO_CSV.File_IO__CSV();
              Console.WriteLine();

            Console.WriteLine("File IO On JSON DATA ");
            File_IO_JSON file_IO_JSON = new File_IO_JSON();
            file_IO_JSON.File_IO__JSON();


        }
    }
}
