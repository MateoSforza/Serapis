INSERT INTO Proveedores (Nombre, Cuit, Rubro, Telefono, Email, Activo)
VALUES
('Farmacia Central S.A.', '30-12345678-9', 'Medicamentos', '011-4567-1234', 'contacto@farmaciacentral.com', 1),
('Distribuidora Salud SRL', '33-23456789-0', 'Distribuidora', '011-4789-2233', 'ventas@distribuidorasalud.com', 1),
('Laboratorios Santa Fe', '30-34567890-1', 'Laboratorio', '0342-445-9087', 'info@santafe.com', 1),
('Medicamentos Argentinos S.A.', '30-45678901-2', 'Medicamentos', '011-4590-3300', 'atencion@medargentinos.com', 0),
('Provefarma SRL', '30-56789012-3', 'Insumos Médicos', '011-4334-1200', 'proveedores@provefarma.com', 1),
('BioHealth Ltda.', '30-67890123-4', 'Laboratorio', '011-4033-2200', 'bio@biohealth.com', 0),
('MedPlus Argentina', '30-78901234-5', 'Medicamentos', '011-4567-8899', 'medplus@medplus.com', 1),
('FarmaNet', '30-89012345-6', 'Distribuidora', '011-4777-3344', 'info@farmanet.com', 1),
('Laboratorio Norte', '30-90123456-7', 'Laboratorio', '0299-433-2211', 'ventas@nortelab.com', 1),
('Distribuidora Sureste', '30-01234567-8', 'Distribuidora', '0223-400-5500', 'sureste@dist.com', 0);

INSERT INTO Productos (Nombre, Codigo, Precio, Stock, FechaVencimiento, Laboratorio, Activo, RequiereReceta)
VALUES
('Paracetamol 500mg', 'P001', 120, 100, '2026-05-10', 'Farmacia Central S.A.', 1, 0),
('Ibuprofeno 400mg', 'P002', 150, 80, '2025-12-01', 'Laboratorios Santa Fe', 1, 0),
('Amoxicilina 500mg', 'P003', 320, 50, '2026-03-15', 'Medicamentos Argentinos S.A.', 1, 1),
('Omeprazol 20mg', 'P004', 250, 60, '2025-08-20', 'Provefarma SRL', 0, 0),
('Loratadina 10mg', 'P005', 180, 40, '2025-09-05', 'FarmaNet', 1, 0),
('Metformina 850mg', 'P006', 300, 70, '2026-02-11', 'MedPlus Argentina', 1, 1),
('Aspirina 100mg', 'P007', 110, 90, '2025-11-22', 'Farmacia Central S.A.', 0, 0),
('Clonazepam 2mg', 'P008', 450, 30, '2025-07-13', 'BioHealth Ltda.', 1, 1),
('Simvastatina 20mg', 'P009', 380, 60, '2026-01-01', 'Laboratorio Norte', 1, 1),
('Vitamina C 500mg', 'P010', 90, 150, '2027-05-19', 'Distribuidora Salud SRL', 0, 0);

INSERT INTO Clientes (Nombre, Apellido, DNI, Email, Telefono, ObraSocial, Activo)
VALUES
('Juan', 'Pérez', '30123456', 'juan.perez@gmail.com', '011-4234-1122', 'OSDE', 1),
('María', 'Gómez', '29876543', 'maria.gomez@yahoo.com', '011-4567-3344', 'Swiss Medical', 1),
('Carlos', 'Rodríguez', '31234567', 'carlos.rod@gmail.com', '011-4123-5566', 'IOMA', 1),
('Lucía', 'Fernández', '28765432', 'lucia.fernandez@hotmail.com', '011-4999-6677', 'OSDE', 0),
('Sofía', 'Martínez', '33456789', 'sofia.mtz@gmail.com', '011-4333-2233', 'Galeno', 1),
('Diego', 'Torres', '32234567', 'diegotorres@gmail.com', '011-4000-8899', 'Medicus', 1),
('Ana', 'Sánchez', '31111222', 'ana.sanchez@gmail.com', '011-4777-2233', 'IOMA', 0),
('Federico', 'Ramírez', '29998877', 'fede.ramirez@yahoo.com', '011-4666-9900', 'OSDE', 1),
('Valentina', 'Díaz', '33000111', 'valediaz@gmail.com', '011-4555-8800', 'Swiss Medical', 1),
('Martín', 'Herrera', '28888999', 'martinherrera@gmail.com', '011-4000-2233', 'Galeno', 0);