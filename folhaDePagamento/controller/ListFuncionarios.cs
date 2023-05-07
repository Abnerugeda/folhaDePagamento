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
        public string Cargo { get; set; }
        public string Cpf { get; set; }
        public string DataAdmissao { get; set; }

        public string Salario { get; set; }

        public ListFuncionarios(string id, string nome, string cargo, string cpf, string dataAdmissao, string salario)
        {
            Id = id;
            Nome = nome;
            Cargo = cargo;
            Cpf = cpf;
            DataAdmissao = dataAdmissao;
            Salario = salario;
        }

        public static List<ListFuncionarios> GetListFuncionarios()
        {
            ConnectDatabase connect = new ConnectDatabase();
            var listFunc = connect.queryFunc();
            return listFunc;
        }
        
    }
}
