using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaFuncionarios
{
    internal class Funcionarios
    {
		private int matriculaca;

		public int Matricula
		{
			get { return matriculaca; }
			set { matriculaca = value; }
		}

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private string endereco;

		public string Endereco
		{
			get { return endereco; }
			set { endereco = value; }
		}

		private string cidade;

		public string Cidade
		{
			get { return cidade; }
			set { cidade = value; }
		}

		//unidade federativa
		private string uf;

		public string Uf
		{
			get { return uf; }
			set { uf = value; }
		}

		private string cep;

		public string Cep
		{
			get { return cep; }
			set { cep = value; }
		}

		private string cpf;

		public string Cpf
		{
			get { return cpf; }
			set { cpf = value; }
		}

		private string telefone;

		public string Telefone
		{
			get { return telefone; }
			set { telefone = value; }
		}

		private string email;

		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		private DateTime datanasc;

		public DateTime DataNasc
		{
			get { return datanasc; }
			set { datanasc = value; }
		}

		public Funcionarios()
		{
			Matricula = 0;
			Nome = "";
			Endereco = "";
			Cidade = "";
			Uf = "";
			Cep = "";
			Cpf = "";
			Telefone = "";
			Email = "";
			DataNasc = DateTime.Now;
		}

        public override string ToString()
        {
			return "Funcionário:" +
				$"\nMatrícula: {Matricula}" +
				"\nNome: " + Nome +
				"\nEndereço: " + Endereco +
				"\nCidade: " + Cidade +
				"\nUF: " + Uf +
				"\nCEp: " + Cep +
				"\nCPF: " + Cpf +
				"\nTelefone: " + Telefone +
				"\nEmail: " + Email +
				"\nData de Nascimento: " +
				DataNasc.ToString("dd/MM/yyyy"); 
        }
	}
}
