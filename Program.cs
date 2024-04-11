namespace List_assingment_UPDATED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numRange = new List<int>();
            int numCalled = 0, menuChoice;
            bool menu = true;
            
                for (int t = 0; t < 25; t++)
                {
                    numRange.Add(generator.Next(10, 21));
                }
            Console.WriteLine("Here are your numbers:");
            for (int i = 0; i < 5; i++)
            {

                for (int t = 0; t < 5; t++)
                {

                    Console.Write(numRange[numCalled] +", ");
                    numCalled++;
                }
                Console.WriteLine();
            }
            while (!menu)
            {
                Console.WriteLine("1) Sort your List \n2) Refresh your numbers \n3) Remove a value \n4) Add a value \n5) How many times does a number appear? \n6) Largest value \n7) Smallest value \n8) QUIT \n9) Advanced Options");
                Console.WriteLine("Write here what you want to eplore first! ():");
                if(int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    if (menuChoice ==1)
                    {

                    }
                    if (menuChoice == 2)
                    {

                    }
                    if (menuChoice == 3)
                    {

                    }
                    if (menuChoice == 4)
                    {

                    }
                    if (menuChoice == 5)
                    {

                    }
                    if (menuChoice == 6)
                    {

                    }
                    if (menuChoice == 7)
                    {

                    }
                    if (menuChoice == 8)
                    {

                    }
                    if (menuChoice == 9)
                    {

                    }
                }

            }
        }
    }
}