-- ========================
-- 1. Limpiar tablas (respetando FK)
-- ========================
DELETE FROM ItemsVenta;
DELETE FROM ItemsCompra;
DELETE FROM Ventas;
DELETE FROM Compras;
DELETE FROM Recetas;
DELETE FROM Productos;
DELETE FROM Proveedores;
DELETE FROM Clientes;
DELETE FROM Usuarios;

-- ========================
-- 2. Reiniciar IDs
-- ========================
DBCC CHECKIDENT ('Clientes', RESEED, 0);
DBCC CHECKIDENT ('Proveedores', RESEED, 0);
DBCC CHECKIDENT ('Productos', RESEED, 0);
DBCC CHECKIDENT ('Compras', RESEED, 0);
DBCC CHECKIDENT ('ItemsCompra', RESEED, 0);
DBCC CHECKIDENT ('Ventas', RESEED, 0);
DBCC CHECKIDENT ('ItemsVenta', RESEED, 0);
DBCC CHECKIDENT ('Recetas', RESEED, 0);
DBCC CHECKIDENT ('Usuarios', RESEED, 0);

-- ========================
-- 3. Insertar Clientes
-- ========================
INSERT INTO Clientes (Nombre, Apellido, Email, Telefono, ObraSocial, Activo)
VALUES
('Juan', 'Pérez', 'juan.perez@example.com', '1111-1111', 'OSDE', 1),
('María', 'Gómez', 'maria.gomez@example.com', '2222-2222', 'Swiss Medical', 1);

-- ========================
-- 4. Insertar Proveedores
-- ========================
INSERT INTO Proveedores (Nombre, Cuit, Rubro, Telefono, Email, Activo)
VALUES
('Proveedor 1', '20-11111111-1', 'Medicamentos', '3333-3333', 'prov1@example.com', 1),
('Proveedor 2', '20-22222222-2', 'Suplementos', '4444-4444', 'prov2@example.com', 1);

-- ========================
-- 5. Insertar Productos
-- ========================
INSERT INTO Productos (Nombre, Codigo, Precio, Stock, FechaVencimiento, Laboratorio, Activo, RequiereReceta)
VALUES
('Paracetamol 500mg', 'P500', 500, 50, '2026-12-31', 'Bayer', 1, 0),
('Ibuprofeno 400mg', 'I400', 800, 30, '2026-06-30', 'Pfizer', 1, 0),
('Amoxicilina 500mg', 'A500', 1500, 20, '2025-12-31', 'Roemmers', 1, 1);

-- ========================
-- 6. Insertar Compras
-- ========================
INSERT INTO Compras (Fecha, ProveedorId)
VALUES
(GETDATE(), 1),
(GETDATE(), 2);

-- ========================
-- 7. Insertar ItemsCompra
-- ========================
INSERT INTO ItemsCompra (CompraId, ProductoId, Cantidad, PrecioUnitario)
VALUES
(1, 1, 20, 400),
(1, 2, 15, 700),
(2, 3, 10, 1300);

-- ========================
-- 8. Insertar Recetas
-- ========================
INSERT INTO Recetas (Detalle, Fecha, Medico)
VALUES
('Tomar 1 comprimido cada 8 horas', GETDATE(), 'Dr. House'),
('Aplicar 1 vez al día', GETDATE(), 'Dra. Smith');

-- ========================
-- 9. Insertar Ventas
-- ========================
INSERT INTO Ventas (Fecha, Total, ClienteId, RecetaId)
VALUES
(GETDATE(), 2000, 1, 1),
(GETDATE(), 1500, 2, 2);

-- ========================
-- 10. Insertar ItemsVenta
-- ========================
INSERT INTO ItemsVenta (VentaId, ProductoId, Cantidad, PrecioUnitario)
VALUES
(1, 1, 2, 500),
(1, 2, 1, 800),
(2, 3, 1, 1500);

-- ========================
-- 11. Insertar Usuario Admin
-- Contraseña: admin (debes reemplazar el hash por el que genere tu programa si usa HashHelper)
-- ========================
INSERT INTO Usuarios (Nombre, Contraseña, Rol)
VALUES
('admin@admin.com', 'admin', 'Admin');
