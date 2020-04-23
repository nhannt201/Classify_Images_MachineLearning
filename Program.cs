using System;
using System.Diagnostics;
using System.IO;
using CamXucMLML.Model;
/* Designed and developed by Nguyen Trung Nhan
 * Contact: trungnhan21.12@gmail.com
 * Based on ML.NET sample at https://github.com/dotnet/machinelearning-samples/blob/master/README.md
 * My git: https://github.com/nhannt201
 */
namespace CamXucML
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Machine Learning - My picture!");
            Console.WriteLine("Import photos from folder...");
            string[] fileArray = Directory.GetFiles(@"C:\Users\lenovo\Desktop\Scan\");
            for (int i = 0; i < fileArray.Length; i++)
            {

                string filename = null;
                // using the method 
                filename = Path.GetFileName(fileArray[i]);
                // Add input data
              //  Console.ForegroundColor = ConsoleColor.Yellow;
                var input = new ModelInput();
                input.ImageSource = fileArray[i];
                // Load model and predict output of sample data
                ModelOutput result = ConsumeModel.Predict(input);
                string datac =  String.Join(",", result.Score) ;
               string[] words = datac.Split(',');
                Console.WriteLine($"-------------- {result.Prediction} - {filename} Diem: " + datac);
                string destinationFile = @"C:\Users\lenovo\Desktop\Result\" + result.Prediction + @"\" + filename;
                // To move a file or folder to a new location:
                System.IO.File.Copy(fileArray[i], destinationFile);
                Console.WriteLine("--------------------- Copy a image to " + result.Prediction + @" - C:\Users\lenovo\Desktop\Result\" + result.Prediction);
             //   Console.WriteLine(@"C:\Users\lenovo\Desktop\Result\" + result.Prediction);
                Console.WriteLine("------>Next Scan<------------------");
           
               
            }
            Console.WriteLine("Scanned!");
            Console.ReadKey();
        }
    }
}
