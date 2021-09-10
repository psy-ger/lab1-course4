using System; 
using My_Second;

namespace My_Main
{
    class Program
    {
        static void Main(string[] args)
        { 
            

            //создаём экземпляр класса KK из My_Second.cs
           KK blabla = new KK();

            Console.WriteLine(blabla.Hello_Wolrd()) ; //вызываем метод у My_Second.cs 

            // Ожидание нажатия любой клавиши  перед завершением работы
            Console.ReadLine();
        }
    }
}
