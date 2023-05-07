using folhaDePagamento.controller;
using folhaDePagamento.services;
using Org.BouncyCastle.Crypto.Tls;
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
    public partial class FormFolha : Form
    {
  
        private Form currentChildForm;
        public FormFolha()
        {
            InitializeComponent();
            PopularBox();
          
        }

        private void abrirChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BringToFront();
            childForm.Show();
        }

        public void PopularBox()
        {
            String[] item = new string[5];
            foreach (ListFuncionarios funcionario in funcionariosAll())
            {
                item[0] = funcionario.Id.ToString();
                item[1] = funcionario.Nome;
                item[2] = funcionario.Cargo;
                item[3] = funcionario.Cpf;
                item[4] = funcionario.DataAdmissao;
                comboNome.Items.Add(item[1]);
            }
        }
        private List<ListFuncionarios> funcionariosAll(){
            ConnectDatabase connect = new ConnectDatabase();
            var listFunc = connect.queryFunc();
            return listFunc;
        }

        private void comboNome_SelectedIndexChanged(object sender, EventArgs e)
        {
            var funcionarioSelecionado = comboNome.SelectedItem.ToString();
            String[] item = new string[5];
            foreach (ListFuncionarios funcionario in funcionariosAll())
            {
                if (funcionarioSelecionado == funcionario.Nome.ToString())
                {
                    boxDataAdmissao.Text = funcionario.DataAdmissao;
                    boxCpfFolha.Text = funcionario.Cpf;
                }
            }
        
        }
        private double calculoInss(double salarioBruto)
        {
            if(salarioBruto < 1302.00){
                return salarioBruto * 0.75;
            }else if(salarioBruto < 2571.29 && salarioBruto > 1302.00)
            {
                return (salarioBruto - 1302.00) * 0.09 + 97.65;
            }else if(salarioBruto < 3856.94 && salarioBruto > 2571.29)
            {
                return (salarioBruto - 2571.29) * 0.12 + 114.24 + 97.65;
            }else
            {
                return (7507.49 - 3856.94) * 0.14 + 114.24 + 97.65 + 154.28;
            }
      
        }

        private void btnGerFolha_Click(object sender, EventArgs e)
        {

            double salario = double.Parse(boxSalario.Text);
            double fgts = calculoInss(salario);
            PopularDataGrip(salario, fgts, 0);           

        }
        
        public void PopularDataGrip(double salario, double inss, double irrf)
        {
            gridCalc.Rows.Add("DIAS TRABALHADOS", 30, salario);
            gridCalc.Rows.Add("DESCONTO DE INSS", "", "", inss.ToString("0.00"));
            gridCalc.Rows.Add("DESCONTO DE I.R.F", irrf, "", irrf.ToString("0.00"));
            gridCalc.Rows.Add();
            gridCalc.Rows.Add();
            gridCalc.Rows.Add();
            gridTotal.Rows.Add("Salário", 0, "", salario, salario, inss, (salario-inss).ToString("0.00"));
            gridTotal.Rows.Add("Férias");
            gridTotal.Rows.Add("13º Salário", "", "", "Valor do Fgts");
            gridTotal.Rows.Add("Av.Prévio", "", "", "0");
        }
    }
}
