using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   
    internal class mathematik
    { 
        public double pi;
        public mathematik()//yapıcı kurucu fonksiyon
        {
            pi = 3.14;
        }
        ~mathematik()//yıkıcı fonksiyon
        {

        }
        public double topla(int x, int y)
        {
            return x + y;
        }
        public double cikar(int x, int y)
        {
            return x - y;
        }
        public double carp(int x, int y)
        {
            return x * y;
        }
        public double bol(int x, int y)
        {
            return x / y;
        }
        public double ustal(int x,int y)
        {
            return Math.Pow(x, y);
            
        }
    }
}
