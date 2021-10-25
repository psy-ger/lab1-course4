using System;
namespace lab_1_File_2
{
    public class Program2
    {
        public int sum;
        public string Raschet()
        {

            int thousands = 1;
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 999)
            {
                thousands = (number / 1000) * 10;
            }else
            {
               thousands = 0;

            }
            int hundreds = (number % 1000) / 100;
            sum = thousands + hundreds;
            return "";
        }


        public int j;
        public string MyClass()
        {
            j = sum;
            string str = Convert.ToString(j);
            return str;
        }

    }
}