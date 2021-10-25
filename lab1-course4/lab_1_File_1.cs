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
            number = Convert.ToInt32(Console.ReadLine()); // ввод целого числа 
            return "";
        }
        public string Examination()
        {
            if (Convert.ToInt32(number) == Convert.ToDouble(number)) // проверка на целостность числа
            {
                answer = 1; // целое
            }
            else
            {
                answer = 0; // не целое
            }
            string answer_con = Convert.ToString(answer); // конвертирования числа в строку
            return answer_con;
        }

        public string Calculation()
        {
            if (number > 999) // целое число больше 999
            {
                thousands = (number / 1000) * 10; // количество тысяч если такое является
            }
            int hundreds = (number % 1000) / 100; // количество сотен в числе
            sum = thousands + hundreds; // сколько всего стотен в числе
            return "";
        }


        public int j;
        public string MyClass()
        {
            j = sum;
            string str = Convert.ToString(j); // перевод числа в строку
            return str;
        }

    }
}