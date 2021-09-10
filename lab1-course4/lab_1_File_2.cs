using System; 
using lab_1_File_2;

namespace lab_1_File_1
{
    class Program
    {
  
        static void Main(string[] args)
        {

            Program2 classcall = new Program2();
            Console.Write(classcall.Raschet());
            Console.Write(classcall.MyClass()); 

            
            Console.ReadLine();

        }
    }
}
