namespace FutbolOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Oyun oyun = new Oyun();
            oyun.Oyna();
            oyun.SkorYazdir();
        }
    }
}