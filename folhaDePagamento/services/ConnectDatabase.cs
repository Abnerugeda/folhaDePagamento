﻿using folhaDePagamento.controller;
using folhaDePagamento.Forms;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace folhaDePagamento.services
{
    internal class ConnectDatabase
    {
        public List<string>funcionariosNome;
        public MySqlConnection connect()
        {
            try
            {
                string strConexao = "server=localhost;uid=root;pwd=123456;database=dbdepartamento";
                MySqlConnection conexao = new MySqlConnection(strConexao);
                conexao.Open();
                return conexao;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }


        public void insertDataFunc(
            string nome,
            string email,
            string cpf,
            string telefone,
            string data,
            string rg,
            string logradouro,
            string numero,
            string bairro,
            string cep,
            string municipio,
            string uf,
            string complemento,
            string telefoneRes,
            string genero,
            string estadoCivil,
            string nivelAcess,
            string pis,
            string dataAdmissao,
            string salario,
            string ddd,
            string cargo,
            string usuario,
            string senha
            )
        {
            try
            {

                MySqlCommand comm = connect().CreateCommand();
                comm.CommandText = $"INSERT INTO funcionario VALUES(DEFAULT, @NOME, @CPF, @RG, @PIS, @GENERO, @DATA_NASCI, @ESTADO_CIVIL, @EMAIL, @ATIVO, @DATA_ADMISSAO);";
                comm.Parameters.AddWithValue("@NOME", nome);
                comm.Parameters.AddWithValue("@CPF", cpf);
                comm.Parameters.AddWithValue("@RG", rg);
                comm.Parameters.AddWithValue("@PIS", pis);
                comm.Parameters.AddWithValue("@GENERO", genero);
                comm.Parameters.AddWithValue("@DATA_NASCI", data);
                comm.Parameters.AddWithValue("@ESTADO_CIVIL", estadoCivil);
                comm.Parameters.AddWithValue("@EMAIL", email);
                comm.Parameters.AddWithValue("@ATIVO", "1");
                comm.Parameters.AddWithValue("@DATA_ADMISSAO", dataAdmissao);
                comm.ExecuteNonQuery();
                insertSalario(salario, cpf, dataAdmissao, cargo);
                insertTelefoneCelular(ddd, telefone, cpf);
                if(telefoneRes != null)insertTelefoneResi(ddd, telefoneRes, cpf);
                insertEndereco(cep, logradouro, numero, uf, complemento, bairro, cpf, municipio);
                string hash = BCrypt.Net.BCrypt.HashPassword(senha);
                insertAcesso(nivelAcess, usuario, hash, cpf);

            }catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro na hora de cadastrar, revise as informações e tente novamente! {ex}");
            }
         
        }
        public void insertTelefoneCelular(string ddd, string telefone, string cpf)
        {
            MySqlCommand comm = connect().CreateCommand();
            comm.CommandText = "INSERT INTO telefoneCelular (IDFUNCIONARIO, DDD, NUMERO) VALUES (@IDFUNCIONARIO, @DDD, @NUMERO);";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", queryIdFunc(cpf));
            comm.Parameters.AddWithValue("@DDD", ddd);
            comm.Parameters.AddWithValue("@NUMERO", telefone);
            comm.ExecuteNonQuery();
        }
        public void insertTelefoneResi(string ddd, string telefone, string cpf)
        {
            MySqlCommand comm = connect().CreateCommand();
            comm.CommandText = "INSERT INTO telefoneResidencial (IDFUNCIONARIO, DDD, NUMERO) VALUES (@IDFUNCIONARIO, @DDD, @NUMERO);";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", queryIdFunc(cpf));
            comm.Parameters.AddWithValue("@DDD", ddd);
            comm.Parameters.AddWithValue("@NUMERO", telefone);
            comm.ExecuteNonQuery();
        }
        public void insertEndereco(string cep, string logradouro, string numero, string uf, string complemento, string bairro, string cpf, string municipio)
        {
            MySqlCommand comm = connect().CreateCommand();
            comm.CommandText = "INSERT INTO endereco (IDFUNCIONARIO, LOGRADOURO, NUMERO, CEP, UF, BAIRRO, COMPLEMENTO, MUNICIPIO) VALUES (@IDFUNCIONARIO, @LOGRADOURO, @NUMERO, @CEP, @UF, @BAIRRO, @COMPLEMENTO, @MUNICIPIO);";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", queryIdFunc(cpf));
            comm.Parameters.AddWithValue("@LOGRADOURO", logradouro);
            comm.Parameters.AddWithValue("@BAIRRO", bairro);
            comm.Parameters.AddWithValue("@NUMERO", numero);
            comm.Parameters.AddWithValue("@COMPLEMENTO", complemento);
            comm.Parameters.AddWithValue("@MUNICIPIO", municipio);
            comm.Parameters.AddWithValue("@UF", uf);
            comm.Parameters.AddWithValue("CEP", cep);
            comm.ExecuteNonQuery();
        }
        public void insertSalario(string salario, string cpf, string dataAdmissao, string cargo)
        {
            try
            {
                MySqlCommand comm = connect().CreateCommand();
                comm.CommandText = "INSERT INTO CONTRATO VALUES(DEFAULT, @IDFUNCIONARIO,  @DATA_SALARIO, @SALARIO, @CARGO);";
                comm.Parameters.AddWithValue("@IDFUNCIONARIO", queryIdFunc(cpf));
                comm.Parameters.AddWithValue("@SALARIO", salario);
                comm.Parameters.AddWithValue("@DATA_SALARIO", dataAdmissao);
                comm.Parameters.AddWithValue("@CARGO", cargo);
                comm.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show($"Ocorreu um erro, tente novamente. {e}");

            }
        }
        public void insertAcesso(string acesso, string usuario, string senha, string cpf)
        {
            MySqlCommand comm = connect().CreateCommand();
            comm.CommandText = "INSERT INTO ACESSO VALUES(DEFAULT, @acesso,  @login , @senha, @IDFUNCIONARIO);";
            comm.Parameters.AddWithValue("@IDFUNCIONARIO", queryIdFunc(cpf));
            comm.Parameters.AddWithValue("@acesso", acesso);
            comm.Parameters.AddWithValue("@login", usuario);
            comm.Parameters.AddWithValue("@senha", senha);
            comm.ExecuteNonQuery();
        }
        public string queryIdFunc(string cpf)
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM funcionario WHERE CPF = @CPF", connect());
            sqlCommand.Parameters.AddWithValue("@CPF", cpf);
            MySqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                return reader["IDFUNCIONARIO"].ToString();
                
            }
            return null;
        }
        public List<ListFuncionarios> queryFunc()
        {
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM funcionario, CONTRATO where CONTRATO.IDFUNCIONARIO = FUNCIONARIO.IDFUNCIONARIO", connect());
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                var listFuncionarios = new List<ListFuncionarios>();
                
                while (reader.Read())
                {
                    if (reader["ATIVO"].Equals(true))
                    {
                        listFuncionarios.Add(new ListFuncionarios(reader["IDFUNCIONARIO"].ToString(), reader["NOME"].ToString(), reader["CPF"].ToString(), reader["DATA_ADMISSAO"].ToString(), reader["SALARIOBRUTO"].ToString(), reader["CARGO"].ToString()));
                    }

                }
                return listFuncionarios;
             }catch(Exception ex)
            {
                Console.WriteLine("error ===> ", ex);
                return null;
            }
        }
        public void removeFunc(string id)
        {
            MySqlCommand comm = connect().CreateCommand();
            comm.CommandText = $"UPDATE funcionario set ATIVO = \"0\" WHERE IDFUNCIONARIO = @ATIVO";
            comm.Parameters.AddWithValue("@ATIVO", id);
            comm.ExecuteNonQuery();

        }
        public List<string> nomesFuncionarios()
        {
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM funcionario", connect());
                MySqlDataReader reader = sqlCommand.ExecuteReader();
                List<string> funcionarios = new List<string>();

                while (reader.Read())
                {
                    if (reader["ATIVO"].ToString() == "1")
                    {
                        funcionarios.Add(reader["NOME"].ToString());
                    }

                }
                return funcionarios;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error ===> ", ex);
                return null;
            }
        }

        public bool LoginAuth(string usuario, string senha)
        {
            try
            {
                MySqlCommand sqlCommand = new MySqlCommand("SELECT * FROM acesso", connect());
                MySqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(BCrypt.Net.BCrypt.Verify(senha, reader["SENHA"].ToString()).ToString());
                    if (reader["LOGIN"].ToString().ToLower() == usuario.ToLower() && BCrypt.Net.BCrypt.Verify(senha, reader["SENHA"].ToString()))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error ===> ", ex);
                return false;
            }
        }
    
    }
}
