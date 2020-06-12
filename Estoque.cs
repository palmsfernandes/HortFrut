using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HortFrut
{
    public class Estoque
    {
        public int Quantidade { get; set; }
        public string CodProduto { get; set; }
        public int EstoqueMinimo { get; set; }
        public int Resposicao { get; set; }

        public void CadastrarQuantidade() { }
        public void CadastrarCodigo() { }
        public void CadastrarEstoqueMin() { }
        public void CadastrarDataReposicao() { }
    }
}
