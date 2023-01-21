namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favofrite subject in school?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {

                case "math":
                Console.WriteLine("That must mean your good with numbers!");
                break;

                case "english":
                Console.WriteLine("Book reports were my favorite part of English Class!");
                break;

                case "sience":
                Console.WriteLine("Science was always exciting!");
                break;

                case "gym":
                Console.WriteLine("I always looked forward to playing games and exercising!");
                break;

                case "music":
                Console.WriteLine("I've always loved Music, but i was never a great singer.");
                break;

                default:
                Console.WriteLine("Cool, that's not a common one!");
                break;

            }

          


             

                



          }



        }
    }
