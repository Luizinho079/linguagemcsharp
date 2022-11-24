using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Judiciario
{
    public class Cidade
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public Estado  Estado { get; set; }

        public List<Cidade> getTodasCidades()
        {
            return nu11;
        }
        public List<Cidade> getRetornaCidade(int idCidade)
        {
            return nu11;
        }
        public List<Cidade> getCidadePorEstado(Estado Estado)
        {
            return nu11;
        }
    }
}
