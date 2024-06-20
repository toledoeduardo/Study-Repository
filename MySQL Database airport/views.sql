CREATE VIEW voos_detalhados AS
SELECT 
    v.id_voo,
    v.horario_saida,
    v.horario_previsto_chegada,
    a.tipo AS tipo_aeronave,
    ap_origem.nome AS aeroporto_origem,
    ap_destino.nome AS aeroporto_destino
FROM Voos v
JOIN Aeronaves a ON v.id_aeronave = a.id_aeronave
JOIN Aeroportos ap_origem ON v.aeroporto_origem = ap_origem.id_aeroporto
JOIN Aeroportos ap_destino ON v.aeroporto_destino = ap_destino.id_aeroporto;
