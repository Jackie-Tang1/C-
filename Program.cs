using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 基础练习
{
    /// <summary>
    /// 成绩等级
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请输入成绩");
                int grade = 0;
                bool isNumber = true;
                try
                {
                    grade = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("请输入数字");
                    isNumber = false;
                }
                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine("输入成绩错误！退出");
                    break;
                }
                if (isNumber)
                {
                    Console.WriteLine("您的成绩等级是：" + getLevel(grade));
                }
            }
            Console.ReadKey();
        }

        public static string getLevel(int grade)
        {
            int temp = grade / 10;
            string level="";
            switch (temp)
            {
                case 10:
                case 9: level = "优"; break;
                case 8: level = "良"; break;
                case 7: level = "中"; break;
                case 6: level = "差"; break;
                default:level = "不及格"; break;

            }
            return level;
        }
    }
}
