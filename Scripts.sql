if not exists (select 1 from information_schema.tables where table_name='ReceitaCategoria') 
begin
	create table dbo.ReceitaCategoria
	 (
		ReceitaCategoriaID int not null identity,
		Descricao varchar(256),
		DataCadastro datetime,
		constraint PK_ReceitaCategoria_ReceitaCategoriaID primary key (ReceitaCategoriaID)
	)

	insert dbo.ReceitaCategoria(Descricao,DataCadastro) values('Carnes',getdate()), ('Frango',getdate()), ('Peixes',getdate())

	select * from dbo.ReceitaCategoria

end;

if not exists (select 1 from information_schema.tables where table_name='ReceitaAutor') 
begin

	// https://menutrip.com.br/blog/melhores-chefs-brasil/

	create table dbo.ReceitaAutor
	(
		ReceitaAutorID int not null identity,
		Nome varchar(256),
		constraint PK_ReceitaAutor_ReceitaAutorID primary key (ReceitaAutorID)
	)

	insert dbo.ReceitaAutor(Nome) values('Alex Atala'), ('Helena Rizzo'), ('Rodrigo Oliveira'), ('Roberta Sudbrack'), ('Paola Carosella')

	select * from dbo.ReceitaAutor

end

if not exists (select 1 from information_schema.tables where table_name='Receita') 
begin

	// http://revistamarieclaire.globo.com/Lifestyle/Receitas/noticia/2017/07/lasanha-de-chef-faca-em-casa-receita-de-alex-atala.html

	create table dbo.Receita
	(
		ReceitaID int not null identity,
		ReceitaCategoriaID int,
		ReceitaAutorID int,
		Titulo varchar(256),
		constraint PK_Receita_ReceitaID primary key (ReceitaID),
		constraint FK_Receita_ReceitaCategoriaID foreign key (ReceitaCategoriaID) references dbo.ReceitaCategoria(ReceitaCategoriaID),
		constraint FK_Receita_ReceitaAutorID foreign key (ReceitaAutorID) references dbo.ReceitaAutor(ReceitaAutorID)
	)

	-- insert dbo.Receita(ReceitaCategoriaID,ReceitaAutorID,Titulo) values(1,1,'Lasanha de chef')

	select * from dbo.Receita

end

if not exists (select 1 from information_schema.tables where table_name='ReceitaIngrediente') 
begin
	create table dbo.ReceitaIngrediente
	(
		ReceitaIngredienteID int not null identity,
		ReceitaID int,
		Quantidade float,
		Item varchar(256),
		constraint PK_ReceitaIngrediente_ReceitaIngredienteID primary key (ReceitaIngredienteID),
		constraint FK_ReceitaIngrediente_ReceitaID foreign key (ReceitaID) references dbo.Receita(ReceitaID)
	)

	insert dbo.ReceitaIngrediente(ReceitaID,Quantidade,Item) values(1,)

end

if not exists (select 1 from information_schema.tables where table_name='ReceitaPrepraro') 
begin
	create table dbo.ReceitaPrepraro
	(
		ReceitaPrepraroID int not null identity,
		ReceitaID int,
		ModoPreparo text,
		constraint PK_ReceitaPrepraro_ReceitaPrepraroID primary key (ReceitaPrepraroID),
		constraint FK_ReceitaPrepraro_ReceitaID foreign key (ReceitaID) references dbo.Receita(ReceitaID)
	)
end
