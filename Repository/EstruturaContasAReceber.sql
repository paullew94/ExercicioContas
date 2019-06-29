DROP TABLE IF EXISTS  contas_receber
CREATE TABLE contas_receber(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
valor DECIMAL(5,2),
valor_recebido DECIMAL (5,2),
data_recebimento DATETIME2,
recebido BIT
);