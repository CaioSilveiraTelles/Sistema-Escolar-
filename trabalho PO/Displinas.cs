using System;
namespace CaioSilveira
{
    public class Disciplinas
    {
        private string nomeDisplina;
        public string nomeDisplina;
        {
            get
            {
                return this.nomeDisplina;
            }
        }
        private int cargaHoraria;
        public int cargaHoraria
        {
            get
            {
                return this.cargaHoraria;
            }
        }
	
	private string cargaHoraria;
        public string cargaHoraria
        {
            get
            {
                return this.cargaHoraria;
            }
        }
        
        
        public Disciplina(string nomeDisplina, int cargaHoraria,CodProf)
        {
            this.nomeDisplina = nomeDisplina ;
            this.cargaHoraria= cargaHoraria;
            this.CodProf = CodProf;
        }

        public string DadosDisciplinas()
        {
            return $"nomeDisplina: {this.nomeDisplina}. cargaHoraria: {this.cargaHoraria} . CodProf: {CodProf}.";
        }
    }
}