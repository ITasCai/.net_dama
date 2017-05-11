using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._07练习
{
    class Program
    {
        private static object n;

        static void Main(string[] args)
        {

            #region 两个数进行交换

            //int a = 20;
            //int b = 30;
            //int temp=0;

            //temp = a;
            // a = b;
            //b = temp;

            // Console.WriteLine("a={0},b={1}",a,b);

            //Console.WriteLine("----------------------");

            //a = a + b;
            //b = a - b;
            //a = a - b;

            //Console.WriteLine("a={0},b={1}", a, b);

            //Console.ReadKey();
            #endregion


            #region 交换两个变量，封装成方法

            //int a=10, b=20;
            //jiaohuan(ref a,ref b);
            //Console.WriteLine("a={0},b={1}",a,b);
            //Console.ReadKey();

            #endregion

            #region  通过编程计算1+2-3+4-5.....100的值

            //int sum = 0;
            //for (int i = 1; i <= 100; i++) {
            //    if (i == 1 || i % 2 == 0)
            //    {
            //        sum += i;
            //    }
            //    else {
            //        sum -= i; 
            //    }

            //}
            //Console.WriteLine(sum);
            //Console.ReadKey();

            #endregion


            #region   素数练习
            //while (true)
            //{
            //    Console.WriteLine("请输入一个数");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    bool pd = getpan(num);
            //    Console.WriteLine(pd);
            //    Console.ReadKey();
            //}





            #endregion


            #region  找出最大数字

            //int max = getarrmax(20, 80, 999, 22, 35, 74);
            //Console.WriteLine(max);
            //Console.ReadLine();
            #endregion


            #region   计算1-100的素数之和
            //int sum = 0;
            //for (int i = 2; i <= 100; i++)
            //{
            //    if (getpan(i))
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();

            #endregion


            #region   输出个数最多的那个字符串
            //string[] mname = new string[] { "东方今典", "三大", " 数据费电话呢", "四" };
            //string maxlength = getlength(mname);
            //Console.WriteLine(maxlength);
            //Console.ReadLine();


            #endregion


            #region   求数组里数字的平均值

            //int[] arravg = {20,53,78,96,33,54,77 };
            //double avg = getarravg(arravg);
            //Console.WriteLine(avg);
            //Console.ReadLine();


            #endregion

            #region   冒泡排序，升序

            //int[] arr = { 20,28,99,15,2,8,158,47,65};
            //getmaopao(arr);
            //for (int i = 0; i < arr.Length-1; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            //Console.ReadLine();
            #endregion

            #region  十进制转换为二进制

            //Console.WriteLine("输入一个整数");
            //int num = Convert.ToInt32(Console.ReadLine());
            //string  er= getzhuanhuan(num);
            //Console.WriteLine(er);
            //Console.ReadLine();

            #endregion

            #region   九九乘法表

            //for (int i = 1; i <=9; i++)
            //{
            //    for (int j = 1; i >= j; j++)
            //    {
            //        Console.Write("{0}X{1}={2}\t",j,i,i*j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            #endregion


            #region  写一个去空格的方法

            string s = "            到处一游！          ";
            string s2 = getqu(s);
            Console.WriteLine(s2);
            Console.ReadLine();


            #endregion



        }

        //自定义去空格
        private static string getqu(string s)
        {   
            //定义字符串的第一个字符的索引
            int srt = 0;
            //定义字符串最后一个字符的索引
            int end = s.Length - 1;
            //如果字符串的第一个字符的索引小于字符串的长度，往下执行
            while (srt<s.Length)
            {   
                //如果字符串中没有空白字符，往下执行
                if (!char.IsWhiteSpace(s[srt]))
                {   
                    //跳出判断
                    break;
                }
                //从左边数最后一个不是空白符的索引
                srt++;

            }
            //如果字符串的最后一个字符的索引大于前面空白字符的长度，往下执行
            while (end>=srt)
            {
                //如果字符串中没有空白字符，往下执行
                if (!char.IsWhiteSpace(s[end]))
                {
                    //跳出判断
                    break;
                }
                //右边数最后一个不是空白符的索引
                end--;
            }
            //把没有空白字符串截取
            return s.Substring(srt,end-srt+1);
        }

        //十进制转换为二进制
        private static string getzhuanhuan(int num)
        {
            List<string> list = new List<string>();
            while (num>=2)
            {
                int shang = num / 2;
                int yu = num % 2;
                list.Add(yu.ToString());
                num = shang;
            }
            list.Add(num.ToString());
            list.Reverse();
            return string.Join("",list.ToArray());

        }

        //冒泡排序
        private static void getmaopao(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++) {
                for (int j = arr.Length - 1; j > i; j--) {
                    if (arr[j] < arr[j - 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j -1];
                        arr[j -1] = temp; 
                      }
                    {

                    }
                }
             }
        }

        //求数组的平均值
        private static double getarravg(int[] arravg)
        {
            int sum = 0;
            for(int i=0;i<arravg.Length;i++) {
                sum += arravg[i];

            }
            return  Math.Round (sum * 1.0 / arravg.Length,2);
        }

        //数组的判断
        private static string getlength(string[] arr)
        {
            string maxname = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (maxname.Length < arr[i].Length) {
                    maxname = arr[i];
                }
            }
            return maxname;

        }




        //最大值
        private static int getarrmax(params int[]arr)
        {
            int max =arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max <arr[i]) {
                    max = arr[i];
                }
            }
            return max;
        }

        //素数
        private static bool getpan(int n)
        {
            if (n > 1)
            {
               
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                throw new Exception("数字小于1不是质数！");
            }
        }


        //两个数交换
        private static void jiaohuan(ref int a,ref int b)
        {
            int temp;
            temp = a;
            a = b;
            b = temp; 
        }
    }
}
