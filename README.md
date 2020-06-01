# Sistema-Escolar-

Classe Pessoa:
• Todos os atributos devem ser privados
• O construtor deve possui como argumentos o nome e cpf
• O método GetPessoa() deve retornar o nome e o cpf da pessoa
------------------------------------------------------------------------------
Classe Professor:
• Todos os atributos devem ser privados
• O construtor deve possui como argumentos o nome, cpf e codProfessor
• O método GetProfessor() deve retornar os dados da pessoa (nome e cpf) e o
codProfessor
------------------------------------------------------------------------------
Classe Disciplina:
• Todos os atributos devem ser privados
• O construtor deve possui como argumentos o nomeDisciplina, cargaHoraria e
professor
• O método GetDisciplina() deve retornar os dados da disciplina (nomeDisciplina,
cargaHoraria e os dados do professor (GetProfessor()))
------------------------------------------------------------------------------
Classe Funcoes:
• O método ListarProfessores deve percorrer o vetor de professores e executar o
método GetProfessor() mostrando os professores cadastrados
• O método ListarDisciplinas deve percorrer o vetor de disciplinas e executar o método
GetDisciplina() mostrando as disciplinas cadastradas
• O método BuscarProfessor deve buscar um professor no vetor de professores que
corresponda ao código informado (codProfessor) e retornar um objeto Professor
• O método ListarDisciplinasProfessor deve mostrar as disciplinas em que o professor
corresponda ao codProfessor e mostrar as disciplinas utilizando o método
GetDisciplina()
A classe deve importar o namespace System para que seja possível utilizar o método
Console.WriteLine();

------------------------------------------------------------------------------
Classe Program:
Criar um programa para que sejam contempladas as seguintes funcionalidades:
1. Cadastrar professores
2. Cadastrar disciplinas: Para incluir o professor deve listar todos os professores e
escolher um professor pelo codProfessor
3. Mostrar disciplinas do professor: Mostrar todos os professores cadastrados, escolher
um professor pelo codProfessor e listar as disciplinas vinculadas ao professor
selecionado
4. Mostrar todos os professores cadastrados
5. Mostrar todas as disciplinas cadastradas
