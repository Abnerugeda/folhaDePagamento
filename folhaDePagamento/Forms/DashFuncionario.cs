using folhaDePagamento.controller;
using folhaDePagamento.services;
using MySql.Data.MySqlClient;
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
    public partial class DashFuncionario : Form
    {
        public DashFuncionario()
        {
            InitializeComponent();
            queryFunc();
        }
        private void queryFunc()
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM funcionario, FOLHA where  FUNCIONARIO.IDFUNCIONARIO = FOLHA.IDFUNCIONARIO", db.connect());
            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                string data = reader["DATA_GERADO"].ToString().Split(" ")[0];
                comboNomeFunc.Items.Add($"{reader["IDFUNCIONARIO"]}-{data}-R${reader["SALARIOBRUTO"]}");
            }
        }
        public void PopularDataGrip(double salario, double inss, double irrf, double diferencaDias)
        {   gridCalc.Rows.Clear();
            gridTotal.Rows.Clear();
            double salarioDiv = salario / 30;
            double salarioCompleto = salarioDiv * diferencaDias;
            gridCalc.Rows.Add("DIAS TRABALHADOS", diferencaDias, salarioCompleto, "");
            gridCalc.Rows.Add("DESCONTO DE INSS", "", "", inss.ToString("0.00"));
            gridCalc.Rows.Add("DESCONTO DE I.R.F", "", "", irrf.ToString("0.00"));
            gridCalc.Rows.Add("", "", "", "");
            gridCalc.Rows.Add("", "", "", "");
            gridCalc.Rows.Add("", "", "", "");
            gridTotal.Rows.Add("Salário", 0, salario, salario, inss, (salarioCompleto - inss - irrf).ToString("0.00"));
            gridTotal.Rows.Add("", "", "", "", "", "");

        }

        private void comboNomeFunc_SelectedIndexChanged(object sender, EventArgs e)
        {
            var funcionarioSelecionado = comboNomeFunc.SelectedItem.ToString().Split("-");
            var idfuncionario = funcionarioSelecionado[0];
            var datas = funcionarioSelecionado[1].Replace("/", "-").Split("-");
            string data = $"{datas[2]}-{datas[1]}-{datas[0]}";
            
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM FOLHA where IDFUNCIONARIO = @IDFUNCIONARIO AND DATA_GERADO = @DATA", db.connect());
            sqlCommand.Parameters.AddWithValue("@IDFUNCIONARIO", idfuncionario);
            sqlCommand.Parameters.AddWithValue("@DATA", data);

            MySqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                PopularDataGrip(double.Parse(reader["SALARIOBRUTO"].ToString()), double.Parse(reader["INSS"].ToString()), double.Parse(reader["IRRF"].ToString()), double.Parse(reader["DIAS_TRABALHADOS"].ToString())); ;
            }
        }
    }
}
