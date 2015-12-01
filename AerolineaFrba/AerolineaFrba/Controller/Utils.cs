using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Controller
{
    public class Utils
    {
        private Boolean _isAdmin = false;
        
        private static Utils instance = new Utils();
        private Utils() { }

        public static Utils GetInstance
        {
            get
            {
                return instance;
            }
        }

        public void isAdmin(Boolean ia) { this._isAdmin = ia; }
        public Boolean isAdmin() { return this._isAdmin; }

    }
}
