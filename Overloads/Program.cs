namespace Overloads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StylishPrint("Hello, World!");
            StylishPrint("Hello, World!", 200);
        }

        static void StylishPrint(string toPrint, int timeBetweenLetters)
        {
            foreach (char letter in toPrint)
            {
                Console.Write(letter);
                Thread.Sleep(timeBetweenLetters);
            }
            Console.WriteLine();
        }
        static void StylishPrint(string toPrint)
        {
            foreach (char letter in toPrint)
            {
                Console.Write(letter);
                Thread.Sleep(60);
            }
            Console.WriteLine();
        }

    }
}
