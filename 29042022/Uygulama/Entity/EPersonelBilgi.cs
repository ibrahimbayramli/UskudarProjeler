using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EPersonelBilgi
    {
        private int _ID;
        private string _PersonelAdi;

        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }

        public string PersonelAdi
        {
            get { return _PersonelAdi; }
            set { _PersonelAdi = value; }
        }
    }
}
