using System;
namespace staticConstructorExample
{
    class geeks
    {
        static geeks()
        {
            Console.WriteLine("Static Constructor");
        }

        // Instance constructor.
        public geeks(int i)
        {
            Console.WriteLine("Instance Constructor " + i);
        }

        // Instance method.
        public string geeks_detail(string name, int id)
        {
            return "Name:" + name + " id:" + id;
        }
        public static void Main()
        {

            //Both Static and instance constructors are invoked
            geeks obj = new geeks(1);

            //Only instance constructor will be invoked
            geeks obj1 = new geeks(2);
        }
    }
}