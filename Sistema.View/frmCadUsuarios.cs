using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.View {
    public partial class frmCadUsuarios : Form {
        public frmCadUsuarios() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            opc = "Salvar";
            IniciarOpc();
        }

        private void button4_Click(object sender, EventArgs e) {
            opc = "Editar";
            IniciarOpc();
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void btnNovo_Click(object sender, EventArgs e) {
            opc = "Novo";
            IniciarOpc();
            HabilitarCampos();
            LimparCampos();
        }
        private string opc = "";

         private void IniciarOpc() {

            switch (opc) {
                case "Novo":
                    HabilitarCampos();
                    LimparCampos();
                    break;
                case "Salvar":
                    break;
                case "Excluir":
                    break;
            }
             
         }

        //Vamos criar as funçoes abaixo
        private void HabilitarCampos() {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            TxtSenha.Enabled = true;
        }
        private void LimparCampos() {
            txtNome.Text = "";
            txtUsuario.Text = "";
            TxtSenha.Text =  "";
       }

        private void btnExcluir_Click(object sender, EventArgs e) {
            opc = "Excluir";
            IniciarOpc();
        }
    }
}
