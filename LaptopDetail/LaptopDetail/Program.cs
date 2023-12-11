﻿using System.Collections;
using System.Security.Cryptography.X509Certificates;
using System.Timers;

namespace LaptopDetail
{
    class Base
    {
        public string BrandName;
        public int Price;
        public string Processor;
        public string RAM;
        public string HDD;
        public void SetInfo(string BrandName, int Price, string Processor, string RAM, String HDD) 
        {
            this.BrandName = BrandName;
            this.Price = Price;
            this.Processor = Processor;
            this.RAM = RAM;
            this.HDD = HDD;
        }
        public void PrintInfo() 
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("Brand Name :- {0}", BrandName);
            Console.WriteLine("Price      :- {0}", Price);
            Console.WriteLine("Processor  :- {0}", Processor);
            Console.WriteLine("RAM        :- {0}",RAM);
            Console.WriteLine("HDD        :- {0}", HDD);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Base[] LapArray = new Base[100];
            LapArray[0]=new Base();
            LapArray[0].SetInfo("Lenovo", 60000, "i5", "2GB", "500GB");

            LapArray[1]=new Base();
            LapArray[1].SetInfo("Dell",65000,"i7","4GB","1TB");

            LapArray[2]=new Base();
            LapArray[2].SetInfo("Sonny", 70000, "i9", "8GB", "1TB");

            LapArray[0].PrintInfo();
            LapArray[1].PrintInfo();
            LapArray[2].PrintInfo();

        }
    }
  

}