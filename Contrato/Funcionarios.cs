using Contrato.Contrato;

namespace Contrato
{
    internal class Funcionarios
    {
        private string nome;
        private int List<HoraContrato> Contratos;

        //Propiedades
        protected string Nome
        {
            get { return contratos; }
            set { Contrato = value; }

        }
        //Construtor
        public Funcionarios(string nome)
        {
            Nome = nome;
        }
        //Métodos
        public void Adicionar(double valor , int horas)
        {
            HoraContrato contrato = HoraContrato(horas , valor);
            Contratos.Add(contrato);
        }
    }
}
