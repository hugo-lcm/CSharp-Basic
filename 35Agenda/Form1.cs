﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35Agenda
{
    public partial class frmAgendaContatos : Form
    {
        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
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
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
        }
    }
}