using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vlad
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(file.FileName))
                {
                    String line = sr.ReadToEnd();
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Введенные данные");
                    Console.WriteLine(line);
                    Console.ResetColor();

                    Regex regex = new Regex("\"[^\"]+\"");
                    var result = regex.Matches(line);

                    Console.WriteLine();
                    Console.WriteLine("РЕЗУЛЬТАТ:");
                    foreach (Match mt in result)
                    { 
                        Console.WriteLine(mt.Value);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
