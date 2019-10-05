using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Temporada
    {
        private string Titulo { get; set; }
        private int Numero { get; set; }
        private DateTime Fecha { get; set; }
        private string Imagen { get; set; }
        private List<Episodio>Episodios { get; set; }


    }
}
