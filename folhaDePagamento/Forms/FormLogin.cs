using folhaDePagamento.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folhaDePagamento.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConnectDatabase connect = new ConnectDatabase();
            if (connect.LoginAuth(boxUsuario.Text, boxSenha.Text))
            {
                FormMainMenu formMain = new FormMainMenu();
                formMain.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta!");
            }
        }
    }
}
