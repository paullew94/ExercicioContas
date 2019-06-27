DROP TABLE IF EXISTS contas_pagar;
CREATE TABLE contas_pagar(
id INT PRIMARY KEY IDENTITY(1,1),
nome VARCHAR(100),
valor DECIMAL(5,2),
tipo VARCHAR(100),
data_vencimento DATETIME2
);