﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerolineaFrba.Model
{
    public class ButacaModel
    {
        public TipoButaca tipo { get; set; }
        public int numero { get; set; }
        public int id { get; set; }

        public ButacaModel(TipoButaca _tipo, int _numero)
        {
            tipo = _tipo;
            numero = _numero;            
        }

        public ButacaModel(int _id)
        {
            id = _id;
        }

    }

    public enum TipoButaca
    {
        VENTANILLA = 0,
        PASILLO = 1
    }
}
