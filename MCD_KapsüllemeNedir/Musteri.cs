using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KapsüllemeNedir
{
    class Musteri
    {

        //Class => Field
        int id;

       public  Musteri()
        {
            this.id = IDuret();
        }

       

        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                this.id = value;
            }
        }


        public string isim;
        public string soyisim;

        //Class => Property
        private string emailAdres;
        public string EmailAdres
        {
            //get;//Database veya farklı bir veri kaynağı class çağıran prodramcıya datayı gösterdiğimiz alan
            //set;//Dış dünyadan alınan datanın içerisinde private olarak saklanan fiels içerisine değer atandığı kısım... 

            set
            {
                this.emailAdres = value;
            }
            get
            {
                return this.emailAdres;
            }


        }
        private int IDuret()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 90000);


        }
    }
}
