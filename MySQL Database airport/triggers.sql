USE AIRPORT
DELIMITER //

CREATE TRIGGER after_reserva_insert
AFTER INSERT ON Reservas
FOR EACH ROW
BEGIN
    DELETE FROM Poltronas_Disponiveis
    WHERE id_poltrona = NEW.id_poltrona AND id_voo = NEW.id_voo;
END //

CREATE TRIGGER after_reserva_delete
AFTER DELETE ON Reservas
FOR EACH ROW
BEGIN
    INSERT INTO Poltronas_Disponiveis (id_poltrona, id_voo)
    VALUES (OLD.id_poltrona, OLD.id_voo);
END //

DELIMITER ;
