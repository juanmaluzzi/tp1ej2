using System;
using System.Collections.Generic;
using System.Text;

namespace Tp1__CentroCultural
{
    class CentroCultural
    {

        //Variables de Instancia
        private string name;
        private ObrasExposicion obrasExpo;
        private ArtistasExpositores artistas;


        // Constructor
        public CentroCultural(string nombre,ObrasExposicion obrasExposi, ArtistasExpositores artist)
        {
            name = nombre;
            obrasExpo = obrasExposi;
            artistas = artist;
        }


        //SI TERMINAR ---> Hay que llamar a la variable de la interfaz
        public string NombresObrasNacionalidad(string Nac)
        {
            return Nac;
        }
    }


}
