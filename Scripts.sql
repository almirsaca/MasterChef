use MasterChef
Go

if not exists (select 1 from information_schema.tables where table_name='ReceitaPrepraro') 
begin
	create table dbo.StatusItem
	(
		StatusItemID int not null,
		Descricao varchar(80),
		constraint PK_StatusItem_StatusItemID primary key (StatusItemID)
	)

	insert dbo.StatusItem(StatusItemID, Descricao) values(1, 'Ativo'), (2, 'Inativo')
end


if not exists (select 1 from information_schema.tables where table_name='ReceitaCategoria') 
begin
	create table dbo.ReceitaCategoria
	 (
		ReceitaCategoriaID int not null identity,
		Descricao varchar(256),
		DataCadastro datetime,
		StatusItemID int,
		constraint PK_ReceitaCategoria_ReceitaCategoriaID primary key (ReceitaCategoriaID),
		constraint FK_ReceitaCategoria_StatusItemID foreign key (StatusItemID) references dbo.StatusItem(StatusItemID)
	)

	insert dbo.ReceitaCategoria(Descricao, DataCadastro, StatusItemID) values('Carnes',getdate(), 1), ('Frango',getdate(), 1), ('Peixes',getdate(), 1)

	select * from dbo.ReceitaCategoria

end;

if not exists (select 1 from information_schema.tables where table_name='ReceitaAutor') 
begin

	-- https://menutrip.com.br/blog/melhores-chefs-brasil/

	create table dbo.ReceitaAutor
	(
		ReceitaAutorID int not null identity,
		Nome varchar(256),
		StatusItemID int,
		constraint PK_ReceitaAutor_ReceitaAutorID primary key (ReceitaAutorID),
		constraint FK_ReceitaAutor_StatusItemID foreign key (StatusItemID) references dbo.StatusItem(StatusItemID)
	)

	insert dbo.ReceitaAutor(Nome, StatusItemID) values('Alex Atala', 1), ('Helena Rizzo', 1), ('Rodrigo Oliveira', 1), ('Roberta Sudbrack', 1), ('Paola Carosella', 1)

	select * from dbo.ReceitaAutor

end

if not exists (select 1 from information_schema.tables where table_name='Receita') 
begin

	-- http://revistamarieclaire.globo.com/Lifestyle/Receitas/noticia/2017/07/lasanha-de-chef-faca-em-casa-receita-de-alex-atala.html

	create table dbo.Receita
	(
		ReceitaID int not null identity,
		ReceitaCategoriaID int,
		ReceitaAutorID int,
		Titulo varchar(256),
		StatusItemID int,
		constraint PK_Receita_ReceitaID primary key (ReceitaID),
		constraint FK_Receita_ReceitaCategoriaID foreign key (ReceitaCategoriaID) references dbo.ReceitaCategoria(ReceitaCategoriaID),
		constraint FK_Receita_ReceitaAutorID foreign key (ReceitaAutorID) references dbo.ReceitaAutor(ReceitaAutorID),
		constraint FK_Receita_StatusItemID foreign key (StatusItemID) references dbo.StatusItem(StatusItemID)
	)

	insert dbo.Receita(ReceitaCategoriaID, ReceitaAutorID, Titulo, StatusItemID) values(1, 1, 'Lasanha de chef', 1)

	select * from dbo.Receita

end

if not exists (select 1 from information_schema.tables where table_name='ReceitaIngrediente') 
begin
	create table dbo.ReceitaIngrediente
	(
		ReceitaIngredienteID int not null identity,
		ReceitaID int,
		Quantidade varchar(80),
		Item varchar(256),
		StatusItemID int,
		constraint PK_ReceitaIngrediente_ReceitaIngredienteID primary key (ReceitaIngredienteID),
		constraint FK_ReceitaIngrediente_ReceitaID foreign key (ReceitaID) references dbo.Receita(ReceitaID),
		constraint FK_ReceitaIngrediente_StatusItemID foreign key (StatusItemID) references dbo.StatusItem(StatusItemID)
	)

	insert dbo.ReceitaIngrediente(ReceitaID, Quantidade, Item, StatusItemID) values(1, '10 unidades', 'Ovos', 1)

end

if not exists (select 1 from information_schema.tables where table_name='ReceitaPrepraro') 
begin
	create table dbo.ReceitaPrepraro
	(
		ReceitaPrepraroID int not null identity,
		ReceitaID int,
		ModoPreparo text,
		StatusItemID int,
		constraint PK_ReceitaPrepraro_ReceitaPrepraroID primary key (ReceitaPrepraroID),
		constraint FK_ReceitaPrepraro_ReceitaID foreign key (ReceitaID) references dbo.Receita(ReceitaID),
		constraint FK_ReceitaPrepraro_StatusItemID foreign key (StatusItemID) references dbo.StatusItem(StatusItemID)
	)
end
