CREATE TABLE contas_receber(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
valor DECIMAL(5,2),
valor_recebido DECIMAL (5,2),
recebido BIT
);