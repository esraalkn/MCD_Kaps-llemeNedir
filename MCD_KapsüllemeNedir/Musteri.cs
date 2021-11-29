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
        private string _soyisim;

        public string Soyisim
        {
            get
            {
                return this._soyisim;

            }
            set
            {
                this._soyisim = value;
                this.emailAdres = string.Format("{0}.{1}@hotmail.com", isim, _soyisim);
            }
        }

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
        //Ara Odev
        public string _TcKimlikNo;
        public string TcNo
        {
            
            get
            {
                if (_TcKimlikNo != null)
                {
                    return this._TcKimlikNo.Substring(0, 3);
                }
                else
                {
                    return " ";
                }
               

            }
            set
            {
              
                if (value.Length==11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterkontrol = char.IsNumber(value[i]);
                        if (karakterkontrol)
                        {
                            //sayısal değer demektir...
                        }
                        else
                        {
                            bayrak = true;
                            break;
                        }
                    }
                    if (bayrak)
                    {
                        Console.WriteLine("TC kimlik numarası içindeki değerler sayısal olmalıdır .....");
                    }
                    else
                    {
                        this._TcKimlikNo = value;

                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik numarası 11 hane olmalıdır.");
                }
               
               
            }
        }
    }
}
