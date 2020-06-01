using System;
namespace CaioSilveira
{
    public class Professores
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome;
            }
        }
        private string cpf;
        public string Cpf
        {
            get
            {
                return this.cpf;
            }
        }

	private string CodProf;
        public string CodProf;
        {
            get
            {
                return this.CodProf
            }
        }

	 public Professores(string nome, string cpf,CodProf)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.CodProf=CodProf;
        }

        public string DadosProfessores()
        {
            return $"Nome: {this.nome}. CPF: {this.cpf} . CodProf: {CodProf}.";
        }


    }


}