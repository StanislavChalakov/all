using System;

class TwoPositiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter one positive number:");
        int firstNum = int.Parse(Console.ReadLine());

        if (firstNum > 0)
        {
            Console.WriteLine("Please enter second positive number:");
            int secondNum = int.Parse(Console.ReadLine());

            if (secondNum > 0)
            {
                if (firstNum < secondNum)
                {
                    int p = 0;
                    for (int i = firstNum; i <= secondNum; i++)
                    {
                        if (i % 5 == 0)
                        {
                            p++;
                        }
                    }
                    Console.WriteLine("There are {0} numbers in p({1},{2}) divided by 5", p, firstNum, secondNum);
                }
                else
                {
                    int p = 0;
                    for (int i = secondNum; i <= firstNum; i++)
                    {
                        if (i % 5 == 0)
                        {
                            p++;
                        }
                    }
                    Console.WriteLine("There are {0} numbers in p({1},{2}) divided by 5", p, secondNum, firstNum);
                }
            }
            else
            {
                Console.WriteLine("The number you entered isnt positive.");
            }
        }
        else
        {
            Console.WriteLine("The number you entered isnt positive.");
        }
    }
}

