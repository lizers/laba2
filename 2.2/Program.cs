using System;
using System.Collections.Generic;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;
            Console.WriteLine(check ? "Checked" : "Checked");  // output: Checked



            sbyte sb = 102;//От -128 до 127
            long l = -10;//-9,223,372,036,854,775,808 до 9,223,372,036,854,775,807
            byte b = 1;//От 0 до 255
            short sh = 1;//От -32 768 до 32 767
            int i = 42;//От -2 147 483 648 до 2 147 483 647
            int ib = 0b101;
            uint ui = 102;//От 0 до 4 294 967 295
            ulong ul = 10;//От 0 до 18 446 744 073 709 551 615
            Console.WriteLine($"sb: {sb} l: {l} b: { b} sh: { sh}  ib: { ib} i: { i} ui: { ui} ul: { ul}");
            var chars = new[]//От U + 0000 до U + FFFF
             {
                   'j',
                   '\u006A',
                   '\x006A',
                 };
            Console.WriteLine(string.Join(" ", chars));
            double a = 12.3;//От ± 5,0 × 10 −324 до ± 1,7 × 10 308
            decimal d = 2.1m;//От ± 1,0 x 10 -28 до ± 7,9 228 x 10 28
            float f = 30.6f;//От ± 1,5 x 10 -45 до ± 3,4 x 10 38
            Console.WriteLine($"double: {a} decimal: {d} float: { f}");
            string s1 = "hello";
            string s2 = "h";
            // Append to contents of 'b'
            s2 += "ello";
            Console.WriteLine(s1 == s2);
            Console.WriteLine(object.ReferenceEquals(s1, s2));
            dynamic dyn = 1;
            Console.WriteLine($"явное преобразование");
            double x = 1234.7;
            int i2;
            i2 = (int)x;
            int i3 = 655;
            ulong c = (ulong)(i3);
            byte bt = 10;
            sbyte sbt = (sbyte)bt;
            int m = (int)c;
            System.Console.WriteLine($"{i2} {c} {sbt} {m}");
            Console.WriteLine($"неявное преобразование");
            int num = 2147483647;
            long bigNum = num;
            byte a2 = 4;             // 0000100
            ushort b2 = a2;   // 000000000000100
            long l2 = 20;
            float fl = l2;
            System.Console.WriteLine($"{num} {b2} {l2} ");
            Console.WriteLine($"упаковка и распаковка");
            int price = 39;
            Object obj2 = price;
            int price2 = (int)obj2;
            System.Console.WriteLine($"{obj2} {price2} ");
            Console.WriteLine($"работа с неявно типизированными переменными");
            var e1 = 4.0;
            var e2 = 5.0;
            var hypot = Math.Sqrt((e1 * e2) + (e1 * 22));
            Console.Write("Гипотенуза треугольника со сторонами " + e1 + " by " + e2 + " равна ");
            Console.WriteLine(hypot);
            Nullable<bool> enabled2 = null;
            Object nn = null;
            int? nl = null;
            /*Стандартный пример - работа с базой данных,
            которая может содержать значения null.
            И мы можем заранее не знать,
            что мы получим из базы данных \
            - какое-то определенное значение или же null. */
            var number = 5;
            // number = "some text"; // ошибка, number определен как int
            /*var сохраняет принцип строгой типизации в Си-шарп. 
             * Это означает, что после того, как для переменной уже
             * был определен тип, в нее нельзя записать данные
             * другого типа:*/
            var h1 = "abc" == "abc"; //true
            var h2 = "bcd" != "Bcd"; //true
            var h3 = "x".Equals("c"); //false

            String str1 = "first string";
            String str2 = "second string";
            String str3 = "third string";

            str1 = String.Concat(str1, str2);
            Console.WriteLine(str1);
            str1 = String.Copy(str2);
            Console.WriteLine(str1);
            str1 = str1.Substring(3, 5);
            Console.WriteLine(str1);
            String[] splitStr = str3.Split(' ');
            foreach (String str in splitStr) ;
            str3 = str3.Insert(5, " ----");
            Console.WriteLine(str3);
            str3 = str3.Remove(5, 5);
            Console.WriteLine(str3);
            String str0 = "строк";
            Console.WriteLine($"Интерполирование {str0}");
            String testString1 = " ";
            String testString2 = null;
            Console.WriteLine("' '   IsNullOrEmpty - " + String.IsNullOrEmpty(testString1));
            Console.WriteLine("null  IsNullOrEmpty - " + String.IsNullOrEmpty(testString2));

            Console.WriteLine("' '   IsNullOrWhiteSpace - " + String.IsNullOrWhiteSpace(testString1));
            Console.WriteLine("null  IsNullOrWhiteSpace - " + String.IsNullOrWhiteSpace(testString2));

            System.Text.StringBuilder string1 = new System.Text.StringBuilder("Строка на основе StringBuilder");
            string1.Remove(0, 3);
            string1.Remove(22, 5);
            Console.WriteLine(string1);
            string1.Insert(0, "AAA");
            string1.Insert(25, "AAA");
            Console.WriteLine(string1);

            Console.WriteLine($"массивы");
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int rows = mas.GetUpperBound(0) + 1;//с помощью выражения mas.GetUpperBound(0) + 1 можно получить количество строк таблицы, представленной двухмерным массивом. 
            int columns = mas.Length / rows;// через mas.Length / rows можно получить количество элементов в каждой строке:
                                            // или так
                                            // int columns = mas.GetUpperBound(1) + 1;

            for (int q = 0; q < rows; q++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[q, j]} \t");
                }
                Console.WriteLine();
            }
            String[] mas2 = { "abc", "def", "gij" };
            foreach (string g in mas2)
                Console.Write($"{g} ");
            Console.WriteLine("\nДлина массива - {0}", mas2.Length);
            Console.WriteLine("Номер изменяемого элемента: ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Новый элемент: ");
            String newContent = Console.ReadLine();
            mas2[index - 1] = newContent;
            Console.WriteLine("Новый массив: ");
            foreach (String newstr in mas2)
            {
                Console.WriteLine(newstr);
            }

            // Объявляем ступенчатый массив
            int[][] arrC = new int[3][];
            arrC[0] = new int[2];
            arrC[1] = new int[3];
            arrC[2] = new int[4];

            for (int i4 = 0; i4 < 3; i4++)
            {
                int j = 0;
                foreach (int tmp in arrC[i4])
                {
                    arrC[i][j] = Convert.ToInt32(Console.ReadLine());
                    j++;
                }
            }
            for (int i4 = 0; i4 < 3; i4++)
            {
                int j = 0;
                foreach (int tmp in arrC[i4])
                {
                    Console.Write("  " + arrC[i4][j]);
                    j++;
                }
                Console.WriteLine();
            }


            var array = new object[0];
            var str5 = "";

            Console.WriteLine($"кортежи");

            {
                (int, string, char, string, ulong) TupleA = (1, "ab", 'c', "dfj", 23);
                Console.WriteLine(TupleA);
                Console.WriteLine(TupleA.Item1);
                Console.WriteLine(TupleA.Item3);
                Console.WriteLine(TupleA.Item4);

                var (first, _, _, fourth, fifth) = TupleA;

                var firstTuple = Tuple.Create(9, 3);
                var secondTuple = Tuple.Create(9, 3);
                var ec = EqualityComparer<Tuple<int, int>>.Default;

                if (ec.Equals(firstTuple, secondTuple))
                    Console.WriteLine("Первый кортеж равен второму");
                else
                    Console.WriteLine("Первый кортеж не равен второму");

                Console.WriteLine(new TupleComparer().Compare(firstTuple, secondTuple));

            }
            void chec()
            {
                checked
                {
                    int A = 2147483647;
                    A++;
                    Console.WriteLine(A);
                }
            }
            void unhcec()
            {
                unchecked
                {
                    int A = 2147483647;
                    A++;
                    Console.WriteLine(A);
                }
            }
        }

        //public static void Main()
        //    {
        //        (int, int, int, char) FifthTask(int[] arrA, string strA)
        //        {
        //            int max, min, sum = 0;
        //            min = max = arrA[0];
        //            foreach (int i in arrA)
        //            {
        //                if (i < min)
        //                {
        //                    min = i;
        //                }
        //            }
        //            foreach (int i in arrA)
        //            {
        //                if (i > max)
        //                {
        //                    max = i;
        //                }
        //            }
        //            foreach (int i in arrA)
        //            {
        //                sum += i;
        //            }
        //            (int, int, int, char) TupleB = (min, max, sum, strA[0]);
        //            return TupleB;
        //        }
        //    }

    }
}






