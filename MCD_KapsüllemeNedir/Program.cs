using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsüllemeNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            /*
             * Field değer ataması yapılmasın ama değer okuması yapılabilsin.- private set {....}
             * Field değer ataması yapılsın ama değer okuması yapılmasın.-private get {}
             * Field değer ataması yapılsın ama değerin ilk 4 hanesini okusun.
             * Field değer ataması ve okuma işlemleri yapılsın ama bu iki işlemde bizim belirlediğimiz bir süreçten geçsin veri daha sonra gösterilsin.
             * 
             */
            //M1.emailAdres = "esra";(field)

            //Genel olarak kapsülleme konusuna giriş yaptık.
            //M1.EmailAdres = "Esra Alkan";
            //Console.WriteLine(M1.EmailAdres);

            //1.Field değer ataması yapılmasın ama değer okunabilsin
            //Console.WriteLine($"Müşteri Id değeri: {M1.ID.ToString()}");
            // M1.ID = 10;

            //İsim ve Soyisim
            //isim ve soyisim [soyisim] = set
            //email adresi...
            //email get faik.turan@hotmail.com
            //set: private
            //M1.isim = "Faik";
            //M1.Soyisim = "Turan";
            //Console.WriteLine(M1.EmailAdres);

            M1.TcNo = "74352210640";
            Console.WriteLine(M1.TcNo);
            Console.ReadKey();
        }
    }
}
