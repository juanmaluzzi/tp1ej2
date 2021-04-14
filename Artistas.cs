using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1__CentroCultural
{
    class Artistas 
    {
        private string name;
        private string nacionalidad;
        private DateTime fechaNac;
        private DateTime fechaFallecimiento;


        //constructor
        public Artistas(string nombre, string nac, DateTime dateNac, DateTime dateFalle) 
        {
            name = nombre;
            nacionalidad = nac;
            fechaNac = dateNac;
            fechaFallecimiento = dateFalle;
        }


        //setter y getters
        public string Nacionalidad 
        {
            get { return nacionalidad; }  
            set { nacionalidad = value; }  
        }
    }
}
