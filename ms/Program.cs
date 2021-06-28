using System;

namespace ms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите: 1 - одномерный массив, 2 - двухмерный массив, 3 - для многомерного массива");
            string selection = Console.ReadLine();



            switch (selection)
            {
                case "1":
                    Console.WriteLine("Пример одномерного массива");
                     int[] myArr = new int[6]; // обьявляем одномерный массив

                    myArr[0] = 1;
                    myArr[1] = 2;
                    myArr[2] = 3;
                    myArr[3] = 4;
                    myArr[4] = 5;
                    myArr[5] = 6;

                    foreach (int r in myArr)
                        Console.WriteLine(r);
                    
                    break;

                case "2":
                    Console.WriteLine("Пример двухмерного массива");
                    
                    int[,] myArrh = new int[4, 5];
                    Random ran = new Random();

                    for (int i = 0; i < 4; i++)
                        for (int j = 0; j < 5; j++)
                        {
                            myArrh[i, j] = ran.Next(1, 15);
                            Console.Write("{0}\t", myArrh[i, j]);
                        }
                    Console.WriteLine();
                    break;

                case "3":
                    Console.Write("Столбцов: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Строк: ");
                    int y = int.Parse(Console.ReadLine());
                    int[,] mas = new int[x, y];
                    Console.WriteLine();

                    Console.WriteLine("Заполни матрицу");

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write("mas[" + i + "," + j + "]: ");
                            mas[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                    Console.WriteLine();

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            Console.Write(" mas[" + i + "," + j + "]: " + mas[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }
                    break;


                default:
                    Console.WriteLine("default");
                    break;
            }
            Console.ReadKey();

        }
    }
}

