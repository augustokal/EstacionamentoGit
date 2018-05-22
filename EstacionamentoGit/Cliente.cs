using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoGit
{
    class Cliente
    {
        String cpf;
        String nome;
        String endereco;
        String numero;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
    }
}
