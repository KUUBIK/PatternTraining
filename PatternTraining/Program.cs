using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;



namespace PatternTraining
{
    public delegate int Method(int x, int y);

    class Program
    {
        
        static void Main(string[] args)
        {
            
        }

        
        

      
    }


    static class Test
    {
       public static void LeghtString(this String str)
        {
            Console.WriteLine($"leght to {str}:" + str.Length);


        }


    }


    class Car
    {
        public Car() { }
        public string Color { get; set; }
        public string Name { get; set; }



        public Car(string name, string color):this()
        {
            Name = name;
            Color = color;
        }
    }

    
    delegate void meth(object sender, EventArgs e);
    
    
    class CarEvent:EventArgs
    {
        public string Name { get; set; }

        public CarEvent(string Name)
        {
            this.Name = Name;
        }

    }


   
    

}
