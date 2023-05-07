using folhaDePagamento.controller;
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
    public partial class FormFuncionarios : Form
    {
        public FormFuncionarios()
        {
            InitializeComponent();
            GerarGrade();
            PopularGrade();
        }
        private void GerarGrade()
        {
            listFuncionarios.Columns.Add("Id", 40).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.Columns.Add("Nome", 280).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.Columns.Add("Cargo", 200).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.Columns.Add("CPF", 165).TextAlign = HorizontalAlignment.Center;
            listFuncionarios.View = View.Details;

            listFuncionarios.FullRowSelect = true;
            listFuncionarios.GridLines = true;
            listFuncionarios.CheckBoxes = true;


        }

        public void PopularGrade()
        {
            String[] item = new string[4];
            ConnectDatabase connect = new ConnectDatabase();
            var listFunc = connect.queryFunc();
            foreach (ListFuncionarios funcionario in listFunc)
            {
                item[0] = funcionario.Id.ToString();
                item[1] = funcionario.Nome;
                item[2] = funcionario.Cargo;
                item[3] = funcionario.Cpf;
                listFuncionarios.Items.Add(new ListViewItem(item));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AdicionarFuncionario form = new AdicionarFuncionario();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listFuncionarios.Items)
            {
                if (item.Selected || item.Checked)
                {
                    ConnectDatabase connect = new ConnectDatabase();
                    ListViewItem items = listFuncionarios.Items[item.Index];
                    connect.removeFunc(items.SubItems[0].Text);
                    listFuncionarios.Items.RemoveAt(item.Index);
                }
                    
                
            }
        }

        private void listFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listFuncionarios.Items)
            {
                if (item.Selected || item.Checked)
                {
                    ListViewItem items = listFuncionarios.Items[item.Index];
                    AlterarDados alterarDados = new AlterarDados(int.Parse(items.SubItems[0].Text));
                    alterarDados.StartPosition = FormStartPosition.CenterScreen;
                    alterarDados.ShowDialog();

                }
            }
        }

    }
}
