using System;
using ClassLibrary;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.accessorSample();
        }

        /// <summary>
        /// Accessor範例 : name的存取範圍設成唯讀,只有建構子可以設定
        /// </summary>
        void accessorSample()
        {
            Student stu = new Student("Harry Yao");
            Console.WriteLine("set stu name is {0}" , stu.Name);
            //stu.name = "Harry Yao";
            // You can't change Name
            stu.Name = "Harry Yao2";
            Console.WriteLine("You can't change the Name ,  still {0} ", stu.Name);
            Console.Read();
        }

        void relationSample()
        {
            
        }

    }
}
