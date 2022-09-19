using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //1a
            bool pravda = false;
            byte bit1 = 0;
            sbyte bit2 = -128;
            short number1 = -32768;
            ushort number2 = 65535;
            int number3 = -2147473648;
            uint number4 = 4294967295;
            long number5 = 98765675678678;
            ulong number6 = 1887968567989;
            float number7 = 3.14f;
            double number8 = 4.4322;
            decimal number9 = 23m;
            char symbol = 'a';
            object obekt = "hello world";
            //nint d = 43;
            //nuint gf = 24;

            Console.WriteLine(pravda);
            Console.WriteLine(bit1);
            Console.WriteLine(bit2);
            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            Console.WriteLine(number4);
            Console.WriteLine(number5);
            Console.WriteLine(number6);
            Console.WriteLine(number7);
            Console.WriteLine(number8);
            Console.WriteLine(number9);
            Console.WriteLine(symbol);
            Console.WriteLine(obekt);
            pravda = bool.Parse(Console.ReadLine());
            bit1 = byte.Parse(Console.ReadLine());
            bit2 = sbyte.Parse(Console.ReadLine());
            number1 = short.Parse(Console.ReadLine());
            number2 = ushort.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            number4 = uint.Parse(Console.ReadLine());
            number5 = long.Parse(Console.ReadLine());
            number6 = ulong.Parse(Console.ReadLine());
            number7 = float.Parse(Console.ReadLine());
            number8 = double.Parse(Console.ReadLine());
            number9 = decimal.Parse(Console.ReadLine());
            symbol = char.Parse(Console.ReadLine());
            obekt = (Console.ReadLine());
            Console.WriteLine(

$"boolVar - {pravda}\nbyteVar - {bit1}\nsbyteVar -{bit2}\ncharVar - {number1}\ndecimalVar - {number2}\ndoubleVar - {number3}\nfloatVar - {number4}\nintVar - {number5}\nuintVar - {number6}\nnintVar -{number7}\nnuintVAr - {number8}\nlongVar - {number9}\nulongVar - {symbol}\nshortVar - {obekt}\nushortVar " +
$"");



            //1b
            //неявное
            byte a = 4;
            ushort b = a;
            Console.WriteLine(b);

            int i;
            float f;
            i = 10;
            f = i;
            Console.WriteLine(f);

            int num = 2147483647;
            long bigNum = num;
            Console.WriteLine(bigNum);

            double t = 1234.7;
            int e = (int)t;
            Console.WriteLine(e);

            char o = '5';
            int l = (int)o;
            Console.WriteLine(l);


            //явное
            int x = 4;
            int y = 6;
            byte z = (byte)(x + y);
            Console.WriteLine(z);

            int h = 47;
            int u = 5;
            long k = (long)(h * u);
            Console.WriteLine(k);

            double d = 47;
            double s = 5;
            double r =Convert.ToByte(d / s);
            Console.WriteLine(r);

            int g = 4;
            int j = 6;
            double v = Convert.ToByte(g + j);
            Console.WriteLine(v);

            int n = 343;
            char w = '4';
            object p = (object)(n + w);
            Console.WriteLine(p);
            //convert

            //1c
            //упаковка/распаковка
            int cc = 5;
            object dd = cc;
            int ee = (int)dd;

            float ff = 5.948548f;
            object gg = ff;
            float hh = (float)gg;
            
            //1d
            var ii = 2.68;
            var jj = 3.84;
            var kk = ii + jj;

            //1e
            int? number11 = null;
            int? number1111 = null;
            //int number111 = null;
            Nullable<int> number12 = 5;
            Console.WriteLine($"Сравнение nullable = {number1111 == number11}");

            //1f
            //ошибка должна быть
            var qw = 5;
            qw = 's';
            

            //2a
            string s1 = "hello";
            string s2 = "world";
            int result = string.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 меньше строки s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 больше строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 одинаковые");
            }

            //2b 
            string qq = "the first string";
            string rr = "the second string";
            string ss = "the third string";
            string[] tt;
            Console.WriteLine($"Сцепление строк: {String.Concat(qq, rr)}");
            Console.WriteLine($"Копирование строки: {String.Copy(rr)}");
            Console.WriteLine($"Выделение подстроки: {ss.Substring(9)}");
            Console.WriteLine($"Разделение строки на слова: ");
            tt = qq.Split();
            for (int iii = 0; iii < tt.Length; iii++)
            {
                Console.WriteLine(tt[iii]);
            }
            Console.WriteLine($"Вставка подстроки в заданную позицию: {rr.Insert(4, qq)}");
            Console.WriteLine($"Удаление заданной подстроки: {ss.Remove(4)}");
            
            //2c
            string ae = null;
            string  ar = "";
            bool re = string.IsNullOrEmpty(ae);
            bool yt = string.IsNullOrEmpty(ar);
            Console.WriteLine(re);
            Console.WriteLine(yt);
            Console.WriteLine($"1 строка=2 строка: {ae == ar}");
            Console.WriteLine($"Сцепление: {String.Concat(ae, ar)}");

            //2d переделать
            StringBuilder ww = new StringBuilder("bbcd", 5);
            ww.Append("e");
            ww.Insert(0, "a");
            ww.Remove(2, 1);
            Console.WriteLine($"StringBuilder: {ww}");

            //3a
            int[,] xx = { { 1, 1, 1 }, { 0, 0, 0 }, { 1, 0, 1 } };
            int rows = xx.GetUpperBound(0) + 1;
            int columns = xx.Length / rows;
            for (int rrr = 0; rrr < rows; rrr++)
            {
                for (int ccc = 0; ccc < columns; ccc++)
                {
                    Console.Write($"{xx[rrr, ccc]} \t");
                }
                Console.WriteLine();
            }
            //3b
            string[] zz = { "abc", "def", "ghi" };
            Console.WriteLine($"Длина массива: {zz.Length}");
            foreach (string oooo in zz)
            {
                Console.WriteLine(oooo);
            }
            zz[1] = "ddeeff";
            Console.WriteLine("--------");
            foreach (string oooo in zz)
            {
                Console.WriteLine(oooo);
            }

            //3c
            int[][] jaggedArr1 = new int[3][];
            jaggedArr1[0] = new int[2] { 1, 2 }; 
            jaggedArr1[1] = new int[3] { 3, 4, 5 };
            jaggedArr1[2] = new int[4] { 8, 9, 10, 78};
            //ввод массива из консоли сделать еще

            //3d
            var vals = new[] { 1, 2, 3, 4, 5 };
            foreach (int ooo in vals)
            {
                Console.WriteLine(ooo);
            }
            var stroka = "дарова";
            Console.WriteLine(stroka);

            //4a
            (int, string, char, string, ulong) xxx = (5, "efgh", 'a', "abcd", 12345);
            //4b
            Console.WriteLine(xxx);
            Console.WriteLine(xxx.Item1);
            Console.WriteLine(xxx.Item3);
            Console.WriteLine(xxx.Item5);

            //4c
            (int www, string hhh, char ppp, string ttt, ulong jjj) = xxx;
            Console.WriteLine($"items: {www} {ttt}");
            (int wwwww, _, char hhhh, string pppp, ulong jjjj) = xxx;

            //4d
            var t1 = (A: 5, B: 10);
            var t2 = (B: 5, A: 'd');
            Console.WriteLine(t1 == t2);  
            Console.WriteLine(t1 != t2);
            if (t1 == t2)
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("кортежи не равны");
            }

            //5a
            (int, int, int, char) Localfunction(int[] numbers, string str1)
            {
                int dddd = 0;
                int zzzz = Int32.MaxValue;
                int sum = 0;

                for (int iiii = 0; iiii < numbers.Length; iiii++)
                {
                    if (numbers[iiii] > dddd)
                    {
                        dddd = numbers[iiii];
                    }
                    if (numbers[iiii] < zzzz)
                    {
                        zzzz = numbers[iiii];
                    }
                    sum += numbers[iiii];
                }
                char smb = str1[0];
                var tuple41 = (dddd, zzzz, sum, smb);
                return tuple41;
            }
            int[] nums = new int[4];
            nums[0] = 20;
            nums[1] = 30;
            nums[2] = 40;
            nums[3] = 100;
            string str2 = "abc";
            Console.WriteLine(Localfunction(nums, str2));

            //6
            //byte z2 = 2;
            //byte localfunction1()
            //{
            //    byte z1 = 1;
            //    unchecked
            //    {
            //        z1 = (byte) (z1 - z2);
            //        Console.WriteLine(z1);
            //    }
            //    return z1;
            //}
            //byte localfunction2()
            //{
            //    byte z1 = 1;
            //    checked
            //    {
            //        z1 = (byte)(z1 + z2);
            //        Console.WriteLine(z1);
            //    }
            //    return z1;
            //}
            //Console.WriteLine(localfunction1());
            //Console.WriteLine(localfunction2());

            void FirstFoo()
            {
                try
                {
                    checked
                    {
                        int xd = int.MaxValue;
                        xd++;
                        Console.WriteLine(xd);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            void SecondFoo()
            {
                try
                {
                    unchecked // Не вызывает OverflowException
                    {
                        int xt = int.MaxValue;
                        xt++;
                        Console.WriteLine(xt);
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Произошло переполнение!");
                }
            }

            FirstFoo();
            SecondFoo();
        }



    }
    
}



       
