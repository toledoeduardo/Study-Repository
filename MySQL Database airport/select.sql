USE AIRPORT;

-- Listagem de Aeronaves ordenadas por tipo
SELECT * FROM Aeronaves
ORDER BY tipo;

-- Relatório de Voos das Aeronaves por período (dia/semana/mês)
-- DIA
SELECT * FROM Voos
WHERE DATE(horario_saida) = '2024-06-11'; 

-- SEMANA
SELECT * FROM Voos
WHERE YEARWEEK(horario_saida, 1) = YEARWEEK('2024-06-11', 1); 

-- MES
SELECT * FROM Voos
WHERE MONTH(horario_saida) = 6 AND YEAR(horario_saida) = 2024;  -- Substitua o mês e o ano desejados

-- Listagem de Voos que fazem escala em um determinado local
SELECT Voos.* FROM Voos
JOIN Escalas ON Voos.id_voo = Escalas.id_voo
WHERE Escalas.aeroporto_escala = (SELECT id_aeroporto FROM Aeroportos WHERE nome = 'Aeroporto Internacional de São Paulo/Guarulhos'); 

-- Exibição de poltronas disponíveis em um determinado voo/avião
SELECT Poltronas.* FROM Poltronas
JOIN Poltronas_Disponiveis ON Poltronas.id_poltrona = Poltronas_Disponiveis.id_poltrona
WHERE Poltronas_Disponiveis.id_voo = 1;  -- Substitua 1 pelo ID do voo desejado

SELECT Poltronas.* FROM Poltronas
LEFT JOIN Poltronas_Disponiveis ON Poltronas.id_poltrona = Poltronas_Disponiveis.id_poltrona
WHERE Poltronas.id_aeronave = 2 AND Poltronas_Disponiveis.id_voo IS NULL;

-- Verificar a tabela Poltronas_Disponiveis
SELECT * FROM Poltronas_Disponiveis;

-- Deletar uma reserva (adicionará a poltrona de volta à lista de disponíveis)
DELETE FROM Reservas WHERE id_reserva = 1;

-- Verificar a tabela Poltronas_Disponiveis
SELECT * FROM Poltronas_Disponiveis;