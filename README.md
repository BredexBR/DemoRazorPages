# Iniciando ASP.NET Razor Pages
Este reposit�rio tem como objetivo servir como um ponto de partida para quem deseja aprender 
e aplicar os principais conceitos do ASP.NET Razor Pages. Ao longo deste projeto, vamos explorar 
como construir interfaces din�micas e interativas de forma simples e eficiente utilizando Razor 
Pages. Este modelo de programa��o em ASP.NET Core oferece uma abordagem mais direta e intuitiva para 
o desenvolvimento web, permitindo que voc� combine a l�gica de neg�cio e a interface em uma estrutura 
organizada. Com Razor Pages, voc� poder� criar p�ginas web robustas, de f�cil manuten��o, e altamente 
perform�ticas, tornando este reposit�rio uma excelente base para o desenvolvimento de aplica��es web 
modernas.

<br>

![Execu��o1](imgs/inicial.png)

<br>

## Criando uma Model Aluno
No projeto web app(Razor Pages) a pasta models n�o vem, ent�o: 
1. Sera necess�rio cria-la e adicionar o Aluno.cs(e o codigo) 
2. Na pasta Pages crie a pasta Alunos.
2. Clique com o bot�o direito do mouse na pasta "Alunos" -> add -> new scaffolded item... -> Razor 
Pages with views - using entity Framework.
3. Ap�s isso selecione a model criada(nesse exemplo Aluno.cs)
4. Utilize a data do projeto utilizado
5. Sera criado o "CRUD" de alunos na Pasta Alunos

## Configurando o banco de dados ap�s inclus�o da Model
- Sera necess�rio rodar no terminal(Package Manager Console) o comando 
para fazer as migra��es da model Aluno:
	```bash
	Add migration Aluno

- E posteriormente para atualizar o banco de dados:
	```bash
	update-database