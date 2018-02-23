using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.DataAccess
{
    public class ProdModelo : Produto
    {
        public string NomeModelo { get; set; }
        public int QtdeEstoque { get; set; }
        public int QtdeEstoqueC { get; set; }
        public int QtdeEstoqueS { get; set; }
        public DateTime DataUltVend { get; set; }
        public DateTime DataUltComp{ get; set; }

        public ProdModelo() { }
    }
}
