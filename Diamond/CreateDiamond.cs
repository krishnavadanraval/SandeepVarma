using System;
using System.Text.RegularExpressions;

namespace Diamond
{
    public static class CreateDiamond
    {
        enum ExitCode : int
        {
            Created = 201,
            BadInput = 400,
            Exception = 500,
        }
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if(input == null)
            {
                return;
            }
            else
            {
                DiamondMaking(input);
            }
            
        }
        public static int DiamondMaking(string input)
        {
            try
            {
               char[] letter = new char[26]
               {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
               };
                int letter_number = 0;
                //Create array of strings
                string[] diamond = new string[52];
                char user_letter;

                if (Regex.IsMatch(input, @"^[0-9*#+]+$"))
                {
                    return (int)ExitCode.BadInput;
                }
                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Please enters a Letter: ");
                    user_letter = Console.ReadKey().KeyChar;
                }
                else
                {
                    user_letter = char.Parse(input);
                }
                //Convert all letters in upper
                user_letter = Char.ToUpper(user_letter);
               
                //search for letter number in to the array letter
                for (int i = 0; i < letter.Length; i++)
                {
                    if (letter[i] == user_letter)
                    {
                        letter_number = i;
                        break;
                    }
                }

                //Create diamond from letters

                for (int i = 0; i <= letter_number; i++)
                {
                    //add initial spaces to create diamond
                    for (int j = 0; j < letter_number - i; j++)
                    {
                        diamond[i] += " ";
                    }

                    //add letter first time
                    diamond[i] += " " + letter[i];

                    //add space between letters
                    if (letter[i] != 'A')
                    {
                        for (int j = 0; j < 2 * i - 1; j++)
                        {
                            diamond[i] += " ";
                        }
                        //add letter second time
                        diamond[i] += letter[i];
                    }
                    // Draw the first part of the diamond.
                    Console.WriteLine(diamond[i]);
                }

                for (int i = letter_number - 1; i >= 0; i--)
                {
                    // Draw the second part of the diamond
                    // Writing the diamondArray in reverse order.
                    Console.WriteLine(diamond[i]);

                }
                return (int)ExitCode.Created;
                // Mark a pause
                //Console.ReadKey();
            }
            catch(Exception ex)
            {
                return (int)ExitCode.Exception;
            }
        }
            

    }
    
}
