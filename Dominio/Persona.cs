using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona :Persistente<Persona>
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Pais { get; set; }
        private string NombreArtistico { get; set; }
        private int NumeroRegistro { get; set; }


        public bool Validar()
        {
            return !string.IsNullOrEmpty(Nombre) &&NumeroRegistro>0; 
        }

        public override bool Eliminar()
        {
            throw new NotImplementedException();
        }

        public override bool Insertar()
        {
            throw new NotImplementedException();
        }

        public override bool Modificar()
        {
            throw new NotImplementedException();
        }
    }
}
