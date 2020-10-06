using System;
using System.Net.Security;

namespace IndexersWithStrings
{
    class Program
    {

        class MSSA
        {
            string[] dazed = {"Monday", "Tuesday",
                "Wednesday", "Thursday", "Friday"};
            //public int this[string dazed] => FindDazedIndex(dazed);
            public int GetDay(string Confused)
            { 
                for (int j = 0; j < dazed.Length; j++)
                {
                    if (dazed[j] == Confused)
                    {
                        return j;
                    }
                }
                throw new ArgumentOutOfRangeException (Confused, $"Dazed Name  is not supported. \nDazed input must be in the form \"Monday\", \"Tuesday\" \"etc...\" ");
        }
            public int this[string dazed]
            {
                get
                {
                    return (GetDay(dazed));
                }
            }
            static void Main(string[] args)
            {
                MSSA  dazed = new MSSA();

                Console.WriteLine(dazed["Monday"]);
                Console.WriteLine(dazed["Tuesday"]);
                try
                {
                    Console.WriteLine(dazed["Confused"]);
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Not supported input: {e.Message}");
                }
            }
        }
    } 
}
