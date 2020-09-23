using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_programação_comput_1_bimestre
{
    public partial class Form1 : Form
    {
        //CRIAR DUAS LISTS PARA O DECORRER DO CÓDIGO
        List<Produto> listadeprodutos = new List<Produto>();
        List<Produto> Pesquisa = new List<Produto>();
        //

        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }

        //PROPRIEDADES DO BOTÃO ADICIONAR
        private void btnadicionar_Click(object sender, EventArgs e)
        {
            if (txtnome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome do produto", "Atenção");
            }
            else
            {
                listadeprodutos.Add(new Produto(txtnome.Text, (float)nuppreco.Value, dtvalidade.Value));
                mostrar(listadeprodutos);
                txtnome.Clear();
                dtvalidade.ResetText();
            }
        }
        //

        //FUNÇÃO MOSTRAR
        private void mostrar(List<Produto>lista)
        {
            list.Items.Clear();
            foreach (Produto produto in lista)
            {
                list.Items.Add(produto.Nome);
            }
        }
        //

        //SELECIONAR 
        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listadeprodutos.FindIndex(x => x.Nome == list.SelectedItem.ToString());
            //int index = list.SelectedIndex;
            txtnomealterar.Text = listadeprodutos[index].Nome;
            dataalterar.Value = listadeprodutos[index].Validade;
            nupprecoalterar.Text = Convert.ToString(listadeprodutos[index].Preco);
        }
        //

        //FUNÇÃO BOTÃO ALTERAR
        private void btnalterar_Click(object sender, EventArgs e)
        {
            int index = list.SelectedIndex;
            
            listadeprodutos[index].Nome = txtnomealterar.Text;
            listadeprodutos[index].Validade = dataalterar.Value;
            listadeprodutos[index].Preco = (float)nupprecoalterar.Value;
            mostrar(listadeprodutos);
        }
        //

        //FUNÇÃO BOTÃO FECHAR
        private void btnfechar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                Close();
            }
        }
        //

        //FUNÇÃO BOTÃO EXCLUIR 
        private void btnexcluir_Click(object sender, EventArgs e)
        {
            int index = list.SelectedIndex;
            var result = MessageBox.Show("Deseja realmente excluir?", "Atenção", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                txtnomealterar.Clear();
                dataalterar.ResetText();
            }
            listadeprodutos.RemoveAt(index);
            mostrar(listadeprodutos);
        }
        //

        //FUNÇÃO BOTÃO PESQUISA
        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisa = listadeprodutos.Where(x => x.Nome == txtpesquisa.Text).ToList();
            mostrar(Pesquisa);
        }
        //

        //LIMPAR FILTROS DA PESQUISA
        private void button2_Click(object sender, EventArgs e)
        {
            mostrar(listadeprodutos);
            txtpesquisa.Clear();
        }
        //
    }  

}
