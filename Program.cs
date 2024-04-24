using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace List_assingment_UPDATED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<int> numRange = new List<int>();
            List<int> dupeList = new List<int>();
            int numCalled = 0, menuChoice, removeValue, addValue, interestNum, biggestNum, smallestNum, highestFreq, mode, freq, numCount = 0;
            double numTotal = 0;
            string menuTwoChoice, removeVeg;
            bool menu = false, validValue, advancedMenu = false;
            
                for (int t = 0; t < 25; t++)
                {
                    numRange.Add(generator.Next(10, 21));
                }
            Console.WriteLine("Here are your numbers:");
            
            while (!menu)
            {
                Console.Clear();
                numCalled = 0;
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
                        Console.WriteLine($"After looking over your list we've narrowed your smallest number to a lowly {smallestNum}");
                    }
                    
                    else if (menuChoice == 8)
                    {
                        advancedMenu = false;
                        while (advancedMenu == false)
                        {
                            Console.Clear();
                            numCalled = 0;
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

                            Console.WriteLine("In here you can find the three functions of data sets! \na) The mean (average)\nb) The median (middle number)\nc)The mode (most common number) \nd) Back to main menu");
                            menuTwoChoice = Console.ReadLine().ToLower().Trim();
                            if (menuTwoChoice == "a")
                            {
                                numTotal = 0;
                                for (int i = 0; i < numRange.Count; i++)
                                {
                                    numTotal = numTotal + numRange[i];
                                }
                                if (numRange.Count == 0)
                                {
                                    Console.WriteLine($"The average of your numbers add up to be... 0 \nGood luck!");
                                }
                                else
                                {
                                    Console.WriteLine($"The average of your numbers add up to be... {numTotal / numRange.Count} \nGood luck!");
                                }
                            }
                            else if (menuTwoChoice == "b")
                            {
                                dupeList = numRange.ToList();
                                dupeList.Sort();
                                if (dupeList.Count % 2 == 0)
                                {
                                    Console.WriteLine($"Your middle number is between {(dupeList[dupeList.Count/2]+ dupeList[(dupeList.Count / 2)+1])/2}");   
                                }
                                else
                                {
                                    Console.WriteLine($"Your median number is {dupeList[(dupeList.Count / 2) -1]}");
                                }
                                dupeList.Clear();
                            }
                            else if (menuTwoChoice == "c")
                            {
                                
                                mode = 0;
                                highestFreq = 0;
                                for (int i = 0;i < numRange.Count; i++)
                                {
                                    freq = 0;
                                    for (int j = 0;j < numRange.Count; j++)
                                    {
                                        if (numRange[i] == numRange[j])
                                        {
                                            freq++;
                                        }
                                    }
                                    if ( freq > highestFreq)
                                    {
                                        mode = numRange[i];
                                        highestFreq = freq;
                                    }
                                }
                                Console.WriteLine($"Here is one of if not the only most common number in your program: {mode}, appearing {highestFreq} times.");
                                
                            }
                            else if (menuTwoChoice == "d")
                            {
                                Console.Clear();
                                advancedMenu = true;
                                Console.WriteLine("Prepare to return to the menu");

                            }
                            else
                            {
                                Console.WriteLine("Your value wasn't on our list! Try again");
                                Thread.Sleep(500);
                            }
                            Console.WriteLine("Press 'Enter' to continue.");
                            Console.ReadLine();
                        }
                    }
                    if (menuChoice == 9)
                    {
                        menu = true;
                    }
                    Console.WriteLine("Press 'Enter' to continue to the main menu.");
                    Console.ReadLine();
                }

            }
            Console.Clear() ;   
            Console.WriteLine("Now let's move onto the vegetables!");
            Thread.Sleep(2000);
            List<string> vegetables = new List<string>();
            vegetables.Add("CARROT");
            vegetables.Add("BEET");
            vegetables.Add("CELERY");
            vegetables.Add("RADDISH");
            vegetables.Add("CABBAGE");
            menu = false;
            menuChoice = 0;
            while (menu == false)
            {
                Console.Clear();
                removeValue = 0;
                Console.WriteLine("Your vegetables:");
                for (int i = 0; i < vegetables.Count; i++)
                {
                    Console.WriteLine($"{i+1}) {vegetables[i]}");
                }
                Console.WriteLine("Options: \n1) Remove vegetable by index \n2) Remove vegetable by name \n3) Search for vegetable \n4) Add a vegetable \n5) Sort List \n6) Clear the List (Exit) \n \nWhere would you like to start?(enter a number listed the menu)");
                if (int.TryParse(Console.ReadLine(), out menuChoice))
                {
                    if (menuChoice == 1)
                    {
                        advancedMenu = false;
                        if (vegetables.Count == 0)
                        {
                            advancedMenu = true;
                            Console.WriteLine("Looks like your list of vegetables is already empty. \nPress 'Enter' to continue");
                            Console.ReadLine();
                        }
                        while (advancedMenu = false)
                        {
                            if (int.TryParse(Console.ReadLine(), out removeValue))
                            {
                                Console.WriteLine("Please enter the number corresponding with the vegetable that you want ");
                                if (removeValue <= vegetables.Count + 1 && removeValue >= vegetables.Count + 1)
                                {
                                    vegetables.RemoveAt(removeValue + 1);
                                }
                                else
                                {
                                    Console.WriteLine($"Your value isn't on the menu. Your vegetables are inbetween 1 - {vegetables.Count}. Try again");
                                }
                            }
                        }
                    }
                    if (menuChoice == 2)
                    {
                        Console.WriteLine("Type the vegetable you want removed from your list:");
                        removeVeg = Console.ReadLine().Trim().ToUpper();
                        if (vegetables.Contains(removeVeg))
                        {
                            for (int i = 0; i < vegetables.Count; i++)
                            {
                                if (removeVeg == vegetables[i])
                                {
                                    vegetables.RemoveAt(i);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Either you spelled the vegetable wrong, or your vegetable isn't on the index.");
                        }

                    }
                    if (menuChoice == 3)
                    {
                        Console.WriteLine("Type the vegetable you wanted to see about today:");
                        removeVeg = Console.ReadLine().Trim().ToUpper();
                        if (vegetables.Contains(removeVeg))
                        {
                            Console.WriteLine("\nYES - your list does include that vegetable");
                        }
                        else
                        {
                            Console.WriteLine("\nNO - your list does not include that vegetable");
                        }
                    }
                    if (menuChoice == 4)
                    {

                        Console.WriteLine("Please type the vegetable you want to add to your list");
                        removeVeg = Console.ReadLine().Trim().ToUpper();
                        if (vegetables.Contains(removeVeg))
                        {
                            Console.WriteLine("\nThat vegetable is already in your list.");
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            vegetables.Add(removeVeg);
                            Console.WriteLine("\n*Your vegetable has been added");
                            Thread.Sleep(1000);
                        }
                    }
                    if (menuChoice == 5)
                    {
                        vegetables.Sort();
                    }
                    if (menuChoice == 6)
                    {
                        vegetables.Clear();
                    }
                    if (vegetables.Count == 0)
                    {
                        menu = true;
                        Console.WriteLine("\nThanks for stopping by!");
                        Thread.Sleep(2500);
                    }
                    else if (menuChoice > 6 || menuChoice < 1)
                    {
                        Console.WriteLine("Your number wasn't on the menu try again with something a little more in range!");
                        Thread.Sleep(2000);
                    }
                    else
                    {
                    Console.WriteLine("Press 'Enter' to continue to the main menu.");
                    Console.ReadLine();
                    }

                }

            else
               {
                 Console.WriteLine("Doesn't look like you've entered a valid number or a word please try again");
                 Thread.Sleep(3000);
                }
            }

        }
    }
}