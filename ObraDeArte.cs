using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1__CentroCultural
{
    class ObraDeArte 
    {
        private int codigo;
        private string name;
        private string nombreArtista;
        private int anioCreacion;
        private DateTime fechaIngreso;


        //constructor
        public ObraDeArte(int code, string nombre, string nombreArt, int anioCrea, DateTime fechaIng)
        {
            codigo = code;
            name = nombre;
            nombreArtista = nombreArt;
            anioCreacion = anioCrea;
            fechaIngreso = fechaIng;
        }


        //setters y getters

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string NombreArtista
        {
            get { return nombreArtista; }
            set { nombreArtista = value; }
        }
        public int AnioCreacion
        {
            get { return anioCreacion; }
            set { anioCreacion = value; }
        }

        public DateTime FechaIngreso
        {
            get { return fechaIngreso; }
            set { fechaIngreso = value; }
        }


        ///Fin setter y getter
    }
}
