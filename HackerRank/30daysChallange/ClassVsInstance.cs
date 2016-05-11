using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank._30daysChallange
{
    class ClassVsInstance : HackerRank
    {
        public void run(StreamReader Console)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = 0; i < T; i++)
            {
                int age = int.Parse(Console.ReadLine());
                Person p = new Person(age);
                p.amIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.yearPasses();
                }
                p.amIOld();
                System.Console.WriteLine();
            }
        }
    }

    class Person {
        int age;

        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                this.age = 0;
                System.Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else {
                this.age = initialAge;
            }
        }

        public void yearPasses() {
            this.age++;
        }

        public void amIOld() {
            if (this.age < 13)
            {
                System.Console.WriteLine("You are young.");
            }
            else if (this.age >= 13 && this.age < 18)
            {
                System.Console.WriteLine("You are a teenager.");
            }
            else {
                System.Console.WriteLine("You are old.");
            }
        }

    }
}
