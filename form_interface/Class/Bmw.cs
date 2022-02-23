using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_interface.Class
{
    public class Bmw : IAracOzellikleri, IAracPuan
    {
        public string Marka  { get { return "BMW"; }}

        public string Model { get { return "M SINIFI"; } }

        private int _hiz;
        public int hiz
        {
          get { return _hiz;}
            set { _hiz = value; }
        }
        private int _fiyat;
        public int fiyat
        { get { return _fiyat;}
          set { _fiyat = value; }
        }

        public string BilgiVer()
        {
            return "MARKA" + Marka + "MODEL" + Model + " FİYAT" + fiyat + "HIZ" + hiz;
        }

        public int Gosterge(int deger)
        {
            return (deger);
        }

        public double AracPuan(double puan)
        {
            return puan * 3.6;
        }
    }
}
