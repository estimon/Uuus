using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    public class Mammal
    {
        public Mammal()
        {
            SilmadeArv = 2;
            IsCarnivore = true;
            Breathe();
        }        
        public int SilmadeArv { get; set; }
        protected int Vanus { get; set; }
        public bool IsCarnivore { get; set; }       
        public void Breathe()
        {
            Console.WriteLine("I am breathin");
        }        
        public void SetAge(int age)
        {
            Vanus = age;
        }
        
    }
}
