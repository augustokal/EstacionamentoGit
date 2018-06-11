using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace EstacionamentoGit
{
    class conexao


    {

        
       public void conectar()
        {
            try
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=admin;Database=Estacionamento;");
                conn.Open();
                
            }
            catch (Exception ex) {
                throw ex;
            }; 
        }
    }
}
