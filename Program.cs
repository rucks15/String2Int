using System.Reflection.Metadata.Ecma335;

namespace String2Int
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.WriteLine("String 2 Integer!!!");

            int option = 0;

            while (option != 2)
                {
                Console.WriteLine("1. Enter a value 2. Exit");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                    {
                    var sign = '+';
                    int count = 0;
                    double output = 0;
                    bool is_invalid = false;
                    Console.WriteLine("\n Enter the string:");
                    var input = Console.ReadLine();

                    if (input == "" || input.Length == 0)
                        {
                        Console.WriteLine("The given empty string is invalid, give an Integer as an input!");
                        }
                    else
                        {
                        /*
                        for (int ch = 0; ch < input.Length; ch++)
                            {
                            while (input[ch] == ' ' && ch+1 < input.Length)
                                ch++;
                            if (input[ch] >= 48 && input[ch] <= 57)
                                {
                                output = (output * 10) + (input[ch] - 48);
                                count++;
                                }
                            if (input[ch] == '-')
                                sign = input[ch];
                            }
                        */
                        for (int ch = 0; ch < input.Length; ch++)
                            {
                            if (count == 0)
                                {
                                if (input[ch] == '-' || input[ch] == '+')
                                    sign = input[ch];

                                while (input[ch] == ' ' && ch+1 < input.Length)
                                    {
                                    ch++;
                                    }

                                }
                            
                            if (input[ch] >= 48 && input[ch] <= 57)
                                {
                                output = (output * 10) + (input[ch] - 48);
                                count++;
                                }
                            else
                                {
                                if(count > 0)
                                    {
                                    if (input[ch] == '.')
                                        {
                                        int divisor = 10;
                                        ch++;
                                        while (ch < input.Length)
                                            {
                                            if (input[ch] >= 48 && input[ch] <= 57)
                                                {
                                                double temp = (double)(input[ch] - 48) / divisor;
                                                output = output + temp;
                                                divisor *= 10;
                                                ch++;
                                                }
                                            else
                                                {
                                                is_invalid = true;
                                                break;
                                                }
                                            }
                                        }
                                    else
                                        {
                                        is_invalid = true;
                                        break;
                                        }
                                    }
                                
                                }
                                
                            }
                        }
                    if (sign == '-')
                        {
                        output = 0 - output;
                        
                        }
                    if (count > 0 && !is_invalid)
                        Console.WriteLine("Here is the integer:{0}", output.ToString());
                    else
                        Console.WriteLine("The given string has no integer value!");
                    }

                }
            Console.WriteLine("Program exiting..!");

            }

        }
    }