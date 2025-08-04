CREATE DATABASE AEROLINEA_DB;
GO

CREATE TABLE idiomas (
    id_idioma INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_idiomas PRIMARY KEY (id_idioma)
);

CREATE TABLE estados_vuelo (
    id_estado INT IDENTITY PRIMARY KEY,
    descripcion VARCHAR(30) 
);


CREATE TABLE canales (
    id_canal INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_canales PRIMARY KEY (id_canal)
);

CREATE TABLE profesiones (
    id_profesion INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_profesiones PRIMARY KEY (id_profesion)
);

CREATE TABLE obras_sociales (
    id_obra_social INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_obras_sociales PRIMARY KEY (id_obra_social)
);

CREATE TABLE franjas_horarias (
    id_franja_horaria INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_franjas_horarias PRIMARY KEY (id_franja_horaria)
);

CREATE TABLE tipos_contactos (
    id_tipo_contacto INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_tipos_contactos PRIMARY KEY (id_tipo_contacto)
);

CREATE TABLE preferencias_comidas (
    id_preferencia_comida INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_preferencias_comidas PRIMARY KEY (id_preferencia_comida)
);

CREATE TABLE asistencias_especiales (
    id_asistencia INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_asistencias_especiales PRIMARY KEY (id_asistencia)
);

CREATE TABLE tipos_documentos (
    id_tipo_doc INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_tipos_documentos PRIMARY KEY (id_tipo_doc)
);

CREATE TABLE roles (
    id_rol INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_roles PRIMARY KEY (id_rol)
);

CREATE TABLE instituciones_bancarias (
    id_institucion INT IDENTITY,
    nombre VARCHAR(50),
    CONSTRAINT pk_instituciones_bancarias PRIMARY KEY (id_institucion)
);

CREATE TABLE paises (
    id_pais INT IDENTITY,
    nombre VARCHAR(50),
    CONSTRAINT pk_paises PRIMARY KEY (id_pais)
);

CREATE TABLE tipos_servicios (
    id_tipo_servicio INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_tipos_servicios PRIMARY KEY (id_tipo_servicio)
);

CREATE TABLE cupones (
    cod_cupon VARCHAR(50),
    descripcion VARCHAR(180),
    fecha_lanzamiento DATETIME,
    fecha_expiracion DATETIME,
    tope_reintegro DECIMAL(10,2),
    monto DECIMAL(10,2),
    porcentaje DECIMAL(2,0),
    CONSTRAINT pk_cupones PRIMARY KEY (cod_cupon)
);

CREATE TABLE formas_pago (
    id_forma_pago INT IDENTITY,
    descripcion VARCHAR(50),
    recargo DECIMAL(10,2),
    CONSTRAINT pk_formas_pago PRIMARY KEY (id_forma_pago)
);

CREATE TABLE facturas (
    nro_factura INT IDENTITY,
    fecha_emision DATETIME,
    fecha_pago DATETIME,
    CONSTRAINT pk_facturas PRIMARY KEY (nro_factura)
);

CREATE TABLE provincias (
    id_provincia INT IDENTITY,
    nombre VARCHAR(50),
    id_pais INT,
    CONSTRAINT pk_provincias PRIMARY KEY (id_provincia),
    CONSTRAINT fk_provincias_paises FOREIGN KEY (id_pais) REFERENCES paises(id_pais)
);

CREATE TABLE ciudades (
    id_ciudad INT IDENTITY,
    nombre VARCHAR(50),
    id_provincia INT,
    CONSTRAINT pk_ciudades PRIMARY KEY (id_ciudad),
    CONSTRAINT fk_ciudades_provincias FOREIGN KEY (id_provincia) REFERENCES provincias(id_provincia)
);

CREATE TABLE barrios (
    id_barrio INT IDENTITY,
    nombre VARCHAR(50),
    id_ciudad INT,
    CONSTRAINT pk_barrios PRIMARY KEY (id_barrio),
    CONSTRAINT fk_barrios_ciudades FOREIGN KEY (id_ciudad) REFERENCES ciudades(id_ciudad)
);

CREATE TABLE tripulantes (
    id_tripulante INT IDENTITY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    fecha_nacimiento DATETIME,
    activo BIT,
    nro_doc INT,
    id_profesion INT,
    id_obra_social INT,
    id_franja_horaria INT,
    id_tipo_doc INT,
    CONSTRAINT pk_tripulantes PRIMARY KEY (id_tripulante),
    CONSTRAINT fk_tripulantes_profesiones FOREIGN KEY (id_profesion) REFERENCES profesiones(id_profesion),
    CONSTRAINT fk_tripulantes_ooss FOREIGN KEY (id_obra_social) REFERENCES obras_sociales(id_obra_social),
    CONSTRAINT fk_tripulantes_franjas_horarias FOREIGN KEY (id_franja_horaria) REFERENCES franjas_horarias(id_franja_horaria),
    CONSTRAINT fk_tripulantes_tipos_documentos FOREIGN KEY (id_tipo_doc) REFERENCES tipos_documentos(id_tipo_doc)
);

CREATE TABLE pasajeros (
    id_pasajero INT IDENTITY,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    fecha_nacimiento DATETIME,
    nro_doc INT,
    id_pais INT,
    millas_recorridas DECIMAL(10,2),
    id_tipo_doc INT,
    CONSTRAINT pk_pasajeros PRIMARY KEY (id_pasajero),
    CONSTRAINT fk_pasajeros_tipos_documentos FOREIGN KEY (id_tipo_doc) REFERENCES tipos_documentos(id_tipo_doc),
    CONSTRAINT fk_pasajeros_paises FOREIGN KEY (id_pais) REFERENCES paises(id_pais)
);

CREATE TABLE aeropuertos (
    id_aeropuerto INT IDENTITY,
    nombre VARCHAR(50),
    cod_iata VARCHAR(3),
    id_ciudad INT,
    CONSTRAINT pk_aeropuertos PRIMARY KEY (id_aeropuerto),
    CONSTRAINT fk_aeropuertos_ciudades FOREIGN KEY (id_ciudad) REFERENCES ciudades(id_ciudad)
);

CREATE TABLE direcciones_tripulantes (
    id_direccion INT IDENTITY,
    calle VARCHAR(20),
    altura INT,
    depto VARCHAR(5),
    piso INT,
    id_tripulante INT,
    id_barrio INT,
    CONSTRAINT pk_direcciones_t PRIMARY KEY (id_direccion),
    CONSTRAINT fk_direcciones_tripulantes FOREIGN KEY (id_tripulante) REFERENCES tripulantes(id_tripulante),
    CONSTRAINT fk_tripulantes_barrios FOREIGN KEY (id_barrio) REFERENCES barrios(id_barrio)
);

CREATE TABLE direcciones_pasajeros (
    id_direccion INT IDENTITY,
    calle VARCHAR(20),
    altura INT,
    depto VARCHAR(5),
    piso INT,
    id_pasajero INT,
    id_barrio INT,
    CONSTRAINT pk_direcciones_p PRIMARY KEY (id_direccion),
    CONSTRAINT fk_direcciones_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_pasajeros_barrios FOREIGN KEY (id_barrio) REFERENCES barrios(id_barrio)
);

CREATE TABLE aviones (
    matricula_avion VARCHAR(10),
    modelo VARCHAR(20),
    capacidad INT,
    autonomia_km INT,
    fecha_ultimo_mantenimiento DATETIME,
    operativo BIT,
    disponible BIT,
    id_aeropuerto INT,
    CONSTRAINT pk_aviones PRIMARY KEY (matricula_avion),
    CONSTRAINT fk_aviones_aeropuertos FOREIGN KEY (id_aeropuerto) REFERENCES aeropuertos(id_aeropuerto)
);

CREATE TABLE vuelos (
    id_vuelo INT IDENTITY,
    descripcion VARCHAR(180),
    fecha_salida DATETIME,
    horario TIME,
    fecha_llegada DATETIME,
    duracion_estimada_hs INT,
    matricula_avion VARCHAR(10),
    id_aeropuerto_origen INT,
    id_aeropuerto_destino INT,
    CONSTRAINT pk_vuelos PRIMARY KEY (id_vuelo),
    CONSTRAINT fk_vuelos_aviones FOREIGN KEY (matricula_avion) REFERENCES aviones(matricula_avion),
    CONSTRAINT fk_vuelo_aeropuerto_origen FOREIGN KEY (id_aeropuerto_origen) REFERENCES aeropuertos(id_aeropuerto),
    CONSTRAINT fk_vuelo_aeropuerto_destino FOREIGN KEY (id_aeropuerto_destino) REFERENCES aeropuertos(id_aeropuerto)
);

CREATE TABLE pasajes (
    nro_pasaje INT IDENTITY,
    descripcion VARCHAR(180),
    fecha DATETIME,
    horario TIME,
    id_tipo_servicio INT,
    id_pasajero INT,
	id_vuelo int,
    CONSTRAINT pk_pasajes PRIMARY KEY (nro_pasaje),
    CONSTRAINT fk_pasajes_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_pasajes_servicios FOREIGN KEY (id_tipo_servicio) REFERENCES tipos_servicios(id_tipo_servicio),
	CONSTRAINT fk_pasajes_vuelos FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo)

);

CREATE TABLE detalles_facturas (
    id_detalle INT IDENTITY,
    precio DECIMAL(10,2),
    nro_pasaje INT,
    id_pasajero INT,
    id_vuelo INT,
	nro_factura INT,
    CONSTRAINT pk_detalles_facturas PRIMARY KEY (id_detalle),
    CONSTRAINT fk_detalles_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_detalles_vuelos FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo),
    CONSTRAINT fk_detalles_pasajes FOREIGN KEY (nro_pasaje) REFERENCES pasajes(nro_pasaje),
	 CONSTRAINT fk_detalles_facturas FOREIGN KEY (nro_factura) REFERENCES facturas(nro_factura)
);

CREATE TABLE facturas_formaspago (
    id_factura_pago INT IDENTITY,
    id_forma_pago INT,
    id_nro_factura INT,
    CONSTRAINT pk_facturas_formaspago PRIMARY KEY (id_factura_pago),
    CONSTRAINT fk_facturas_formaspago FOREIGN KEY (id_nro_factura) REFERENCES facturas(nro_factura),
    CONSTRAINT fk_formaspago_facturas FOREIGN KEY (id_forma_pago) REFERENCES formas_pago(id_forma_pago)
);

CREATE TABLE formaspago_pasajeros (
    id_pago_pasajero INT IDENTITY,
    num_tarjeta INT,
    fecha_vencimiento DATETIME,
    cvv INT,
    id_pasajero INT,
    id_forma_pago INT,
    id_institucion INT,
    CONSTRAINT pk_formaspago_pasajero PRIMARY KEY (id_pago_pasajero),
    CONSTRAINT fk_pagos_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_pasajeros_pagos FOREIGN KEY (id_forma_pago) REFERENCES formas_pago(id_forma_pago),
    CONSTRAINT fk_formaspago_pasajeros_instituciones FOREIGN KEY (id_institucion) REFERENCES instituciones_bancarias(id_institucion)
);

CREATE TABLE reservas (
    nro_reserva INT IDENTITY,
    fecha_realizada DATETIME,
    fecha_pactada DATETIME,
    id_canal INT,
    id_vuelo INT,
    CONSTRAINT pk_reservas PRIMARY KEY (nro_reserva),
    CONSTRAINT fk_reservas_vuelos FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo),
    CONSTRAINT fk_reservas_canales FOREIGN KEY (id_canal) REFERENCES canales(id_canal)
);

CREATE TABLE detalles_reservas (
    id_detalle_reserva INT IDENTITY,
    nro_reserva INT,
    asiento VARCHAR(3),
    precio DECIMAL(10,2),
    id_pasajero INT,
    id_preferencia_comida INT,
    id_asistencia INT,
    id_tipo_servicio INT,
	nro_pasaje INT,
    CONSTRAINT pk_detalle_reserva PRIMARY KEY (id_detalle_reserva),
    CONSTRAINT fk_detalle_reserva FOREIGN KEY (nro_reserva) REFERENCES reservas(nro_reserva),
    CONSTRAINT fk_detalle_pasajero FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_detalle_preferenciacomida FOREIGN KEY (id_preferencia_comida) REFERENCES preferencias_comidas(id_preferencia_comida),
    CONSTRAINT fk_detalle_asistencias FOREIGN KEY (id_asistencia) REFERENCES asistencias_especiales(id_asistencia),
    CONSTRAINT fk_detalle_servicio FOREIGN KEY (id_tipo_servicio) REFERENCES tipos_servicios(id_tipo_servicio),
	CONSTRAINT fk_detalle_pasaje FOREIGN KEY (nro_pasaje) REFERENCES pasajes(nro_pasaje)
);

CREATE TABLE equipajes (
    cod_equipaje INT IDENTITY,
    tipo VARCHAR(50),
    dimension_alto INT,
    dimension_ancho INT,
    peso_kg DECIMAL(6,2),
    nro_reserva INT,
    CONSTRAINT pk_equipajes PRIMARY KEY (cod_equipaje),
    CONSTRAINT fk_equipajes_reservas FOREIGN KEY (nro_reserva) REFERENCES reservas(nro_reserva)
);

CREATE TABLE contactos (
    id_contacto INT IDENTITY,
    contacto VARCHAR(50),
    id_pasajero INT,
    id_tipo_contacto INT,
    id_obra_social INT,
    CONSTRAINT pk_contactos PRIMARY KEY (id_contacto),
    CONSTRAINT fk_contactos_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_contactos_tipo FOREIGN KEY (id_tipo_contacto) REFERENCES tipos_contactos(id_tipo_contacto),
    CONSTRAINT fk_contactos_obras_sociales FOREIGN KEY (id_obra_social) REFERENCES obras_sociales(id_obra_social)
);

CREATE TABLE cupones_pasajes (
    id_cupon_pasaje INT IDENTITY,
    cod_cupon VARCHAR(50),
    nro_pasaje INT,
    CONSTRAINT pk_cupones_pasajes PRIMARY KEY (id_cupon_pasaje),
    CONSTRAINT fk_cupones_pasajes FOREIGN KEY (cod_cupon) REFERENCES cupones(cod_cupon),
    CONSTRAINT fk_pasajes_cupones FOREIGN KEY (nro_pasaje) REFERENCES pasajes(nro_pasaje)
);

CREATE TABLE idiomas_tripulantes (
    id_idioma_tripulante INT IDENTITY,
    id_idioma INT,
    id_tripulante INT,
    CONSTRAINT pk_idiomas_tripulantes PRIMARY KEY (id_idioma_tripulante),
    CONSTRAINT fk_idiomas FOREIGN KEY (id_idioma) REFERENCES idiomas(id_idioma),
    CONSTRAINT fk_tripulantes FOREIGN KEY (id_tripulante) REFERENCES tripulantes(id_tripulante)
);

CREATE TABLE tripulantes_vuelos (
    id_tripulante_vuelo INT IDENTITY,
    id_vuelo INT,
    id_tripulante INT,
    id_rol INT,
    CONSTRAINT pk_tripulantes_vuelos PRIMARY KEY (id_tripulante_vuelo),
    CONSTRAINT fk_vuelos FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo),
    CONSTRAINT fk_tripulantes_v FOREIGN KEY (id_tripulante) REFERENCES tripulantes(id_tripulante),
    CONSTRAINT fk_tripulantes_roles FOREIGN KEY (id_rol) REFERENCES roles(id_rol)
);

CREATE TABLE historial_estados_vuelos (
    id_historial INT IDENTITY PRIMARY KEY,
    id_vuelo INT,
    id_estado INT,
    fecha_cambio DATETIME DEFAULT GETDATE(),
    observaciones VARCHAR(100),
    usuario VARCHAR(50), 
    FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo),
    FOREIGN KEY (id_estado) REFERENCES estados_vuelo(id_estado)
);

---------- INSERTS ----------

INSERT INTO idiomas (descripcion) VALUES
('Español'), ('Inglés'), ('Francés'), ('Alemán'), ('Portugués'),
('Italiano'), ('Chino'), ('Japonés'), ('Ruso'), ('Árabe');

INSERT INTO estados_vuelo (descripcion) VALUES
('Programado'), ('Confirmado'), ('Demorado'), ('Cancelado'), ('En vuelo'),
('Aterrizado'), ('Reprogramado'), ('En revisión'), ('Mantenimiento'), ('Finalizado');

INSERT INTO canales (descripcion) VALUES
('Web'), ('App Móvil'), ('Presencial'), ('Agencia'), ('Call Center'),
('Redes Sociales'), ('Correo'), ('Chatbot'), ('Agente virtual'), ('Tótem');

INSERT INTO profesiones (descripcion) VALUES
('Piloto'), ('Copiloto'), ('Azafata'), ('Mecánico'), ('Ingeniero'),
('Controlador'), ('Supervisor'), ('Paramédico'), ('Operador'), ('Despachante');

INSERT INTO obras_sociales (descripcion) VALUES
('OSDE'), ('Swiss Medical'), ('Galeno'), ('PAMI'), ('IOMA'),
('Medicus'), ('Accord'), ('OMINT'), ('Prevención'), ('Sancor Salud');

INSERT INTO franjas_horarias (descripcion) VALUES
('Madrugada'), ('Mañana'), ('Mediodía'), ('Tarde'), ('Atardecer'),
('Noche'), ('Horario Pico'), ('Valle'), ('Especial'), ('Emergencia');

INSERT INTO tipos_contactos (descripcion) VALUES
('Teléfono'), ('Email'), ('Red Social'), ('WhatsApp'), ('Telegram'),
('Fax'), ('Radio'), ('Mensaje'), ('Señal Visual'), ('Otro');

INSERT INTO preferencias_comidas (descripcion) VALUES
('Vegetariana'), ('Vegana'), ('Celíaca'), ('Kosher'), ('Halal'),
('Baja en sodio'), ('Sin lactosa'), ('Normal'), ('Sin gluten'), ('Niños');

INSERT INTO asistencias_especiales (descripcion) VALUES
('Silla de ruedas'), ('Lenguaje de señas'), ('Asistencia visual'), ('Oxígeno'), ('Medicamentos'),
('Mascota de servicio'), ('Dietas especiales'), ('Embarazada'), ('Adulto mayor'), ('Niños solos');

INSERT INTO tipos_documentos (descripcion) VALUES
('DNI'), ('Pasaporte'), ('Cédula'), ('Visa'), ('Carnet Conducir'),
('Documento Extranjero'), ('Tarjeta Migratoria'), ('ID Nacional'), ('Permiso Residencia'), ('Otro');

INSERT INTO roles (descripcion) VALUES
('Piloto'), ('Copiloto'), ('Comisario de a bordo'), ('Azafata'), ('Mecánico'),
('Técnico de tierra'), ('Supervisor'), ('Instructor'), ('Médico'), ('Jefe de cabina');

INSERT INTO instituciones_bancarias (nombre) VALUES
('Banco Nación'), ('Banco Santander'), ('Banco Galicia'), ('Banco BBVA'), ('Banco Macro'),
('Banco Provincia'), ('HSBC'), ('ICBC'), ('Credicoop'), ('Banco Ciudad');

INSERT INTO paises (nombre) VALUES
('Argentina'), ('Brasil'), ('Chile'), ('Uruguay'), ('Paraguay'),
('Bolivia'), ('Perú'), ('Colombia'), ('Estados Unidos'), ('España');

INSERT INTO tipos_servicios (descripcion) VALUES
('Económica'), ('Premium Economy'), ('Business'), ('Primera Clase'), ('Carga'),
('VIP'), ('Low Cost'), ('Chárter'), ('Fretamento'), ('Ejecutiva');

INSERT INTO provincias (nombre, id_pais) VALUES
('Buenos Aires', 1), ('Córdoba', 1), ('Santa Fe', 1), ('Mendoza', 1), ('Salta', 1),
('Tucumán', 1), ('Chubut', 1), ('Neuquén', 1), ('Río Negro', 1), ('San Juan', 1);

INSERT INTO ciudades (nombre, id_provincia) VALUES
('La Plata', 1), ('Córdoba Capital', 2), ('Rosario', 3), ('Mendoza Capital', 4), ('Salta Capital', 5),
('San Miguel de Tucumán', 6), ('Rawson', 7), ('Neuquén Capital', 8), ('Bariloche', 9), ('San Juan Capital', 10);

INSERT INTO barrios (nombre, id_ciudad) VALUES
('Centro', 1), ('Norte', 2), ('Sur', 3), ('Este', 4), ('Oeste', 5),
('Alberdi', 6), ('Recoleta', 7), ('Belgrano', 8), ('Palermo', 9), ('San Vicente', 10);

INSERT INTO tripulantes (nombre, apellido, fecha_nacimiento, activo, nro_doc, id_profesion, id_obra_social, id_franja_horaria, id_tipo_doc)
VALUES
('Carlos', 'Gómez', '1985-01-01', 1, 36145752, 1, 1, 1, 1),
('Lucía', 'Martínez', '1986-01-01', 1, 33064240, 2, 2, 2, 2),
('Juan', 'Pérez', '1987-01-01', 1, 37746800, 3, 3, 3, 3),
('María', 'López', '1988-01-01', 1, 33731733, 4, 4, 4, 4),
('Pedro', 'Fernández', '1988-12-31', 1, 31154177, 5, 5, 5, 5),
('Sofía', 'Ramos', '1989-12-31', 1, 34916851, 6, 6, 6, 6),
('Javier', 'Torres', '1990-12-31', 1, 33792175, 7, 7, 7, 7),
('Ana', 'Romero', '1991-12-31', 1, 38488161, 8, 8, 8, 8),
('Diego', 'Morales', '1992-12-30', 1, 32340161, 9, 9, 9, 9),
('Clara', 'Díaz', '1993-12-30', 1, 33084239, 10, 10, 10, 10);

INSERT INTO pasajeros (nombre, apellido, fecha_nacimiento, nro_doc, id_pais, millas_recorridas, id_tipo_doc)
VALUES
('Laura', 'Gutiérrez', '1985-01-01', 33011111, 1, 15000.5, 1),
('Tomás', 'Vega', '1986-01-01', 34522222, 1, 2000.0, 2),
('Camila', 'Silva', '1987-01-01', 35633333, 1, 8700.7, 3),
('Mateo', 'Ruiz', '1988-01-01', 31244444, 1, 12300.9, 4),
('Valentina', 'Acosta', '1988-12-31', 36555555, 1, 450.0, 5),
('Bruno', 'Benítez', '1989-12-31', 37666666, 1, 17500.2, 6),
('Isabella', 'Suárez', '1990-12-31', 38777777, 1, 3050.4, 7),
('Sebastián', 'Herrera', '1991-12-31', 39888888, 1, 9200.0, 8),
('Martina', 'Iglesias', '1992-12-30', 30999999, 1, 10500.6, 9),
('Lautaro', 'Peralta', '1993-12-30', 30000000, 1, 4000.3, 10);

INSERT INTO aeropuertos (nombre, cod_iata, id_ciudad)
VALUES
('Aeropuerto La Plata', 'LPL', 1),
('Aeropuerto Córdoba', 'COR', 2),
('Aeropuerto Rosario', 'ROS', 3),
('Aeropuerto Mendoza', 'MDZ', 4),
('Aeropuerto Salta', 'SLA', 5),
('Aeropuerto Tucumán', 'TUC', 6),
('Aeropuerto Rawson', 'RAW', 7),
('Aeropuerto Neuquén', 'NQN', 8),
('Aeropuerto Bariloche', 'BRC', 9),
('Aeropuerto San Juan', 'UAQ', 10);

INSERT INTO aviones (matricula_avion, modelo, capacidad, autonomia_km, fecha_ultimo_mantenimiento, operativo, disponible, id_aeropuerto)
VALUES
('LV-A001', 'Boeing 737', 180, 5000, '2025-06-20', 1, 1, 1),
('LV-A002', 'Airbus A320', 160, 4800, '2025-06-25', 1, 1, 2),
('LV-A003', 'Boeing 787', 250, 9500, '2025-06-30', 1, 1, 3),
('LV-A004', 'Embraer 190', 100, 3500, '2025-07-05', 1, 1, 4),
('LV-A005', 'Boeing 737 MAX', 200, 6000, '2025-07-10', 1, 1, 5),
('LV-A006', 'Airbus A330', 290, 10500, '2025-07-15', 1, 1, 6),
('LV-A007', 'Boeing 777', 300, 12500, '2025-07-20', 1, 1, 7),
('LV-A008', 'CRJ 900', 90, 2800, '2025-07-25', 1, 1, 8),
('LV-A009', 'ATR 72', 70, 1500, '2025-07-30', 1, 1, 9),
('LV-A010', 'Boeing 767', 240, 8900, '2025-08-04', 1, 1, 10);

INSERT INTO direcciones_tripulantes (calle, altura, depto, piso, id_tripulante, id_barrio)
VALUES
('Mitre', 123, 'A', 1, 1, 1),
('Belgrano', 456, 'B', 2, 2, 2),
('Rivadavia', 789, NULL, 0, 3, 3),
('San Martín', 321, 'C', 3, 4, 4),
('Perón', 654, NULL, 0, 5, 5),
('Sarmiento', 987, 'D', 4, 6, 6),
('Urquiza', 159, NULL, 0, 7, 7),
('Catamarca', 753, 'E', 5, 8, 8),
('Corrientes', 258, NULL, 0, 9, 9),
('Salta', 369, 'F', 6, 10, 10);

INSERT INTO direcciones_pasajeros (calle, altura, depto, piso, id_pasajero, id_barrio)
VALUES
('Maipú', 147, NULL, 0, 1, 1),
('Santa Fe', 258, 'G', 1, 2, 2),
('Córdoba', 369, NULL, 0, 3, 3),
('Lavalle', 741, 'H', 2, 4, 4),
('Entre Ríos', 852, NULL, 0, 5, 5),
('Misiones', 963, 'I', 3, 6, 6),
('Tucumán', 357, NULL, 0, 7, 7),
('Jujuy', 468, 'J', 4, 8, 8),
('Formosa', 579, NULL, 0, 9, 9),
('Chaco', 690, 'K', 5, 10, 10);

INSERT INTO vuelos (descripcion, fecha_salida, horario, fecha_llegada, duracion_estimada_hs, matricula_avion, id_aeropuerto_origen, id_aeropuerto_destino)
VALUES
('Vuelo a Córdoba', '2025-08-05', '08:00:00', '2025-08-05', 2, 'LV-A001', 1, 2),
('Vuelo a Mendoza', '2025-08-06', '10:30:00', '2025-08-06', 3, 'LV-A002', 2, 4),
('Vuelo a Salta', '2025-08-07', '14:00:00', '2025-08-07', 2, 'LV-A003', 3, 5),
('Vuelo a Tucumán', '2025-08-08', '16:45:00', '2025-08-08', 2, 'LV-A004', 4, 6),
('Vuelo a Neuquén', '2025-08-09', '06:15:00', '2025-08-09', 3, 'LV-A005', 5, 8),
('Vuelo a Rosario', '2025-08-10', '09:20:00', '2025-08-10', 1, 'LV-A006', 6, 3),
('Vuelo a Bariloche', '2025-08-11', '11:50:00', '2025-08-11', 2, 'LV-A007', 7, 9),
('Vuelo a San Juan', '2025-08-12', '13:30:00', '2025-08-12', 2, 'LV-A008', 8, 10),
('Vuelo a Buenos Aires', '2025-08-13', '17:00:00', '2025-08-13', 2, 'LV-A009', 9, 1),
('Vuelo a Córdoba', '2025-08-14', '19:40:00', '2025-08-14', 3, 'LV-A010', 10, 2);

INSERT INTO pasajes (descripcion, fecha, horario, id_tipo_servicio, id_pasajero, id_vuelo)
VALUES
('Pasaje Laura Gutiérrez', '2025-08-05', '08:00:00', 1, 1, 1),
('Pasaje Tomás Vega', '2025-08-06', '10:30:00', 2, 2, 2),
('Pasaje Camila Silva', '2025-08-07', '14:00:00', 3, 3, 3),
('Pasaje Mateo Ruiz', '2025-08-08', '16:45:00', 4, 4, 4),
('Pasaje Valentina Acosta', '2025-08-09', '06:15:00', 5, 5, 5),
('Pasaje Bruno Benítez', '2025-08-10', '09:20:00', 6, 6, 6),
('Pasaje Isabella Suárez', '2025-08-11', '11:50:00', 7, 7, 7),
('Pasaje Sebastián Herrera', '2025-08-12', '13:30:00', 8, 8, 8),
('Pasaje Martina Iglesias', '2025-08-13', '17:00:00', 9, 9, 9),
('Pasaje Lautaro Peralta', '2025-08-14', '19:40:00', 10, 10, 10);

INSERT INTO facturas (fecha_emision, fecha_pago)
VALUES
('2025-08-05', '2025-08-06'),
('2025-08-06', '2025-08-07'),
('2025-08-07', '2025-08-08'),
('2025-08-08', '2025-08-09'),
('2025-08-09', '2025-08-10'),
('2025-08-10', '2025-08-11'),
('2025-08-11', '2025-08-12'),
('2025-08-12', '2025-08-13'),
('2025-08-13', '2025-08-14'),
('2025-08-14', '2025-08-15');

INSERT INTO detalles_facturas (precio, nro_pasaje, id_pasajero, id_vuelo, nro_factura)
VALUES
(25000.00, 1, 1, 1, 1),
(18000.00, 2, 2, 2, 2),
(32000.00, 3, 3, 3, 3),
(28000.00, 4, 4, 4, 4),
(15000.00, 5, 5, 5, 5),
(27000.00, 6, 6, 6, 6),
(22000.00, 7, 7, 7, 7),
(19000.00, 8, 8, 8, 8),
(21000.00, 9, 9, 9, 9),
(24000.00, 10, 10, 10, 10);