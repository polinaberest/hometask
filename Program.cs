using System;

namespace delegates_hometask
{
    public delegate void Delegate1<T>(T arg1);
    public delegate T Delegate2<T>(int arg1, T arg2);
    public delegate T Delegate3<T>(T arg1);
    public delegate int ArDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            Delegate1<double> method1 = ShowDouble;
            method1(2.5);
            Delegate2<string> method2 = ShowString;
            string str = method2(2, "Hello!");
            Console.WriteLine(str);

            Delegate3<string> method3 = GetString;
            GenericClass<string> genericClass = new GenericClass<string>(method3);

            GenericClass<string>.Execute(method3);

            ArDelegate final = (a, b) => (a + b) / ((a + b) / 2);
            Console.WriteLine(final(4, 6));


             
        }
        public static void ShowDouble(double a) 
        {
            Console.WriteLine("Here I show you "+a);
        }

        public static string ShowString(int count, string str)
        {
            string finalPhrase="";
            for (int i = 0; i < count; i++)
            {
                finalPhrase += str;
            }
            return finalPhrase;
        }

        public static string GetString(string str)
        {
            return str + " :)";
        }

       
    }
}
