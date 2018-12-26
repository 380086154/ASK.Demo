using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASK.Demo.Console1
{
    class Program
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("输入学员姓名和成绩，姓名和成绩用中文逗号分隔");

                var key = Console.ReadLine();
                if (key == "exit") break;
                
                var studentInfo = key.Split('，');
                if (studentInfo.Length < 2) continue;

                float.TryParse(studentInfo[1], out var score);

                var student = new Student
                {
                    Name = studentInfo[0],
                    Score = score,
                };

                studentList.Add(student); 
            }

            QueryTop();
        }

        static List<Student> studentList = new List<Student>();

        public static void QueryTop()
        {
            var list = studentList.OrderByDescending(x => x.Score).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 2) break;
                var item = list[i];

                Console.Write($"第{i + 1}名");
                Console.Write($" {item.Name}, {item.Score}");

                Console.WriteLine();
            }

            Console.WriteLine("按任意键退出...");
            Console.ReadKey();
        }
    }

    /// <summary>
    /// 学员
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 成绩
        /// </summary>
        public float Score { get; set; }
    }
}
