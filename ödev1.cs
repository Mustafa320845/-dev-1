using System;

class Cicekler : Bitkiler

{
    public void Kokmak()
    {
        Console.WriteLine("çiçekler güzel kokar.");
    }
}

class Güller : Cicekler
{
    public void Kırmızıdırlar()
    {
        Console.WriteLine("güller genellikle kırmızıdırlar.");
    }

}

class Papatyalar : Cicekler
{
    public void SeviyorSevmiyorOynanır()
    {
        Console.WriteLine("papatyalarla seviyor sevmiyor oynanır.");
    }
}




class Program
{
    static void Main(string[] args)
    {
        Bitkiler bitkiler = new Bitkiler();
        Cicekler cicekler = new Cicekler();
        Güller güller = new Güller();
        Papatyalar papatyalar = new Papatyalar();

        Console.WriteLine("Bitkiler Özellikleri:");
     

        Console.WriteLine("Çiçekler Özellikleri:");
     
        cicekler.Kokmak();

        Console.WriteLine("Güller Özellikleri:");
       
        güller.Kokmak();
        güller.Kırmızıdırlar();

        Console.WriteLine("Papatyalar Özellikleri:");
        papatyalar.Kokmak();
        papatyalar.SeviyorSevmiyorOynanır();
    }
}
