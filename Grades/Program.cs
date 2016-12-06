using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.Speak("Welcome");

            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade((float)89.5);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            Console.WriteLine("Press any key to continue...");
            string hello = Console.ReadLine();
            
        }
    }
}
