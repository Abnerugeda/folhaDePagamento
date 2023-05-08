using folhaDePagamento.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private string telRes;
        private string cargo;
        private int id;

        public AlterarDados(int id)
        {
            InitializeComponent();
            this.id = id;
            setDataEndereco(id);
            setDataFuncionario(id);
            setDataSalario(id);
            setDataTel(id);
            setDataTelRes(id);
            setAllData();

        }

        private void setDataFuncionario(int id)
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "SELECT * FROM funcionario where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
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
            comm.CommandText = "SELECT * FROM CONTRATO where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                salario = reader["SALARIOBRUTO"].ToString();
                cargo = reader["CARGO"].ToString();
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
            boxTelefoneRes.Text = telRes;
            boxCargo.Text = cargo;

        }
        private void setDataTel(int id)
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "SELECT * FROM TELEFONECELULAR where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                tel = reader["NUMERO"].ToString();
                ddd = reader["DDD"].ToString();
            }
        }
        private void setDataTelRes(int id)
        {
            ConnectDatabase db = new ConnectDatabase();
            MySqlCommand comm = db.connect().CreateCommand();
            comm.CommandText = "SELECT * FROM TELEFONERESIDENCIAL where IDFUNCIONARIO = @IDFUNCIONARIO;";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", id);
            MySqlDataReader reader = comm.ExecuteReader();

            while (reader.Read())
            {
                telRes = reader["NUMERO"].ToString();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            updateFuncionario();
        }

        private void updateFuncionario()
        {
            try
            {
                Func<string, string> removeCaracteres = (string str) =>
                {
                    return str.Replace(",", "").Replace("-", "");
                };

                string dataOriginal = boxDataNasc.Text;
                string dataAdmissao = boxDataAdmissao.Text;
                DateTime dataAdmissaoF = DateTime.ParseExact(dataAdmissao, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dataAdmissaoFormatada = dataAdmissaoF.ToString("yyyy-MM-dd");
                DateTime data = DateTime.ParseExact(dataOriginal, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string dataFormatada = data.ToString("yyyy-MM-dd");

                string dddFormatado = boxDDD.Text.Replace("(", "").Replace(")", "");
                Func<string, string> removeCaracteresNumero = (string str) =>
                {

                    return str.Replace("-", "");

                };

                string cpf = removeCaracteres(boxCpf.Text);
                string rg = removeCaracteres(boxRg.Text);
                string numeroRes = removeCaracteresNumero(boxTelefoneRes.Text);
                string telCelular = removeCaracteresNumero(boxTel.Text);
                string cep = removeCaracteres(boxCep.Text);
                string genero;
                if (boxGenero.Text.ToLower() == "masculino".ToLower())
                {
                    genero = "M";
                }
                else
                {
                    genero = "F";
                }

                ConnectDatabase db = new ConnectDatabase();
                MySqlCommand comm = db.connect().CreateCommand();
                comm.CommandText = "UPDATE funcionario SET NOME = @NOME, EMAIL = @EMAIL, CPF = @CPF, RG = @RG, NIVELACESSO = @NIVELACESSO, GENERO = @GENERO, DATA_NASCI = @DATA_NASCI, ESTADO_CIVIL = @ESTADO_CIVIL, DATA_ADMISSAO = @DATA_ADMISSAO, PIS = @PIS WHERE IDFUNCIONARIO = @ID;";
                comm.Parameters.AddWithValue("@NOME", boxNome.Text);
                comm.Parameters.AddWithValue("@EMAIL", boxEmail.Text);
                comm.Parameters.AddWithValue("@CPF", cpf);
                comm.Parameters.AddWithValue("@RG", rg);
                comm.Parameters.AddWithValue("@NIVELACESSO", boxNivelAcess.Text);
                comm.Parameters.AddWithValue("@GENERO", boxGenero.Text);
                comm.Parameters.AddWithValue("@DATA_NASCI", dataFormatada);
                comm.Parameters.AddWithValue("@PIS", boxPis.Text);
                comm.Parameters.AddWithValue("@DATA_ADMISSAO", dataAdmissaoFormatada);
                comm.Parameters.AddWithValue("@ESTADO_CIVIL", boxEstadoCivil.Text);
                comm.Parameters.AddWithValue("@ID", id);
                comm.ExecuteNonQuery();


                comm.CommandText = "UPDATE telefoneCelular SET DDD = @DDD, NUMERO = @NUMERO1 WHERE IDFUNCIONARIO = @ID1;";
                comm.Parameters.AddWithValue("@ID1", id);
                comm.Parameters.AddWithValue("@DDD", dddFormatado);
                comm.Parameters.AddWithValue("@NUMERO1", telCelular);
                comm.ExecuteNonQuery();

                comm.CommandText = "UPDATE telefoneResidencial SET NUMERO = @NUMERO2 WHERE IDFUNCIONARIO = @ID2;";
                comm.Parameters.AddWithValue("@ID2", id);
                comm.Parameters.AddWithValue("@NUMERO2", numeroRes);
                comm.ExecuteNonQuery();

                comm.CommandText = "UPDATE CONTRATO SET SALARIOBRUTO = @SALARIO, CARGO = @CARGO WHERE IDFUNCIONARIO = @ID3;";
                comm.Parameters.AddWithValue("@ID3", id);
                comm.Parameters.AddWithValue("@SALARIO", double.Parse(boxSalario.Text));
                comm.Parameters.AddWithValue("@CARGO", boxCargo.Text);
                comm.ExecuteNonQuery();

                this.Close();

            }
            catch (Exception e)
            {
                System.Windows.MessageBox.Show($"Ocorreu um erro, tente novamente {e}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarDados_Load(object sender, EventArgs e)
        {

        }
    }
}
