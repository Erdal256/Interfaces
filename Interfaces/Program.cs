using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        interface IPersonManager
        {
            //unimplemented operation denir. interface oldugu zaman unimplemented olmakta
            void Add();
        }
        //inherist - class --------- implements - interface

        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                //MÜŞTERİ EKLEME KODLARI
                Console.WriteLine("Müşteri eklendi");
            }
        }
        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                //Personel EKLEME KODLARI
                Console.WriteLine("Personel eklendi");
            }
        }
    }
}
