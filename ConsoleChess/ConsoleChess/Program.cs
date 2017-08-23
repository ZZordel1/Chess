using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess
{
    public class Program
    {
        private static readonly string[] letters = { "A", "B", "C", "D", "E", "F", "G", "H" };
        private const int size = 8;
        static void Main(string[] args)
        {
            Chessboard();

        }

        private static void Chessboard()
        {



            const string top = " -----------------";
            const string line = "| | | | | | | | |";
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(" {0}", top);
                Console.WriteLine("{0} {1}", size - i, line);
            }
            Console.WriteLine(" {0}", top);
            Console.Write("   ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", letters[i]);
            }
            Console.ReadKey();
        }
    }
}


