DROP TABLE contasReceber
CREATE TABLE contasReceber(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
valor DECIMAL(5,2),
tipo VARCHAR(100),
data_vencimento DATE
);