using System;

namespace classTest
{

    public class Animal
    {
        public virtual string Shout()
        {
            return "animal";
        }
    }
    public class Duck : Animal
    {
        public override string Shout()
        {
            return "呱呱";
        }
    }

    public class Dog : Animal
    {
        public override string Shout()
        {
            return "汪汪";
        }
    }

    public class Cow : Animal
    {
        public override string Shout()
        {
            return "哞哞";
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ClassTest");
            Console.WriteLine("想聽哪隻動物叫 1.鴨 2.狗 3.牛");

            while (true)
            {
                string keyNum = Console.ReadLine();

                Animal an = null;
                if (keyNum.Equals("1"))
                {
                    an = new Duck();
                }
                else if (keyNum.Equals("2"))
                {
                    an = new Dog();
                }
                else if (keyNum.Equals("3"))
                {
                    an = new Cow();
                }

                Console.WriteLine(AnimalShout(an));
            }

        }

        static string AnimalShout(Animal an)
        {

            if (an == null)
            {
                return "please key 1~3";
            }
            return an.Shout();
        }
    }


}
