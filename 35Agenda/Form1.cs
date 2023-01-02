using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35Agenda
{
    public partial class frmAgendaContatos : Form
    {
        private OperacaoEnum acao;

        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
            CarregarListaContatos();
        }

        private void AlterarBotoesSalvarCancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }

        private void AlterarBotoesIncluirAlterarExcluir(bool estado)
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                NumeroTelefone = txbTelefone.Text
            };
            List<Contato> contatosList = new List<Contato>();

            foreach (Contato x in listBoxContatos.Items)
            {
                contatosList.Add(x);
            }
            if (acao == OperacaoEnum.INCLUIR)
            {
                contatosList.Add(contato);

            }
            else
            {
                int indice = listBoxContatos.SelectedIndex;
                contatosList.RemoveAt(indice);
                contatosList.Insert(indice, contato);
            }

            ManipuladorArquivos.EscreverArquivo(contatosList);
            CarregarListaContatos();
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
            LimparCampos();
        }

        private void CarregarListaContatos()
        {
            listBoxContatos.Items.Clear();
            listBoxContatos.Items.AddRange(ManipuladorArquivos.LerArquivo().ToArray());
            listBoxContatos.SelectedIndex = 0;
        }

        private void LimparCampos()
        {
            txbNome.Clear();
            txbEmail.Clear();
            txbTelefone.Clear();

        }

        private void AlterarEstadoCampos(bool estado)
        {
            txbNome.Enabled = estado;
            txbEmail.Enabled = estado;
            txbTelefone.Enabled = estado;

        }

        private void listBoxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contato contato = (Contato)listBoxContatos.Items[listBoxContatos.SelectedIndex];
            txbNome.Text = contato.Nome;
            txbEmail.Text = contato.Email;
            txbTelefone.Text = contato.NumeroTelefone;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza?", "Excluir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indiceExcluido = listBoxContatos.SelectedIndex;
                listBoxContatos.SelectedIndex = 0;
                listBoxContatos.Items.RemoveAt(indiceExcluido);
                List<Contato> contatosList = new List<Contato>();
                foreach (Contato x in listBoxContatos.Items)
                {
                    contatosList.Add(x);
                }
                ManipuladorArquivos.EscreverArquivo(contatosList);
                CarregarListaContatos();
                LimparCampos();
            }
        }
    }
}
