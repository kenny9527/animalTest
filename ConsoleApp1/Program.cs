using System;
using System.Reflection;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string functionName = "InterfaceTest";

            Console.WriteLine(functionName);
            Console.WriteLine("想聽哪隻動物叫 1.鴨 2.狗 3.牛");

            //AssemblyName name = new AssemblyName("InterfaceTest");
            //Assembly mscorlib = typeof(ShoutInterface).Assembly;
            //foreach (Type type in mscorlib.GetTypes())
            //{
            //    if (type.FullName.Equals("InterfaceTest.ShoutInterface")) continue;
            //    Console.Write(string.Format("{0}  ", type.FullName));
            //}
            //Console.ReadLine();

            while (true)
            {
                string keyName = Console.ReadLine();

                AssemblyName name = new AssemblyName("InterfaceTest");
                Assembly asm = Assembly.Load(name);
                ShoutInterface an = (ShoutInterface)asm.CreateInstance("InterfaceTest." + keyName);
                Console.WriteLine(AnimalShout(an));

            }

        }
    }
}
