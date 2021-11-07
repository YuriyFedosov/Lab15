using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:

            метод void setStart(int x) - устанавливает начальное значение
            метод int getNext() - возвращает следующее число ряда
            метод void reset() - выполняет сброс к начальному значению
            
            Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
            В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической прогрессии соответственно.*/
            
            ArithProgression aProgr = new ArithProgression(); //Создаем экземпляр класса
            aProgr.setStart(15); //Присваивание начального значения
            aProgr.Num = 4;// Задаем значение вычисляемого члена и разности прогрессии
            Console.WriteLine("Стартовое значение {0}", aProgr.val);
            for (int i = 1; i < aProgr.Num; i++) //Подсчет
            {
                aProgr.getNext();
            }            
           
            Console.WriteLine("Значение {0} члена прогресии с разностью {0} равно {1}", aProgr.Num, aProgr.val);
        
            //aProgr.reset();
            //Console.WriteLine("Значение после сброса на начальные значения равно {0}",aProgr.val); 
            Console.WriteLine();

            GeomProgression gProgr = new GeomProgression();//Создаем экземпляр класса
            gProgr.setStart(15);//Присваивание начального значения
            gProgr.Num = 2;// Задаем значение вычисляемого члена и знаменателя прогрессии
            Console.WriteLine("Стартовое значение {0}",gProgr.val);
            for (int i = 1; i < gProgr.Num; i++)
            {
                gProgr.getNext();
            }
          
            Console.WriteLine("Значение {0} члена прогресии со знаменателем {0} равно {1}", gProgr.Num, gProgr.val);
            //gProgr.reset();
            //Console.WriteLine("Значение после сброса на начальные значения равно {0}",gProgr.val);
            Console.ReadKey();
        }
    }
    interface ISeries //Интерфейс
    {
        void setStart(int x);
        int getNext();
        void reset();

    }

    class ArithProgression : ISeries
    {
        public int val; //Требуемые переменные для расчетов
        public int Num{get;set;}
        int beg;

        public ArithProgression()
        {
            val = 0;
            beg = 0;
        }
        public int getNext()
        {
            val+=Num;
            return val;
        }

        public void reset()
        {
            val=beg;
        }

        public void setStart(int x)
        {
            val = beg =x;
        }
    }

    class GeomProgression : ISeries
    {
        public int val; //Требуемые переменные для расчетов
        public int Num { get; set; }
        int beg;
        public GeomProgression()
        {
            beg = 0;
            val = 0;

        }
        public int getNext()
        {
            val *= Num;
            return val;
        }

        public void reset()
        {
            val=beg;
        }

        public void setStart(int x)
        {
            val=beg=x;
        }
    }
}
