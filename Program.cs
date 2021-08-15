using System;

namespace Rekürsif_Fonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif Metodlar
           int result =1 ;
           for (int i = 0; i < 5; i++)
           {
               result = result*3 ;
               Console.WriteLine(result) ;
           }
          
           Islemler instance = new() ;
           Console.WriteLine(instance.expo(3,5)) ;

           //Extension Metot
           string ifade = "Merve Özderin MTM" ;
           bool sonuc = ifade.kontrolbosluk();
           Console.WriteLine(sonuc) ;

           if(sonuc)
           {
               Console.WriteLine(ifade.kaldırbosluk()) ;
           }

           Console.WriteLine(ifade.MakeUpperCase());
           Console.WriteLine(ifade.MakeLowerCase());

           int[] dizi = {2,5,8,45,78,12,63} ;
           dizi.sıralıdizi();
           dizi.ekranayazdir();
 
           int sayi =  7 ;
           Console.WriteLine(sayi.tekciftmi()) ;

           Console.WriteLine(ifade.ilkkarakter());

        }
    }

    public class Islemler
    {
        public int expo(int sayi, int üs)
        {
            if(üs==0)
            { return 1; }

              else if (üs<2)
              {return sayi;}

            return expo(sayi, üs-1)*sayi ;
        }
    }

    public static class extension
    {
        public static bool kontrolbosluk(this string p)
        {
            return p.Contains(" ") ;
        }

        public static string kaldırbosluk(this string p)
        {
            string[] dizi = p.Split(" ") ;
            return string.Join("",dizi);

        }

        public static string MakeUpperCase(this string p)
        {
            return p.ToUpper();
        }

        public static string MakeLowerCase(this string p)
        {
            return p.ToLower();
        }

        public static int[] sıralıdizi( this int[] p)
        {
            Array.Sort(p) ;
            return p;
        }

        public static void ekranayazdir(this int[] p)
        {
             foreach (int item in p)
              Console.WriteLine(item) ;          
        }

        public static bool tekciftmi(this int p)
        {
            return p % 2 ==0 ;
        }

        public static string ilkkarakter( this string p)
        {
            return p.Substring(0,1) ;
        }
        
    }
}
