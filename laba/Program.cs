namespace laba
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace DraftForLab2
    {
        class Program
        {
            static void DoBlock_1()
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    int k = int.Parse(Console.ReadLine());
                    if (k % 2 == 0)
                    {
                        sum += k;
                    }
                }
                Console.WriteLine(sum);
                
            }
            static void DoBlock_2()
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int i = 0;
                while (i < n)
                {
                    i++;
                    int k = int.Parse(Console.ReadLine());
                    if (k % 2 == 0) { sum = sum + k; }
                }
                Console.WriteLine(sum);
            }
            static void DoBlock_3()
            {
                int n = int.Parse(Console.ReadLine());
                int sum = 0;
                int i = 0;
                do
                {
                    i++;
                    int k = int.Parse(Console.ReadLine());
                    if (k % 2 == 0)
                    {
                        sum += k;
                    }
                }
                while (i < n);
                Console.WriteLine(sum);
            }

            static void DoBlock_4()
            {
                int sum = 0;
                int k = 2;
                for (int i = 1; k != 0; i++)
                {
                    k = int.Parse(Console.ReadLine());
                    if ((i % 2) == 1)
                    {
                        sum += k;
                    }                                                        
                }
                Console.WriteLine(sum);
            }
            static void DoBlock_5()
            {                
                int sum = 0;
                int k = 2;
                int i = 0;
                while (k != 0)
                {
                    k = int.Parse(Console.ReadLine());
                    i++;
                    if (i % 2 == 1)
                    {
                        sum = sum + k;
                    }                                      
                }
                Console.WriteLine(sum);
            }
            static void DoBlock_6()
            {
                int sum = 0;
                int k = 0;
                int j = 0;
                do
                {
                    j++;
                    if (j % 2 == 1)
                    {
                        sum = sum + k;
                    }
                    k = int.Parse(Console.ReadLine());
                    
                } while (k != 0);
                Console.WriteLine(sum);
            }
            static void DoBlock_7()
            {
                int n = int.Parse(Console.ReadLine());
                int S = 0;                
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 1)
                    {
                        S = S + i;
                    }
                    else n += 1;
                    
                } 
                Console.WriteLine(S);
            }
            static void DoBlock_8()
            {
                int n = int.Parse(Console.ReadLine());
                int S = 0;
                int i = 0;
                while (i < n)
                {                    
                    if (i % 2 == 1)
                    {
                        S = S + i;
                    }
                    else n += 1;
                    i++;
                }
                Console.WriteLine(S);
            }
            static void DoBlock_9()
            {
                int n = int.Parse(Console.ReadLine());
                int S = 0;
                int i = 0;
                do
                {                    
                    if (i % 2 == 1)
                    {
                        S = S + i;
                    }
                    else n += 1;
                    i++;
                } while (i < n);
                Console.WriteLine(S);
            }
            static void DoBlock_10() 
            {
                int n = int.Parse(Console.ReadLine());
                double S = 0;
                double l = 0;
                n *= 3;
                for (int i = n;i >= 1; i -= 3)
                {
                    if (i == n)
                    {
                        l = Math.Sqrt(i);

                    }
                    else
                    {
                        l = Math.Sqrt(l + i);
                    }
                }
                Console.WriteLine(l);
            }
            static void DoBlock_11()
            {
                int n = int.Parse(Console.ReadLine());
                int x = int.Parse(Console.ReadLine());
                double result = Math.Sin(n * x);
                for (int k = n - 1; k >=1; k--)
                {
                    if ((k + 1) % 3 == 0)
                    {
                        result = Math.Sin(k * x - result);
                    }
                    else 
                    {
                        result = Math.Sin(k * x + result);
                    }
                }
                Console.WriteLine(result);
            }

            static void Main(string[] args)
            {
                int choice;
                do
                {
                    Console.WriteLine("Для виконання блоку 1 (варіант 2 for) введіть 1");
                    Console.WriteLine("Для виконання блоку 2 (варіант 2 while) введіть 2");
                    Console.WriteLine("Для виконання блоку 3 (варіант 2 do...while) введіть 3");
                    Console.WriteLine("Для виконання блоку 3 (варіант 22 for) введіть 4");
                    Console.WriteLine("Для виконання блоку 3 (варіант 22 while) введіть 5");
                    Console.WriteLine("Для виконання блоку 3 (варіант 22 do...while) введіть 6");
                    Console.WriteLine("Для виконання блоку 3 (варіант 36 for) введіть 7");
                    Console.WriteLine("Для виконання блоку 3 (варіант 36 while) введіть 8");
                    Console.WriteLine("Для виконання блоку 3 (варіант 36 do...while) введіть 9");
                    Console.WriteLine("Для виконання блоку 3 (варіант 60) введіть 10");
                    Console.WriteLine("Для виконання блоку 3 (варіант 61) введіть 11");                    
                    Console.WriteLine("Для виходу з програми введіть 0");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Виконую блок 1");
                            DoBlock_1();
                            break;
                        case 2:
                            Console.WriteLine("Виконую блок 2");
                            DoBlock_2();
                            break;
                        case 3:
                            Console.WriteLine("Виконую блок 3");
                            DoBlock_3();
                            break;
                        case 4:
                            Console.WriteLine("Виконую блок 4");
                            DoBlock_4();
                            break;
                        case 5:
                            Console.WriteLine("Виконую блок 5");
                            DoBlock_5();
                            break;
                        case 6:
                            Console.WriteLine("Виконую блок 6");
                            DoBlock_6();
                            break;
                        case 7:
                            Console.WriteLine("Виконую блок 7");
                            DoBlock_7();
                            break;
                        case 8:
                            Console.WriteLine("Виконую блок 8");
                            DoBlock_8();
                            break;
                        case 9:
                            Console.WriteLine("Виконую блок 9");
                            DoBlock_9();
                            break;
                        case 10:
                            Console.WriteLine("Виконую блок 10");
                            DoBlock_10();
                            break;
                        case 11:
                            Console.WriteLine("Виконую блок 11");
                            DoBlock_11();
                            break;                        
                        case 0:
                            Console.WriteLine("Зараз завершимо, тільки натисніть будь ласка ще раз Enter");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Команда ``{0}'' не розпізнана. Зробіть, будь ласка, вибір із 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 0.", choice);
                            break;
                    }
                } while (choice != 0);
            }
        }
    }
}
