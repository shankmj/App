using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderName = @"D:\ADC\ADC-Demo-Main\Pipeline_Configuration_File";
            foreach (var files in System.IO.Directory.GetFiles(folderName))
{
                System.IO.FileInfo info = new System.IO.FileInfo(files);
                var fileName = System.IO.Path.GetFileName(info.FullName);
                Console.WriteLine(fileName);
            }
            Console.ReadLine();
            
        }
    }
}
