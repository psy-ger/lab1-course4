using System;
using lab_1_File_2;

namespace lab_1_File_1
{
    class Program
    {

        static void Main(string[] args)
        {

            Program2 classcall = new Program2();
            Console.Write(classcall.Input());
            Console.Write(classcall.Examination());
            Console.WriteLine("\n");

            if (classcall.Examination() == Convert.ToString(1))
            {
                Console.Write(classcall.Calculation());
                Console.Write(classcall.MyClass());
            }
            else
            {
                Console.WriteLine("Число не целое");
            }


            Console.ReadLine();

        }
    }
}