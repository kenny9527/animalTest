using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace InterfaceTest
{


    public interface ShoutInterface
    {
        string Shout();
    }

    
    public class Duck : ShoutInterface
    {
        public string Shout()
        {
            return "呱呱";
        }
    }

    public class Dog : ShoutInterface
    {
        public string Shout()
        {
            return "汪汪";
        }
    }

    public class Cow : ShoutInterface
    {
        public string Shout()
        {
            return "哞哞";
        }
    }




    class Program
    {
       
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", new Duck());
            ht.Add("2", new Dog());
            ht.Add("3", new Cow());
            ht.Add("3", new Cow());

            Dictionary<string, ShoutInterface> dictAnimalMapping = new Dictionary<string, ShoutInterface>();

            dictAnimalMapping.Add("1", new Duck());
            dictAnimalMapping.Add("2", new Dog());
            dictAnimalMapping.Add("3", new Cow());


            Console.WriteLine("InterfaceTest");
            Console.WriteLine("想聽哪隻動物叫 1.鴨 2.狗 3.牛");

            //AssemblyName name = new AssemblyName("InterfaceTest");
            //Assembly mscorlib = typeof(ShoutInterface).Assembly;
            //foreach (Type type in mscorlib.GetTypes())
            //{
            //    if (type.FullName.Equals("InterfaceTest.ShoutInterface")) continue;
            //    Console.Write(string.Format("{0}  ", type.FullName));
            //}
            //Console.ReadLine();

            //while (true)
            //{
            //    string keyName = Console.ReadLine();

            //    AssemblyName name = new AssemblyName("InterfaceTest");
            //    Assembly asm = Assembly.Load(name);
            //    ShoutInterface an = (ShoutInterface)asm.CreateInstance("InterfaceTest." + keyName);
            //    Console.WriteLine(AnimalShout(an));

            //}

            while (true)
            {
                string keyName = Console.ReadLine();
                //try
                //{
                    ShoutInterface an = (ShoutInterface)ht[keyName];
                    //ShoutInterface an = dictAnimalMapping[keyName];
                    Console.WriteLine(AnimalShout(an));
                //}
                //catch(System.Collections.Generic.KeyNotFoundException e)
                //{
                //    throw ;
                //}
                
            }

        }

        static string AnimalShout(ShoutInterface an)
        {
            
            if(an==null)
            {
                return "please key Animal";
            }
            return an.Shout();
        }
    }
}

