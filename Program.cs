using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3Ora1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sum();
            //ex2();
            //ex3Iterativ();
            //FactorialRecursiv();
            //Duplicate();
            //SumOfDigits();
            //sum_of_digit();
            //Majority();
            //Anagrama();
            //ArmstrongNumber();
            //PrimeNumber();
            // ReverseList();
            //SelectionSort();
            //BubbleSortArray();
            //BitsCount();
            // Fibonacci();
            //Anagram();
            Pivot();
            Console.ReadLine();
        }

        private static void Sum()
        {
            int sum = 0;
            int[] arr = new Int32[] { 2, 4, 5, 6 };
            foreach (var numbet in arr)
            {
                if (numbet % 2 == 0)
                {
                    sum += numbet;
                }
                Console.WriteLine(sum);
                Console.ReadLine();
            }
        }

        private static void ex2()
        {
            Console.WriteLine("Introduceti un numar : ");
            int numar = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            int[] sir = new int[] { 4, 6, 7, 8, 9, 1, 2, 3 };
            for (int i = 0; i < sir.Length; i++)
            {
                for (int j = i + 1; j < sir.Length; j++)
                {
                    if (sir[i] + sir[j] == numar)
                        Console.WriteLine("Perechi : " + sir[i] + " " + sir[j]);

                }
            }
        }

        private static void ex3Iterativ()
        {
            int numar, factorial;
            Console.WriteLine("Introduceti un numar :");
            numar = Convert.ToInt32(Console.ReadLine());
            factorial = numar;
            for (int i = numar - 1; i >= 1; i--)
            {
                factorial = factorial * i;

            }
            Console.WriteLine("Factorialul numarului dat este : " + factorial);
            Console.ReadLine();
        }

        private static int FactorialRecursiv(int nr)
        {
            if (nr == 1)
            {
                return 1;
            }

            return nr * FactorialRecursiv(nr - 1);
        }

        private static bool Duplicate()
        {
            int[] sir = new int[] { 1, 2, 3, 4, 5, 3, 5 };

            for (int i = 0; i < sir.Length; i++)
            {
                for (int j = i + 1; j < sir.Length; j++)
                {
                    if (sir[i] == sir[j])
                    {
                        return true;
                    }



                }


            }
            return false;



        }

        private static void SumOfDigits()
        {
            int numar, sum = 0;
            Console.WriteLine("Insert number :");
            numar = Convert.ToInt32(Console.ReadLine());
            while (numar % 10 != 0)
            {
                sum = sum + (numar % 10);
                numar = numar / 10;
            }
            Console.WriteLine("Sum of Digits is " + sum);
        }

        //private static int sum_of_digit(int n)
        //{
        //    if (n == 0)
        //        return 0;

        //    return (n % 10 + sum_of_digit(n / 10));
        //}

        private static void Majority()
        {
            int[] sir = new int[] { 5, 3, 2, 5, 5, 5, 5, 2, 4, 8 };

            int numar, contor;
            numar = contor = 0;
            for (int i = 0; i < sir.Length; i++)
            {
                for (int j = i; j < sir.Length; j++)
                {
                    if (sir[i] == sir[j])
                    {
                        contor++;
                    }
                }
                if (contor >= sir.Length / 2)
                {

                    numar = sir[i];

                }
                contor = 0;
            }
            Console.WriteLine("Numarul " + numar + " este majoritar");
        }

        //private static bool Anagrama()
        //{
        //    var dict = new Dictionary<char, int>();
        //    dict.Add('x', 10);
        //    if (dict.Keys.Contains('x'))
        //    {

        //    }
        //}
        private static bool ArmstrongNumber()
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter number : ");
            n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Your number (" + temp + ") is an Armstrong number");
            else
                Console.WriteLine("Your number (" + temp + ") is not an Armstrong number");
            return false;
        }

        private static void PrimeNumber()
        {
            Console.Write("Introduceti un numar pentru a verifica daca este prim : ");

            int n = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    a++;
                }
            }

            if (a == 2)
            {
                Console.WriteLine(n + " este un numar prim.", n);
            }
            else
            {
                Console.WriteLine(n + " Nu este un numar prim.");
            }
            Console.ReadLine();
        }

        private static void SelectionSort()
        {
            int[] arr = new int[8] { 55, 76, 102, 32, 15, 9, 69, 115 };
            int n = 8;
            Console.WriteLine("The initial array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            int temporar, minim;
            for (int i = 0; i < n - 1; i++)
            {
                minim = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minim])
                    {
                        minim = j;
                    }
                }
                temporar = arr[minim];
                arr[minim] = arr[i];
                arr[i] = temporar;
            }
            Console.WriteLine();
            Console.WriteLine("The sorted array is: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }


        }

        private static void BubbleSortArray()
        {
            int[] arr = new int[7] { 56, 88, 901, 45, 67, 32, 55 };
            Console.WriteLine("The initial array is : 56, 88, 901, 45, 67, 32, 55 ");

            int temporar = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temporar = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temporar;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine("The sorted array is : " + arr[i]);

            Console.ReadLine();

        }
        public static int BitsCount(int n)
        {

            int contor = 0;
            while (n > 0)
            {
                contor = contor + (n & 1);
                n >>= 1;
            }
            return contor;
        }
        public static void BitsCount()
        {
            int i = 123;
            Console.Write(BitsCount(i));
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }


        private static void Fibonacci()
        {
            Console.WriteLine("Enter Fibonacci number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The " + n + "th" + " Fibonacci number is : " + Fibonacci(n));
        }

        private static void Anagram()
        {
            Console.WriteLine("Input first word/string : ");
            string sir1 = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Input second word/string : ");
            string sir2 = Convert.ToString(Console.ReadLine());



            sir1 = sir1.ToLower();
            sir2 = sir2.ToLower();


            if (sir1.Length != sir2.Length)
            {
                Console.WriteLine("Strings are not anagram");
            }

            else
            {

                char[] string1 = sir1.ToCharArray();
                char[] string2 = sir2.ToCharArray();

                Array.Sort(string1);
                Array.Sort(string2);


                if ((string1.ToString()) == (string2.ToString()))
                {
                    Console.WriteLine("Strings are anagram");
                }
                else
                {
                    Console.WriteLine("Both the strings are not anagram");
                }
            }
        }
        public static void Pivot()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Original array is : [1, 2, 3, 4, 5, 6, 7, 8]");
            var temporary = numbers[0];
            for (var i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = temporary;
            Console.WriteLine("Rotated array becomes: [{0}]", string.Join(", ", numbers));

        }

    }
    
}
