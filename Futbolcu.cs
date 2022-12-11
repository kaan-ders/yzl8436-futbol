using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    public abstract class Futbolcu
    {
        public string Isim { get; set; }
        //public int Sans { get; set; }
        //protected abstract bool SansHesapla();
    }

    public interface ISansiOlanFutbolcu
    {
        bool SansHesapla(int sans);
    }

    public class Forvet : Futbolcu
    {
        public int SutCek()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
    }

    public class Defans : Futbolcu, ISansiOlanFutbolcu
    {
        //public Defans(int sans)
        //{
        //    Sans = sans;
        //}

        public bool SansHesapla(int sans)
        {
            //Sans = sans;
            return sans > 80;
        }
    }

    public class Kaleci : Futbolcu, ISansiOlanFutbolcu
    {
        //public Kaleci(int sans)
        //{
        //    Sans = sans;
        //}

        public bool SansHesapla(int sans)
        {
            return sans > 40;
        }
    }
}