using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_programação_comput_1_bimestre
{
    class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        public DateTime Validade { get; set; }

        public Produto(string nome, float preco, DateTime validade)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Validade = validade;
        }
    }
}
