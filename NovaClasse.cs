using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADARD
{
    class NovaClasse
    {
        private static string _chtxt;
        public static string chtxt
        {
            get { return _chtxt; }
            set { _chtxt = value; }
        }
        private static int _mudeacor;
        public static int mudeacor
        {
            get { return _mudeacor; }
            set { _mudeacor = value; }
        }
    }
}
