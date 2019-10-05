using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IPersistente
    {
        //int EjecutarNoQuery(SqlConnection con, string texto, CommandType tipo, List<SqlParameter> parameters);
        //SqlTransaction EjecutarNoQuery(SqlConnection con, string text, CommandType tipo, List<SqlParameter> parametros, SqlTransaction trans);
        //SqlDataReader EjecutarQuery(SqlConnection con, string text, CommandType tipo, List<SqlParameter> parametros);
        bool Insertar();
        bool Eliminar();
        bool Modificar();

    }
}
