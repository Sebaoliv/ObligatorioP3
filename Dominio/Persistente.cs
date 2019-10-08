using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class Persistente<T>
    {
        public abstract bool Insertar();
        public abstract bool Eliminar();
        public abstract bool Modificar();
                     

        public int EjecutarNoQuery(SqlConnection con, string texto, CommandType tipo, List<SqlParameter> parameters)
        {
           throw new NotImplementedException();

        }
        public SqlTransaction EjecutarNoQuery(SqlConnection con, string text, CommandType tipo, List<SqlParameter> parametros, SqlTransaction trans)
        {
            throw new NotImplementedException();
        }
        public SqlDataReader EjecutarQuery(SqlConnection con, string text, CommandType tipo, List<SqlParameter> parametros)
        {
            throw new NotImplementedException();
        }
    }
}
