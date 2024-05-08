using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "Lorem ###ipsum ######dolor#### Pit ###am##et ##consectetu##########r #adipis######cing### #elit.#### Sed ####malesuada ###########faucibus #########ex ###vec ###. ##Donec ######m#attis #####egestas ########nisi #####non ####pretium. #########Suspendisse ############nec ####eros #####ut ###erat #####faci####lisis#### maximus. #########In ###congue #######et ###Leo# #in ###varius. ########Vestibulum ###########sit ####amet #####felis ######ornare, ########commodo###### #orci #####ut, ####feugiat ########lorem.#####erc!\r\n";
        Console.WriteLine(ProcessString(input));
    }

    static string ProcessString(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in input)
        {
            if (c == '#')
            {
                if (stack.Count > 0)
                {
                    stack.Pop();
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        char[] result = stack.ToArray();
        Array.Reverse(result);
        return new string(result);
    }
}
