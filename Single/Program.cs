using System;

namespace Single_Level_Inheritance
{
    class Father
    {

        public void home()
        {
            Console.WriteLine("Father's home");
        }

        public void Car()
        {
            Console.WriteLine("Father's Car");
        }
    }

    //Inherit /derived / extends
    class Son : Father
    {

        public void mobile()
        {
            Console.WriteLine("Son's mobile");
        }
    }




    public class CSharpinheritance
    {

        public static void Main(String[] args)
        {

            Son s = new Son();
            s.mobile();
            s.Car();
            s.home();

        }

    }
}

