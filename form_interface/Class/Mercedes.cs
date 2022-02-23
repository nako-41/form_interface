using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_interface.Class
{
    public class Mercedes : IAracOzellikleri
    {
        public string Marka
        {
            get { return "Mercedes"; }
        }

        public string Model
        {
            get { return "A sınıfı"; }
        }

        private int _hiz;
        public int hiz 
        { get { return _hiz;  }
          set { _hiz = value; }
        }
        private int _fiyat;
        public int fiyat 
        { get { return _fiyat; }
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
    }
}
