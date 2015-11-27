using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class AeronaveModel
    {
        public String   matricula               { get; set; }
        public String   modelo                  { get; set; }
        public int      capacidadKg             { get; set; }
        public int      idFabricante            { get; set; }
        public int      idTipoServicio          { get; set; }
        public DateTime fechaAlta               { get; set; }
        public String   fueraServicio           { get; set; }
        public String   fueraDeUso              { get; set; }
        public int      cantButacasVen          { get; set; }
        public int      cantButacasPas          { get; set; }
        public int      estado                  { get; set; }

        public int      cantidadButacas         { get; set; }

    }

    public enum AeronaveEstado
    {
        ACTIVA          = 0,
        FUERA_SERVICIO  = 1,
        ELIMINADA       = 2
    }
}
