DELIMITER //

CREATE PROCEDURE verificar_poltronas_disponiveis(IN voo_id INT)
BEGIN
    SELECT p.id_poltrona, p.localizacao
    FROM Poltronas p
    JOIN Poltronas_Disponiveis pd ON p.id_poltrona = pd.id_poltrona
    WHERE pd.id_voo = voo_id;
END //

DELIMITER ;