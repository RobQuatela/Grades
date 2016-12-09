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
            GradeBook book = new GradeBook();

            Console.Write("Please enter a name: ");

            try
            {
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            book.AddGrade(75);
            book.AddGrade((float)89.5);
            book.AddGrade(0);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
            WriteResult("Response", stats.Description);

            Console.WriteLine("Press any key to continue...");
            string hello = Console.ReadLine();
            
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak(result);
        }

        static string AskForName(GradeBook book)
        {
            do
            {
                book.Name = Console.ReadLine();
            } while (book.Name == null);

            return book.Name;
        }

    }
}
