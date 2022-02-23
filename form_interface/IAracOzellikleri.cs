using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_interface
{
   public interface IAracOzellikleri
    {
        string Marka { get; }
        string Model { get; }
        int hiz { get; set; }
        int fiyat { get; set; }

        //metotlar

        int Gosterge(int deger);
        string BilgiVer();


    }
}
