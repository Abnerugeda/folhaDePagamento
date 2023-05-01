﻿using folhaDePagamento.services;
using Org.BouncyCastle.Crypto.Tls;
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
    public partial class AdicionarFuncionario : Form
    {
        
        public AdicionarFuncionario()
        {
            InitializeComponent();
            ControlBox = false;
            
        }

        private void boxCpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (
                    boxCpf.Text         != null ||
                    boxBairro.Text      != null ||
                    boxCep.Text         != null ||
                    boxDataNasc.Text    != null ||
                    boxEmail.Text       != null ||
                    boxEstadoCivil.Text != null ||
                    boxGenero.Text      != null ||
                    boxId.Text          != null ||
                    boxLogradouro.Text  != null ||
                    boxNivelAcess.Text  != null ||
                    boxRg.Text          != null ||
                    boxMunicipio.Text   != null ||
                    boxTel.Text         != null ||
                    boxUf.Text          != null ||
                    boxNumero.Text      != null
                    )
                {
                    Func<string, string> removeCaracteres = (string str) =>
                    {
                        return str.Replace(",", "").Replace("-", "");
                    };

                    string dataOriginal = boxDataNasc.Text;
                    DateTime dataAtual = DateTime.Now;
                    int dia = dataAtual.Day;
                    int mes = dataAtual.Month;
                    int ano = dataAtual.Year;
                    string DataAdmissao = $"{ano}-{mes}-{dia}";
                    DateTime data = DateTime.ParseExact(dataOriginal, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    string dataFormatada = data.ToString("yyyy-MM-dd");

                    Func<string, string> removeCaracteresNumero = (string str) =>
                    {

                        return str.Replace("-", "");

                    };

                    string cpf = removeCaracteres(boxCpf.Text);
                    string rg = removeCaracteres(boxRg.Text);
                    string numeroRes = removeCaracteresNumero(boxTelefoneRes.Text);
                    string tel = removeCaracteresNumero(boxTel.Text);
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

                    ConnectDatabase connect = new ConnectDatabase();
                    connect.insertDataFunc(
                        boxNome.Text,
                        boxId.Text,
                        boxEmail.Text,
                        cpf,
                        tel,
                        dataFormatada,
                        rg,
                        boxLogradouro.Text,
                        boxNumero.Text,
                        boxBairro.Text,
                        cep,
                        boxMunicipio.Text,
                        boxUf.Text,
                        boxComplemento.Text,
                        numeroRes,
                        genero,
                        boxEstadoCivil.Text,
                        boxNivelAcess.Text,
                        boxPis.Text,
                        DataAdmissao
                        );
                    FormFuncionarios form = new FormFuncionarios();
                    form.Refresh();
                    this.Close();
                }
                else
                { 
                    System.Windows.MessageBox.Show("Você deixou algum campo vazio, por favor, revise o cadastro e tente novamente.", "Erro!");
                }
               
            }catch(Exception ex)
            {
                System.Windows.MessageBox.Show($"Ocorreu um erro, revise o seu cadastro e tente novamente. Certifique-se que não há nenhum campo vazio. {ex}", "Erro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}