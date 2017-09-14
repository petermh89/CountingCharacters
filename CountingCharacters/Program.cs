using System;
using System.Collections.Generic;
using System.Linq;

namespace CountingCharacters
{   //This counts all occurrences of a char in a string inputed by a user in the console
    class Program
    { 

        static void Main(string[] args)
        {
            Console.WriteLine("What string do you wish to count the Characters of?");
            string text = Console.ReadLine();

            Console.WriteLine("Do you want to include non alphabetic characters? y or n");
            string WhatChar = Console.ReadLine();

            //checks if input is in format "y" or "n"
            while (WhatChar != "y" && WhatChar != "n")
            {
                Console.WriteLine("Please answer y or n");
                WhatChar = Console.ReadLine();
                
            }

            Dictionary<string, int> LetterCount = new Dictionary<string, int>();
            text = text.ToUpper();
            WhatChar = WhatChar.ToLower();

            //Gives the user the option whether they'd like too include alpha characters or not

            if (WhatChar == "y") {
                foreach (char i in text)
                {
                    int Value = text.Where(x => x == i).Count();

                    if (LetterCount.ContainsKey(i.ToString()))
                    {
                        continue;
                    }
                    else
                    {
                        LetterCount.Add(i.ToString(), Value);
                    }

                }
                foreach (KeyValuePair<string, int> n in LetterCount)
                {
                    Console.WriteLine(n.Key + ": " + n.Value.ToString());

                }
                Console.ReadKey();
            }

            else
            {
                foreach (char i in text)
                {
                    if (char.IsLetter(i))
                    {
                        int Value = text.Where(x => x == i).Count();

                        if (LetterCount.ContainsKey(i.ToString()))
                        {
                            continue;
                        }
                        else
                        {
                            LetterCount.Add(i.ToString(), Value);
                        }

                    }
                     
                }
                foreach (KeyValuePair<string, int> n in LetterCount)
                {
                    Console.WriteLine(n.Key + ": " + n.Value.ToString());

                }
                Console.ReadKey();
            }
            }
          
        }
   
   
    }

