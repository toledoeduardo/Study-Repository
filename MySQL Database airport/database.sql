CREATE DATABASE AIRPORT;

-- Seleciona o banco de dados AIRPORT
USE AIRPORT;

-- Cria a tabela Aeronaves
CREATE TABLE Aeronaves (
    id_aeronave INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL,
    numero_poltronas INT NOT NULL
);

-- Cria a tabela Aeroportos
CREATE TABLE Aeroportos (
    id_aeroporto INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    cidade VARCHAR(100) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    pais VARCHAR(50) NOT NULL
);

-- Cria a tabela Voos
CREATE TABLE Voos (
    id_voo INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    id_aeronave INT NOT NULL,
    aeroporto_origem INT NOT NULL,
    aeroporto_destino INT NOT NULL,
    horario_saida TIMESTAMP NOT NULL,
    horario_previsto_chegada TIMESTAMP NOT NULL,
    FOREIGN KEY (id_aeronave) REFERENCES Aeronaves(id_aeronave),
    FOREIGN KEY (aeroporto_origem) REFERENCES Aeroportos(id_aeroporto),
    FOREIGN KEY (aeroporto_destino) REFERENCES Aeroportos(id_aeroporto)
);

-- Cria a tabela Escalas
CREATE TABLE Escalas (
    id_escala INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    id_voo INT NOT NULL,
    aeroporto_escala INT NOT NULL,
    horario_saida TIMESTAMP NOT NULL,
    FOREIGN KEY (id_voo) REFERENCES Voos(id_voo),
    FOREIGN KEY (aeroporto_escala) REFERENCES Aeroportos(id_aeroporto)
);

-- Cria a tabela Poltronas
CREATE TABLE Poltronas (
    id_poltrona INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    id_aeronave INT NOT NULL,
    localizacao VARCHAR(50) NOT NULL,
    FOREIGN KEY (id_aeronave) REFERENCES Aeronaves(id_aeronave)
);

-- Cria a tabela Clientes
CREATE TABLE Clientes (
    id_cliente INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    endereco VARCHAR(200) NOT NULL
);

-- Cria a tabela Poltronas_Disponiveis
CREATE TABLE Poltronas_Disponiveis (
    id_poltrona INT NOT NULL,
    id_voo INT NOT NULL,
    PRIMARY KEY (id_poltrona, id_voo),
    FOREIGN KEY (id_poltrona) REFERENCES Poltronas(id_poltrona),
    FOREIGN KEY (id_voo) REFERENCES Voos(id_voo)
);

-- Cria a tabela Reservas
CREATE TABLE Reservas (
    id_reserva INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    id_cliente INT NOT NULL,
    id_voo INT NOT NULL,
    id_poltrona INT NOT NULL,
    data_reserva TIMESTAMP NOT NULL,
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),
    FOREIGN KEY (id_voo) REFERENCES Voos(id_voo),
    FOREIGN KEY (id_poltrona) REFERENCES Poltronas(id_poltrona)
);