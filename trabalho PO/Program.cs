using System;
using Figgle;

namespace CaioSilveira
{
    class Program
    {
        static void Main(string[] args)
        {
	    int i ;
            string opcao = "";
	    Professor professor = new Professor();
            Displinas disciplinas = new Disciplina();

            Console.WriteLine(FiggleFonts.Standard.Render("Escola Caio Silveira"));
            do
            {
                Console.WriteLine("1  - Cadastrar Professor");
                Console.WriteLine("2  - Cadastrar Disciplina");
		Console.WriteLine("3  - Mostrar Disciplinas Do professor");
		Console.WriteLine("4  - Mostrar Todos os Professores");
		Console.WriteLine("5  - Mostrar Todas Disciplinas");
                Console.WriteLine("6 - Sair");

                opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                    {
                        Console.Write("Digite um código para o Professor: ");
                        professor.CodProf= int.Parse(Console.ReadLine());
                        
			Console.Write("Digite o nome do Professor: ");
                        
			professor.Nome = Console.ReadLine();
                        
			Console.Write("Digite o Cpf Do Professor: ");
			professor.cpf = Consele.Readline();
                        

                        arrayProfessor[contProf] = new Professor(Codprof,Nome,cpf);
                        contProf++;
                        break;
                    }
                    case "2":
                    {
			console.Write("Digite Digite O Nome Da Disciplina: ");
                        disciplina.nomeDisplina = int.Parse(Console.ReadLine());
                        
			Console.Write("Digite a carga horaria: ");
                        disciplina.cargaHoraria; = Console.ReadLine();
                        
			Console.Write("Digite o Codigo do Professor Responsavel: ");
			 disciplina.Codprof; = Console.ReadLine();

                        arrayDisciplinas[contDisciplinas] =new Displina(nomeDisciplina,cargaHoraria,Codprof);
                        ContDisciplinas++;
                        break;
                                }

		case "3":
                    {
			if (contProf>0){

				Console.WriteLine("------------------------------------------");
                                Console.WriteLine("---------- Lista Dos Professores ----------");
                                Console.WriteLine("------------------------------------------");

                                        for(int i = 0; i < contProf; i++)
                                        {
                                            Console.WriteLine(arrayProfessor[i].DadosProfessores());
                                        }
					
                                    Consele.WriteLine("Digite o Cod Do Professor Desejado")
					 string CodProfessor= Console.ReadLine();
				
				for(int i = 0; i < contProf; i++)
                                        {
                                            if(arrayProfessor[i].codProf == CodProfessor )
                                            {
 						for(int i = 0; i < ContDisciplinas; i++)
                                        	{
                                            		Console.WriteLine(arrayDisciplinas[i].DadosDisciplinas());
                                        	}
					     }
                                    
					} 
				}
		 }
		case "4":
                    {	
			if (contProf>0){

				Console.WriteLine("------------------------------------------");
                                Console.WriteLine("---------- Lista Dos Professores ----------");
                                Console.WriteLine("------------------------------------------");

                                        for(int i = 0; i < contProf; i++)
                                        {
                                            Console.WriteLine(arrayProfessor[i].DadosProfessores());
                                        }

                                        break;
                                    } 

			
			else{
				Consele.WriteLine("Nenhum Professor Cadastrado)
				
			}
		}
	
		
		case "5":
                   if (ContDisciplinas>0){

				Console.WriteLine("------------------------------------------");
                                Console.WriteLine("---------- Lista Das Disciplinas ----------");
                                Console.WriteLine("------------------------------------------");

                                        for(int i = 0; i < ContDisciplinas; i++)
                                        {
                                            Console.WriteLine(arrayDisciplinas[i].DadosDisciplinas());
                                        }

                                        break;
                                    } 

			
			else{
				Consele.WriteLine("Nenhuma Disciplina Cadastrada)
				
			}
		}

		case "6"{
			break;
		}

		


            }while(opcao != "6");
        }
    }
}
