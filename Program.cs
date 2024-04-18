using System.Runtime.InteropServices;

namespace List_assingment_UPDATED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numRange = new List<int>();
            int numCalled = 0, menuChoice, removeValue, addValue, interestNum, biggestNum,smallestNum;
            int numCount = 0, numTotal = 0;
            string menuTwoChoice;
            bool menu = false, validValue, advancedMenu = false;
            
                for (int t = 0; t < 25; t++)
                {
                    numRange.Add(generator.Next(10, 21));
                }
            Console.WriteLine("Here are your numbers:");
            
            while (!menu)
            {
                Console.Clear();
                for (int i = 0; i < ((numRange.Count / 5) + 1); i++)
                {
                    int u;
                    if ((numRange.Count / 5) == i)
                    {
                        u = numRange.Count - (i * 5);
                    }
                    else
                    {
                        u = 5;
                    }
                    for (int t = 0; t < u; t++)
                    {

                        Console.Write(numRange[numCalled] + ", ");
                        numCalled++;
                    }
                    Console.WriteLine();
                }
                numCalled = 0;
                Console.WriteLine("1) Sort your List (lowest to highest)\n2) Refresh your numbers \n3) Remove a value \n4) Add a value \n5) How many times does a number appear? \n6) Largest value \n7) Smallest value \n8) Advanced Options \n9) QUIT");
                Console.WriteLine("Write here what you want to explore first! ():");
                if(int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    if (menuChoice ==1)
                    {
                        Console.WriteLine("Here are your numbers in a new ordered fashion:");
                        numRange.Sort();
                        
                    }
                    else if (menuChoice == 2)
                    {
                        numRange.Clear();
                        for (int t = 0; t < 25; t++)
                        {
                            numRange.Add(generator.Next(10, 21));
                        }
                        Console.WriteLine("Your NEW numbers good sir:") ;
                        

                    }
                    else if (menuChoice == 3)
                    {
                        validValue = false;
                        while (!validValue)
                        {
                            Console.WriteLine("Please enter the number you want removed from the entire list (whole number only):");
                            if (int.TryParse(Console.ReadLine(), out removeValue))
                            {
                                for (int k = 0; k < numRange.Count; k++)
                                {
                                    if (removeValue == numRange[k])
                                    {
                                        numRange.RemoveAt(k);
                                        k--;
                                    }
                                }
                                Console.WriteLine("Let's take a look at your updated values:");
                                
                                validValue = true;
                            }
                            else
                            {
                                Console.WriteLine("Your number was either contained a decimal word or wasn't proper yeah? \nTRY AGAIN!");
                            }
                        }
                    }
                    else if (menuChoice == 4)
                    {
                        validValue = false;
                        while (validValue == false)
                        {
                            Console.WriteLine("Please type the number you would like to add to your collection \n(Whole numbers as usual):");
                            if (int.TryParse(Console.ReadLine().Trim(), out addValue))
                            {
                                numRange.Add(addValue);
                                Console.WriteLine("Your new numbers:");
                                
                                validValue = true;
                            }
                            else
                            {
                                Console.WriteLine("Looks like your given value had either decimals or letters, Please try again \n");
                                Thread.Sleep(1000);
                            }
                        }
                    }
                    else if (menuChoice == 5)
                    {
                        validValue = false;
                        Console.WriteLine("So what number peeked your interest today?\n(Whole numbers only):");
                        while (validValue == false)
                        {
                            if (int.TryParse(Console.ReadLine().Trim(),out interestNum))
                            {
                                for (int i = 0; i < numRange.Count; i++)
                                {
                                    if (numRange[i]==interestNum)
                                    {
                                        numCount++;
                                    }
                                }
                                Console.WriteLine($"\nNumber of '{interestNum}'s: {numCount}");
                                interestNum = 0;
                                Thread.Sleep(1000);
                                validValue = true;
                            }
                            else
                            {
                                Console.WriteLine("*INVALID INPUT* \nmake sure your number has no deciamls or letters:");
                            }
                        }
                    }
                    else if (menuChoice == 6)
                    {
                        biggestNum = numRange[0];
                        for (int i = 0; i < numRange.Count; i++)
                        {
                         if (biggestNum < numRange[i])
                            {
                                biggestNum = numRange[i];
                            }
                        }
                     Console.WriteLine($"After looking over your list we've narrowed your biggest number to a lowly {biggestNum}");
                    }
                    else if (menuChoice == 7)
                    {
                        smallestNum = numRange[0];
                        for (int i = 0; i < numRange.Count; i++)
                        {
                            if (smallestNum > numRange[i])
                            {
                                smallestNum = numRange[i];
                            }
                        }
                    }
                    else if (menuChoice == 8)
                    {
                       while (advancedMenu == false)
                        {
                            Console.WriteLine("In here you can find the three functions of data sets! \na) The mean (average)\nb) The median (middle number)\nc)The mode (most common number) \nd) Back to main menu");
                        menuTwoChoice = Console.ReadLine().ToLower().Trim();
                            if (menuTwoChoice == "a")
                            {
                                for (int i = 0; i < numRange.Count; i++)
                                {
                                    numTotal = numTotal + numRange[i];
                                }
                                Console.WriteLine($"The average of your numbers add up to be... {numTotal/numRange.Count} \nGood luck!");
                            }
                            if (menuTwoChoice == "b")
                            {
                                if (numRange.Count % 2 == 0)
                                {
                                    Console.WriteLine($"Your middle number is between {(numRange[numRange.Count/2]+ numRange[(numRange.Count / 2)+1])/2}");   
                                }
                                else
                                {
                                    Console.WriteLine($"Your median number is {numRange[numRange.Count / 2]}");
                                }
                            }
                            if (menuTwoChoice == "c")
                            {
                                
                            }
                        }
                    }
                    else if (menuChoice == 9)
                    {
                        menu = true;
                    }
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                }

            }
        }
    }
}