using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstacionamentoGit
{
    class Veiculo
    {
        private String modelo;
        private String placa;
        private String tipo;

        public string Modelo { get => modelo; set => modelo = value; }
        public string Placa { get => placa; set => placa = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }
}
