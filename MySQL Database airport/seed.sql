USE AIRPORT;
INSERT INTO Aeronaves (tipo, numero_poltronas)
VALUES 
    ('Boeing 737', 180),
    ('Airbus A320', 150),
    ('Embraer E190', 100),
    ('Boeing 747', 366),
    ('Airbus A380', 555),
    ('Bombardier CRJ700', 70),
    ('ATR 72', 72);
 
INSERT INTO Aeroportos (nome, cidade, estado, pais)
VALUES 
    ('Aeroporto Internacional de São Paulo/Guarulhos', 'Guarulhos', 'São Paulo', 'Brasil'),
    ('Aeroporto Internacional do Rio de Janeiro/Galeão', 'Rio de Janeiro', 'Rio de Janeiro', 'Brasil'),
    ('Aeroporto Internacional de Brasília', 'Brasília', 'Distrito Federal', 'Brasil'),
    ('Aeroporto Internacional de Los Angeles', 'Los Angeles', 'Califórnia', 'Estados Unidos'),
    ('Aeroporto Internacional de Heathrow', 'Londres', 'Inglaterra', 'Reino Unido');
    
INSERT INTO Voos (id_aeronave, aeroporto_origem, aeroporto_destino, horario_saida, horario_previsto_chegada)
VALUES (1, 1, 2, '2024-06-11 08:00:00', '2024-06-11 12:00:00');

INSERT INTO Voos (id_aeronave, aeroporto_origem, aeroporto_destino, horario_saida, horario_previsto_chegada)
VALUES (3, 3, 2, '2024-06-16 16:00:00', '2024-06-11 22:00:00');

INSERT INTO Voos (id_aeronave, aeroporto_origem, aeroporto_destino, horario_saida, horario_previsto_chegada)
VALUES (1, 4, 1, '2024-06-20 12:00:00', '2024-06-11 17:00:00');

INSERT INTO Escalas (id_voo, aeroporto_escala, horario_saida)
VALUES 
    (1, 1, '2024-06-11 10:30:00'),
    (2, 4, '2024-06-11 19:30:00'),
    (3, 2, '2024-06-11 14:30:00');
    
INSERT INTO Poltronas (id_aeronave, localizacao)
VALUES 
    (1, 'A1'),
    (1, 'A2'),
    (1, 'B1'),
    (2, 'A1'),
    (2, 'A2'),
    (2, 'B1');
    
INSERT INTO Clientes (nome, email, telefone, endereco)
VALUES 
    ('João Silva', 'joao.silva@example.com', '(11) 98765-4321', 'Rua das Flores, 123, São Paulo, SP, Brasil'),
    ('Maria Oliveira', 'maria.oliveira@example.com', '(21) 91234-5678', 'Avenida das Américas, 456, Rio de Janeiro, RJ, Brasil'),
    ('Carlos Pereira', 'carlos.pereira@example.com', '(31) 99876-5432', 'Praça da Liberdade, 789, Belo Horizonte, MG, Brasil'),
    ('Ana Costa', 'ana.costa@example.com', '(41) 97654-3210', 'Rua XV de Novembro, 1011, Curitiba, PR, Brasil');


INSERT INTO Poltronas_Disponiveis (id_poltrona, id_voo)
VALUES 
    (1, 1),
    (2, 1),
    (3, 1),
    (4, 2),
    (5, 2),
    (6, 2);
    
    -- Inserir uma reserva (removerá a poltrona da lista de disponíveis)
INSERT INTO Reservas (id_cliente, id_voo, id_poltrona, data_reserva) VALUES (1, 1, 1, NOW());
