CREATE TABLE [dbo].[TB_Tarefas] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Titulo]        VARCHAR (200) NULL,
    [DataCriacao]   DATETIME      NULL,
    [DataConclusao] DATETIME      NULL,
    [Percentual]    INT           NULL,
    [Prioridade]    VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

