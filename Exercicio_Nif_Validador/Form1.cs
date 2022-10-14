using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_Nif_Validador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private string validador (string nif)
        {
            //Vamos tentar amanhã substituir esse bool pelo string que mandará uma mensagem personalizada.

            //bool valor = false;
            string mensagem = "";
            int digitoControlo, resto, ultimoDigNif;
            int soma = 0;

            for(int idPosNif = 0; idPosNif <= 7; idPosNif++)
            {
              soma += int.Parse(nif[idPosNif].ToString()) * (9 - idPosNif);              
            }

            resto = soma % 11;

            if (resto == 0 || resto == 1)
            {
                digitoControlo = 0;
            }
            else digitoControlo = 11 - resto;

            ultimoDigNif = int.Parse(nif[8].ToString());

            if (ultimoDigNif == digitoControlo) mensagem = "Nif Válido";//Aqui que vais substituir o bool pelo string.
            else mensagem = "Nif Inválido";

            return mensagem;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string resultado; 

            if (mtxtNif.MaskCompleted == true)
            {
               resultado = validador(mtxtNif.Text);
               lblMensagemValidade.Text = resultado;
            }
            else MessageBox.Show("Preencha o Campo NIF.", this.Text,MessageBoxButtons.OK ,MessageBoxIcon.Error);
            mtxtNif.Focus();
        }
    }
}
