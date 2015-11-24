using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    class PaqueteModel
    {
        public int paqueteId {get;set;}
        public int paquetePnr{get;set;}
        public int paqueteKg{get;set;}
        public double paqueteMonto{get;set;}
        public int estado { get; set; }

        public PaqueteModel(int paqueteId, int paquetePnr, int paqueteKg, double paqueteMonto, int estado)
        {
            this.paqueteId = paqueteId;
            this.paquetePnr = paquetePnr;
            this.paqueteKg = paqueteKg;
            this.paqueteMonto = paqueteMonto;
            this.estado = estado;
        }

        public PaqueteModel()
        {

        }
    }
}
