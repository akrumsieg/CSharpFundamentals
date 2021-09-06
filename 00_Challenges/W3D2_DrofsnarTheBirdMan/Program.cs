using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges.W3D2_DrofsnarTheBirdMan
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] birds = readCSV();
            foreach(string bird in birds)
            {
                Console.WriteLine(bird);
            }
        }

        static string[] readCSV()
        {
            try
            {
                string text = File.ReadAllText(@"C:\ElevenFiftyProjects\GoldBadge\CSharpFundamentals\00_Challenges\W3D2_DrofsnarTheBirdMan\Drofsnar.txt");
                string[] words = text.Split(',');
                return words;

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            return null;
        }

    }
}
