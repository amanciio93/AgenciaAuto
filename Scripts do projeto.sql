CREATE DATABASE AgenciaAutomotivaBD;

USE AgenciaAutomotivaBD;

CREATE TABLE Veiculos (
	id INT IDENTITY(1,1) PRIMARY KEY,
	marca VARCHAR(50) NOT NULL,
	modelo VARCHAR(50) NOT NULL,
	ano INT NOT NULL,
	cor VARCHAR (50) NOT NULL,
	fabricacao DATE NOT NULL,
	combustivel VARCHAR(20) NOT NULL,
	automatico BIT NOT NULL,
	valor DECIMAL(18,2) NOT NULL,
	ativo BIT NOT NULL
);

INSERT INTO Veiculos (Marca, Modelo, Ano, Cor, Fabricacao, Combustivel, Automatico, Valor, Ativo)
VALUES
('Toyota', 'Corolla', 2022, 'Preto', '2021-11-10', 'Gasolina', 1, 125000.00, 1),
('Honda', 'Civic', 2021, 'Branco', '2020-10-05', 'Flex', 1, 118000.00, 1),
('Ford', 'Focus', 2020, 'Cinza', '2019-09-12', 'Gasolina', 1, 95000.00, 1),
('Volkswagen', 'Golf', 2019, 'Azul', '2018-07-20', 'Flex', 1, 89000.00, 1),
('Chevrolet', 'Onix', 2023, 'Vermelho', '2022-08-25', 'Flex', 0, 78000.00, 1),
('Hyundai', 'HB20', 2022, 'Prata', '2021-05-10', 'Gasolina', 0, 73000.00, 1),
('Renault', 'Kwid', 2021, 'Branco', '2020-12-15', 'Flex', 0, 56000.00, 1),
('Fiat', 'Toro', 2023, 'Preto', '2022-02-20', 'Diesel', 1, 155000.00, 1),
('Jeep', 'Renegade', 2022, 'Cinza', '2021-03-18', 'Flex', 1, 129000.00, 1),
('Nissan', 'Kicks', 2021, 'Azul', '2020-09-30', 'Flex', 1, 99000.00, 1),
('Toyota', 'Hilux', 2023, 'Branco', '2022-01-25', 'Diesel', 1, 250000.00, 1),
('Honda', 'HR-V', 2020, 'Vermelho', '2019-06-11', 'Flex', 1, 110000.00, 1),
('Ford', 'Ecosport', 2019, 'Prata', '2018-10-14', 'Flex', 0, 78000.00, 1),
('Chevrolet', 'S10', 2023, 'Preto', '2022-04-10', 'Diesel', 1, 230000.00, 1),
('Volkswagen', 'T-Cross', 2022, 'Cinza', '2021-07-09', 'Flex', 1, 140000.00, 1),
('Hyundai', 'Creta', 2021, 'Branco', '2020-05-06', 'Flex', 1, 118000.00, 1),
('Renault', 'Duster', 2023, 'Preto', '2022-02-12', 'Flex', 1, 112000.00, 1),
('Fiat', 'Argo', 2022, 'Vermelho', '2021-09-20', 'Flex', 0, 72000.00, 1),
('Jeep', 'Compass', 2023, 'Branco', '2022-06-30', 'Diesel', 1, 195000.00, 1),
('Nissan', 'Versa', 2021, 'Azul', '2020-04-19', 'Flex', 1, 85000.00, 1),
('Toyota', 'Yaris', 2022, 'Cinza', '2021-10-01', 'Gasolina', 1, 97000.00, 1),
('Honda', 'Fit', 2019, 'Preto', '2018-11-22', 'Flex', 0, 65000.00, 1),
('Ford', 'Ka', 2020, 'Branco', '2019-08-15', 'Flex', 0, 59000.00, 1),
('Chevrolet', 'Tracker', 2023, 'Azul', '2022-03-28', 'Flex', 1, 135000.00, 1),
('Volkswagen', 'Nivus', 2022, 'Prata', '2021-07-15', 'Flex', 1, 122000.00, 1),
('Hyundai', 'i30', 2018, 'Vermelho', '2017-09-10', 'Gasolina', 1, 76000.00, 1),
('Renault', 'Sandero', 2021, 'Cinza', '2020-12-11', 'Flex', 0, 65000.00, 1),
('Fiat', 'Mobi', 2022, 'Branco', '2021-05-09', 'Flex', 0, 55000.00, 1),
('Jeep', 'Gladiator', 2023, 'Preto', '2022-08-01', 'Diesel', 1, 275000.00, 1),
('Nissan', 'Frontier', 2022, 'Prata', '2021-04-14', 'Diesel', 1, 210000.00, 1);

SELECT * FROM Veiculos;