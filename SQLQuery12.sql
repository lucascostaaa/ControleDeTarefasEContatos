SELECT * FROM TB_Contatos

INSERT INTO TB_Contatos
(
	Nome,
	Email,
	Telefone
)
values
(
	'Joao Pedro',
	'lucassilvacosta72@gmail.com',
	'049988643136'
)
ALTER TABLE TB_Contatos ADD Empresa VARCHAR(200)

ALTER TABLE TB_Contatos ADD Cargo VARCHAR(200)

UPDATE TB_Tarefas

            SET
            [TITULO] = 'teste editar', 
		    [DATACONCLUSAO] = '06/05/2021',
		    [PERCENTUAL] = 90,
		    [PRIORIDADE] = 'normal'

            WHERE
                [ID] = 10;
