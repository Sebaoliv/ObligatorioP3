using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorios
{
    public class RepositorioPersona : Interfaces.IRepositorioPersona
    {
        public bool Add(Persona per)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Persona per)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> FindAll()
        {
            throw new NotImplementedException();
        }

        public Persona FindById(string nombre)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Persona> FindByName(string nom)
        {
            throw new NotImplementedException();
        }

        public bool Update(Persona per)
        {
            throw new NotImplementedException();
        }
    }
}
