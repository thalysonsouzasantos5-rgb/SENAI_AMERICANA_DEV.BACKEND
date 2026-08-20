using System;
using System.Collections.Generic;
using System.Text;

namespace Contrato
{
    internal class empresa
    {
		//Campos
        private string nome;
	    private Funcionarios = funcionarios;

		protected string NomeDaEmpresa
		{
			get { return nome; }
			set { nome = value; }
		}
		protected Funcionario funcionario
		{
			get { return funcionario; }
			set { funcionario = value; }
		}
		public List<Funcionarios> listaDeFuncionarios
		{
			get { return funcionario; }
			set { funcionarios = value; }
		}
		//Construtor
		public empresa(string nomeDaEmpresa, string nomeFuncionario)
		{
			NomeDaEmpresa = nomeDaEmpresa;
			Funcionario = new Funcionarios(nomeFuncionario);
		}
		//Métodos
		public void RegistrarContratoFuncinario(double valor, int horas)
		{
			Funcionarios.Adiciona
		}
	}
}
