using System;

namespace ExceptionHandling
{
    public class MeineException : Exception
    {
        public MeineException() : base("Dies ist mein Fehler")
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string eingabe = Console.ReadLine();
                int zahl = int.Parse(eingabe);

                throw new MeineException();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Du musst eine Zahl eingeben. " + ex.Message);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Deine Zahl ist zu groß/klein. " + ex.Message);

                throw;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten. " +ex.Message);
            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt");
            }

            Console.WriteLine("Ende des Try/Catch-Blocks");
        }
    }
}
