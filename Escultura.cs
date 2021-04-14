using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1__CentroCultural
{
    class Escultura : ObraDeArte
    {
        private double peso;
        private double volumen;

        public Escultura(double p, double vol)
        : base(codigo,name, nombreArtista, anioCreacion, fechaIngreso)
        { 
            peso = p;
            volumen = vol;
        }
    }
}
