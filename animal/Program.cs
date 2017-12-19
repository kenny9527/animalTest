using System;
using System.Reflection;

namespace abstractTest
{

    public abstract class Animal
    {
        public abstract string Shout();
    }
    public class Duck : Animal
    {
        public override string Shout()
        {
            return "呱呱";
        }
    }

    public  class Dog : Animal
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
            Console.WriteLine("abstractTest");
            Console.WriteLine("想聽哪隻動物叫 1.鴨 2.狗 3.牛");

            while (true)
            {
                string keyName = Console.ReadLine();
                
                AssemblyName name = new AssemblyName("abstractTest");
                Assembly asm = Assembly.Load(name);
                Animal an = (Animal)asm.CreateInstance("abstractTest." + keyName);
                Console.WriteLine(AnimalShout(an));
                   
            }

        }

        static string AnimalShout(Animal an)
        {

            if (an == null)
            {
                return "please key Animal";
            }
            return an.Shout();
        }
    }
}
