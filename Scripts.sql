create table dbo.ReceitaCategoria
 (
	ReceitaCategoriaID int not null identity,
	Descricao varchar(256),
	DataCadastro datetime,
	constraint PK_ReceitaCategoria_ReceitaCategoriaID primary key (ReceitaCategoriaID)
)

create table dbo.ReceitaAutor
(
	ReceitaAutorID int not null identity,
	Nome varchar(256),
	constraint PK_ReceitaAutor_ReceitaAutorID primary key (ReceitaAutorID)
)

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

create table dbo.ReceitaIngrediente
(
	ReceitaIngredienteID int not null identity,
	ReceitaID int,
	Quantidade float,
	Item varchar(256),
	constraint PK_ReceitaIngrediente_ReceitaIngredienteID primary key (ReceitaIngredienteID),
	constraint FK_ReceitaIngrediente_ReceitaID foreign key (ReceitaID) references dbo.Receita(ReceitaID)
)

create table dbo.ReceitaPrepraro
(
	ReceitaPrepraroID int not null identity,
	ReceitaID int,
	ModoPreparo text,
	constraint PK_ReceitaPrepraro_ReceitaPrepraroID primary key (ReceitaPrepraroID),
	constraint FK_ReceitaPrepraro_ReceitaID foreign key (ReceitaID) references dbo.Receita(ReceitaID)
)


