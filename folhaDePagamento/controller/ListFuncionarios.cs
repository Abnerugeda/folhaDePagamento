using folhaDePagamento.services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folhaDePagamento.controller
{
    internal class ListFuncionarios
    {

        public string Id { get; set; }
        public string Nome { get; set; }
        public string NivelAcesso { get; set; }
        public string Cargo { get; set; }
        public string Cpf { get; set; }
        public string DataAdmissao { get; set; }

        public string Salario { get; set; }

        public ListFuncionarios(string id, string nome, string nivelAcesso, string cpf, string dataAdmissao, string salario, string cargo)
        {
            Id = id;
            Nome = nome;
            NivelAcesso = nivelAcesso;
            Cpf = cpf;
            DataAdmissao = dataAdmissao;
            Salario = salario;
            Cargo = cargo;
        }

        public static List<ListFuncionarios> GetListFuncionarios()
        {
            ConnectDatabase connect = new ConnectDatabase();
            var listFunc = connect.queryFunc();
            return listFunc;
        }
        
    }
}
