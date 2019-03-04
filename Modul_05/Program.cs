using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Modul_05
{
    class Program
    {
        static void Main(string[] args)
        {
            t3();
        }
        static void t1()
        {
            //1.Перехватить исключение запроса к несуществующему веб ресурсу и вывести 
            //сообщение о том, что произошла ошибка.Программа должна завершиться без ошибок.
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://mytat.itstep.org");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                response.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
        static void t2()
        {
            //2.Написать программу, которая обращается к элементам массива по индексу и 
            //выходит за его пределы. После обработки исключения вывести в финальном блоке 
            //сообщение о завершении обработки массива.
            int[] arr = { 2, 4, 8, 7 };
            try
            {
                Console.WriteLine(arr[6]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Завершение обработки массива");
            }
        }
        static void t3()
        {
            //3. Реализовать несколько методов или классов с методами и вызвать один метод 
            //из другого. В вызываемом методе сгенерировать исключение и «поднять» 
            //его в вызывающий метод.
            Human h = new Human();
            try
            {
                h.setSex();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
        }
    }
    public class Human
    {
        string name { get; set; }
        int sex;

        public void setSex()
        {
            Console.WriteLine("Укажите пол(1-муж,2-жен): ");
            sex = int.Parse(Console.ReadLine());
            if (sex > 2 || sex < 1) throw new Exception("Неверно указан пол!");
        }
    }
}
