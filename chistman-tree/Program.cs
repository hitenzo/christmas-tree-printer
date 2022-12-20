using System;

namespace chistman_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            //do napisania samemu: dodać użytkownikowi możliwość dodania opcjonalnej nóżki do choinki jako pojedynczy znak *

            //Console.WriteLine("Podaj wysykość choinki - liczba całkowita większa lub równa 2:");

            //check if it is number, maybe with int32.tryparse
            int christmanTreeHeight = ReadIntegerFromConsole();

            //read numberic input without evaluation:
            //string christmanTreeHeightString = Console.ReadLine();
            //int christmanTreeHeight = Convert.ToInt32(christmanTreeHeightString);

            Console.WriteLine("Twoja wysykość choinki: " + christmanTreeHeight.ToString());


            string characterPrint = ReadPrintingCharacter();

            //is is non use default

            Console.WriteLine("");
            Console.WriteLine("Zaczynamy:");
            Console.WriteLine("");


            for (int i = 1; i <= christmanTreeHeight; i++)
            {
                var emptySpacesNumber = christmanTreeHeight - i;
                var christmasTreeLevel = string.Empty;
                for (int j = 1; j <= emptySpacesNumber; j++)
                {
                    christmasTreeLevel = christmasTreeLevel + " ";
                }

                int christmanTreeLineWidth = 2 * i - 1;

                for (int u = 1; u <= christmanTreeLineWidth; u++)
                {
                    christmasTreeLevel = christmasTreeLevel + characterPrint;
                }

                Console.WriteLine(christmasTreeLevel);
            }

            string christmapTreeHolder = string.Empty;

            for (int i = 1; i <= christmanTreeHeight - 1; i++)
            {
                christmapTreeHolder = christmapTreeHolder + " ";
            }
            christmapTreeHolder = christmapTreeHolder + characterPrint;

            Console.WriteLine(christmapTreeHolder);

            Console.ReadLine();
        }


        public static int ReadIntegerFromConsole()
        {
            bool isInteger = false;
            int number = 0;

            while (!isInteger)
            {
                Console.WriteLine("Podaj wysykość choinki - liczba całkowita większa lub równa 2:");
                string input = Console.ReadLine();
                isInteger = Int32.TryParse(input, out number);
            }

            return number;
        }

        public static string ReadPrintingCharacter()
        {
            bool isCharacter = false;
            string input = string.Empty;

            while (!isCharacter)
            {
                Console.WriteLine("Podaj znak do rysowania choinki:");
                input = Console.ReadLine();
                isCharacter = !string.IsNullOrWhiteSpace(input);
            }

            return input;
        }
    }
}
