using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yizhong
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Console.Write("请输入要生成的题数：");
            int n = Convert.ToInt32(Console.ReadLine());
            int m;
            int[] e = new int[n];
            Console.Write("请输入要生成的运算题的不得大于此数的数：");
            m = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
            b:
                int a = ran.Next(1, m);
                int b = ran.Next(1, m);
                int c = ran.Next(1, m);
                int d = ran.Next(1, m);
                if (i % 18 == 1 || i == 1)
                {
                    Console.WriteLine("{0}: {1}+{2}=？", i, a, b);
                    e[i - 1] = a + b;
                }
                else if (i % 18 == 2 || i == 2)
                {
                    if (a < b)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}=？", i, a, b);
                    e[i - 1] = a - b;
                }
                else if (i % 18 == 3 || i == 3)
                {
                    Console.WriteLine("{0}: {1}*{2}=？", i, a, b);
                    e[i - 1] = a * b;
                }
                else if (i % 18 == 4 || i == 4)
                {
                    if (a % b != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}/{2}=？", i, a, b);
                    e[i - 1] = a / b;
                }
                else if (i % 18 == 5 || i == 5)
                {
                    if (a + b < c)
                        goto b;
                    Console.WriteLine("{0}: {1}+{2}-{3}=？", i, a, b, c);
                    e[i - 1] = a + b - c;
                }
                else if (i % 18 == 6 || i == 6)
                {
                    Console.WriteLine("{0}: {1}+{2}*{3}=？", i, a, b, c);
                    e[i - 1] = a + b * c;
                }
                else if (i % 18 == 7 || i == 7)
                {
                    if (b % c != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}+{2}/{3}=？", i, a, b, c);
                    e[i - 1] = a + b / c;
                }
                else if (i % 18 == 8 || i == 8)
                {
                    if (a < b * c)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}*{3}=？", i, a, b, c);
                    e[i - 1] = a - b * c;
                }
                else if (i % 18 == 9 || i == 9)
                {
                    if (b % c != 0 || a < c / b)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}/{3}=？", i, a, b, c);
                    e[i - 1] = a - b / c;
                }
                else if (i % 18 == 10 || i == 10)
                {
                    if (a * b % c != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}*{2}/{3}=？", i, a, b, c);
                    e[i - 1] = a * b / c;
                }
                else if (i % 18 == 11 || i == 11)
                {
                    if (b < c * d)
                        goto b;
                    Console.WriteLine("{0}: {1}+{2}-{3}*{4}=？", i, a, b, c, d);
                    e[i - 1] = a + b - c * d;
                }
                else if (i % 18 == 12 || i == 12)
                {
                    if (b < c / d || c % d != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}+{2}-{3}/{4}=？", i, a, b, c, d);
                    e[i - 1] = a + b - c / d;
                }
                else if (i % 18 == 13 || i == 13)
                {
                    if (b * c % d != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}+{2}*{3}/{4}=？", i, a, b, c, d);
                    e[i - 1] = a + b * c / d;
                }
                else if (i % 18 == 14 || i == 14)
                {
                    if (a < b * c / d || b * c % d != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}*{3}/{4}=？", i, a, b, c, d);
                    e[i - 1] = a - b * c / d;
                }
                else if (i % 18 == 15 || i == 15)
                {
                    if (a < b)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}+{3}*{4}=？", i, a, b, c, d);
                    e[i - 1] = a - b + c * d;
                }
                else if (i % 18 == 16 || i == 16)
                {
                    if (a < b || c % d != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}+{3}/{4}=？", i, a, b, c, d);
                    e[i - 1] = a - b + c / d;
                }
                else if (i % 18 == 17 || i == 17)
                {
                    if (b % c != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}+{2}/{3}*{4}=？", i, a, b, c, d);
                    e[i - 1] = a + b / c * d;
                }
                else if (i % 18 == 0 || i == 18)
                {
                    if (a < b / c * d || b % c != 0)
                        goto b;
                    Console.WriteLine("{0}: {1}-{2}/{3}*{4}=？", i, a, b, c, d);
                    e[i - 1] = a - b / c * d;
                }
            }
            Console.WriteLine("请输入答案：");
            int[] g = new int[n];
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0}:", i);
                g[i - 1] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("显示答案请按Enter！");
            Console.Read();
            Console.Clear();
            Console.WriteLine("我的答案：");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}:{1}", i, g[i - 1]);
            }
            Console.WriteLine("正确答案：");
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}:{1}", i, e[i - 1]);
            }
            int[] t = new int[n];
            int[] y = new int[n];
            int p = 0, j = 0, j1 = 0;
            for (int i = 0; i < n; i++)
            {
                if (e[i] == g[i])
                {
                    t[j] = i + 1;
                    j++;
                    p++;
                }
                else
                {
                    y[j1] = i + 1;
                    j1++;
                }
            }
            Console.Write("Correct: {0} (", p);
            if (p == 0)
                Console.WriteLine(")");
            else
            {
                Console.Write("" + t[0]);
                for (int i = 1; i < j; i++)
                {
                    Console.Write("," + t[i]);
                }
                Console.WriteLine(")");
            }
            Console.Write("Wrong: {0} (", n - p);
            if (p == n)
            {
                Console.WriteLine(")");
            }
            else
            {
                Console.Write("" + y[0]);
                for (int i = 1; i < j1; i++)
                {
                    Console.Write("," + y[i]);
                }
                Console.WriteLine(")");
            }
            System.Diagnostics.Debugger.Break();
        }
    }
}
