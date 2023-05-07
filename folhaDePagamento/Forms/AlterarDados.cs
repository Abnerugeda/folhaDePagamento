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
using System.Windows;
using System.Windows.Forms;

namespace folhaDePagamento.Forms
{
    public partial class AlterarDados : Form
    {
        private string nome;
        private string email;
        private string cpf;
        private string tel;
        private string data;
        private string rg;
        private string logradouro;
        private string numero;
        private string bairro;
        private string cep;
        private string municipio;
        private string uf;
        private string complemento;
        private string numeroRes;
        private string genero;
        private string estadoCivil;
        private string nivelAcess;
        private string pis;
        private string dataAdmissao;
        private string salario;
        private string ddd;
        

        public AlterarDados()
        {
            InitializeComponent();
            setDataEndereco(11);
            setDataFuncionario(11);
            setDataSalario(11);
            setAllData();

        }

       private void setDataFuncionario(int id)
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "SELECT * FROM funcionario where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while(reader.Read())
            {
                nome = reader["NOME"].ToString();
                email = reader["EMAIL"].ToString();
                cpf = reader["CPF"].ToString();
                data = reader["DATA_NASCI"].ToString();
                rg = reader["RG"].ToString();
                genero = reader["GENERO"].ToString();
                estadoCivil = reader["ESTADO_CIVIL"].ToString();
                nivelAcess = reader["NIVELACESSO"].ToString();
                pis = reader["PIS"].ToString();
                dataAdmissao = reader["DATA_ADMISSAO"].ToString();
            }
        }

        private void setDataSalario(int id)
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "SELECT * FROM salario where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                salario = reader["SALARIO"].ToString();
            }
        }
        private void setDataEndereco(int id)
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "SELECT * FROM ENDERECO where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                
                uf = reader["UF"].ToString();
                logradouro = reader["LOGRADOURO"].ToString();
                numero = reader["NUMERO"].ToString();
                bairro = reader["BAIRRO"].ToString();
                cep = reader["CEP"].ToString();
                municipio = reader["MUNICIPIO"].ToString();
                complemento = reader["COMPLEMENTO"].ToString();
           
            }
        }

        private void setAllData()
        {
            boxNome.Text = nome;
            boxEmail.Text = email;
            boxCpf.Text = cpf;
            boxTel.Text = tel;
            boxDataNasc.Text = data;
            boxRg.Text = rg;
            boxLogradouro.Text = logradouro;
            boxNumero.Text = numero;
            boxBairro.Text = bairro;
            boxCep.Text = cep;
            boxMunicipio.Text = municipio;
            boxUf.Text = uf;
            boxComplemento.Text = complemento;
            boxTelefoneRes.Text = numeroRes;
            boxGenero.Text = genero;
            boxEstadoCivil.Text = estadoCivil;
            boxNivelAcess.Text = nivelAcess;
            boxPis.Text = pis;
            boxDataAdmissao.Text = dataAdmissao;
            boxSalario.Text = salario;
            boxDDD.Text = ddd;

            System.Windows.Forms.MessageBox.Show(logradouro);
        }
        //private void setDataTel(int id)
        //{
        //    ConnectDatabase db = new ConnectDatabase();
        //    MySqlCommand comm = db.connect().CreateCommand();
        //    comm.CommandText = "SELECT * FROM TELEFONE where IDFUNCIONARIO = @IDFUNCIONARIO;";
        //    comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
        //    MySqlDataReader reader = comm.ExecuteReader();

        //    while (reader.Read())
        //    {

        //    }
        //}
        public void callSet(int id)
        {
            setDataEndereco(id);
            setDataFuncionario(id);
            setDataSalario(id);
            //setDataTel(id);
        }
    }
}
