using System;

namespace _0610Study
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("値を入力してください：");
                int num =Int32.Parse(Console.ReadLine());

                if (num > 0 && num <= 100)
                {
                    for (int count = 1; count <= num; count++)
                    {
                        if (count % 3 == 0 && count % 5 == 0)
                        {
                            Console.WriteLine("Fizz Buzz");
                        }
                        else if (count % 3 == 0)
                        {
                            Console.WriteLine("Fizz");
                        }
                        else if (count % 5 == 0)
                        {
                            Console.WriteLine("Buzz");
                        }
                        else
                        {
                            Console.WriteLine(count);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
            }catch(Exception)
            {
                Console.WriteLine("値が不正です。数字を入力してください");
            }
            
            
            
        }
    }
}
