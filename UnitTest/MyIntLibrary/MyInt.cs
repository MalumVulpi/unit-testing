using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIntLibrary
{
    public class MyInt
    {
        public StringBuilder number = new StringBuilder(50);

        public MyInt()
        {
            this.number = new StringBuilder(50);
        }

        public MyInt(int number)
        {
            //Проверка на переполнение 
            if (int.MaxValue > number && number > int.MinValue)
                this.number.Append(number);
        }

        public MyInt(String number)
        {
            this.number.Append(number);
        }

        public MyInt(Boolean number)
        {
            this.number.Append(number);
        }

        public MyInt(Byte[] number)
        {
            if (number[0] == 1)
                this.number.Append("-");

            for (int i = 1; i < number.Length; i++)
            {
                this.number.Append(number[i]);
            }
        }

        //Сложение +
        public MyInt add(MyInt number)
        {
            int result = Convert.ToInt32(this.number.ToString()) + Convert.ToInt32(number.number.ToString());

            if (int.MaxValue > result && result > int.MinValue)
                return new MyInt(result);
            else
                return new MyInt("Переполнение");
        }

        //Вычитание -
        public MyInt subtract(MyInt number)
        {
            int result = Convert.ToInt32(this.number.ToString()) - Convert.ToInt32(number.number.ToString());

            if (int.MaxValue > result && result > int.MinValue)
                return new MyInt(result);
            else
                return new MyInt("Переполнение");
        }

        //Умножение
        public MyInt multiply(MyInt number)
        {
            int result = Convert.ToInt32(this.number.ToString()) * Convert.ToInt32(number.number.ToString());

            if (int.MaxValue > result && result > int.MinValue)
                return new MyInt(result);
            else
                return new MyInt("Переполнение");
        }

        //Умножение
        public MyInt divide(MyInt number)
        {
            if (int.Parse(number.number.ToString()) != 0)
            {
                int result = Convert.ToInt32(this.number.ToString()) / Convert.ToInt32(number.number.ToString());
                return new MyInt(result);
            }
            else
            {
                return new MyInt("Деление на 0 не доступно");
            }
        }

        //Макс
        public MyInt max(MyInt number)
        {
            if (Convert.ToInt32(this.number.ToString()) >= Convert.ToInt32(number.number.ToString()))
                return new MyInt(this.number.ToString());
            else
                return new MyInt(number.number.ToString());
        }

        //Мин
        public MyInt min(MyInt number)
        {
            if (Convert.ToInt32(this.number.ToString()) >= Convert.ToInt32(number.number.ToString()))
                return new MyInt(number.number.ToString());
            else
                return new MyInt(this.number.ToString());
        }

        //Модуль
        public MyInt abs()
        {
            return new MyInt(Math.Abs(int.Parse(this.number.ToString())));
        }

        //Сравнение
        public MyInt compareTo(MyInt number)
        {
            Boolean resultult = int.Parse(this.number.ToString()).Equals(int.Parse(number.number.ToString()));
            return new MyInt(resultult);
        }

        //Наибольший  общий делитель
        public MyInt gcd(MyInt number)
        {
            int x = int.Parse(this.number.ToString());
            int y = int.Parse(number.number.ToString());

            if (y != 0)
            {
                while (x != y)
                {
                    if (x > y)
                        x = x - y;
                    else
                        y = y - x;
                }
            }

            return new MyInt(x);
        }

        //Преобразование в строку
        public String String()
        {
            return this.number.ToString();
        }

        //Преобразование в лонг
        public long Long()
        {
            return long.Parse(this.number.ToString());
        }
    }
}
