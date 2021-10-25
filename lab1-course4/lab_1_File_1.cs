using System;
namespace lab_1_File_2
{
    public class Program2
    {
        public int sum;
        public int number;
        public int thousands;
        public int answer;
        
        public string Input()
        {  
            number = Convert.ToInt32(Console.ReadLine());
            return "";
        }
        public string Examination()
        {
            if (Convert.ToInt32(number) == Convert.ToDouble(number))
            {
                answer = 1;
            }
            else
            {
                answer = 0;
            }
            string answer_con = Convert.ToString(answer);
            return answer_con;
        }

            int thousands = 1;
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 1000)
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