CREATE DATABASE AEROLINEA;
GO

CREATE TABLE idiomas (
    id_idioma INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_idiomas PRIMARY KEY (id_idioma)
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
    nombre VARCHAR(20),
    CONSTRAINT pk_instituciones_bancarias PRIMARY KEY (id_institucion)
);

CREATE TABLE paises (
    id_pais INT IDENTITY,
    nombre VARCHAR(20),
    CONSTRAINT pk_paises PRIMARY KEY (id_pais)
);

CREATE TABLE tipos_servicios (
    id_tipo_servicio INT IDENTITY,
    descripcion VARCHAR(20),
    CONSTRAINT pk_tipos_servicios PRIMARY KEY (id_tipo_servicio)
);

CREATE TABLE cupones (
    cod_cupon VARCHAR(50),
    descripcion VARCHAR(20),
    fecha_lanzamiento DATETIME,
    fecha_expiracion DATETIME,
    tope_reintegro DECIMAL(10,2),
    monto DECIMAL(10,2),
    porcentaje DECIMAL(2,0),
    CONSTRAINT pk_cupones PRIMARY KEY (cod_cupon)
);

CREATE TABLE formas_pago (
    id_forma_pago INT IDENTITY,
    descripcion VARCHAR(20),
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
    nombre VARCHAR(20),
    id_pais INT,
    CONSTRAINT pk_provincias PRIMARY KEY (id_provincia),
    CONSTRAINT fk_provincias_paises FOREIGN KEY (id_pais) REFERENCES paises(id_pais)
);

CREATE TABLE ciudades (
    id_ciudad INT IDENTITY,
    nombre VARCHAR(20),
    id_provincia INT,
    CONSTRAINT pk_ciudades PRIMARY KEY (id_ciudad),
    CONSTRAINT fk_ciudades_provincias FOREIGN KEY (id_provincia) REFERENCES provincias(id_provincia)
);

CREATE TABLE barrios (
    id_barrio INT IDENTITY,
    nombre VARCHAR(20),
    id_ciudad INT,
    CONSTRAINT pk_barrios PRIMARY KEY (id_barrio),
    CONSTRAINT fk_barrios_ciudades FOREIGN KEY (id_ciudad) REFERENCES ciudades(id_ciudad)
);

CREATE TABLE tripulantes (
    id_tripulante INT IDENTITY,
    nombre VARCHAR(20),
    apellido VARCHAR(20),
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
    nombre VARCHAR(20),
    apellido VARCHAR(20),
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
    nombre VARCHAR(20),
    cod_iata VARCHAR(3),
    id_ciudad INT,
    CONSTRAINT pk_aeropuertos PRIMARY KEY (id_aeropuerto),
    CONSTRAINT fk_aeropuertos_ciudades FOREIGN KEY (id_ciudad) REFERENCES ciudades(id_ciudad)
);

CREATE TABLE direcciones (
    id_direccion INT IDENTITY,
    calle VARCHAR(20),
    altura INT,
    depto VARCHAR(5),
    piso INT,
    id_pasajero INT,
    id_tripulante INT,
    id_barrio INT,
    CONSTRAINT pk_direcciones PRIMARY KEY (id_direccion),
    CONSTRAINT fk_direcciones_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_direcciones_tripulantes FOREIGN KEY (id_tripulante) REFERENCES tripulantes(id_tripulante),
    CONSTRAINT fk_direcciones_barrios FOREIGN KEY (id_barrio) REFERENCES barrios(id_barrio)
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
    descripcion VARCHAR(50),
    fecha_salida DATETIME,
    horario INT,
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
    descripcion VARCHAR(50),
    fecha DATETIME,
    horario INT,
    id_tipo_servicio INT,
    id_pasajero INT,
    CONSTRAINT pk_pasajes PRIMARY KEY (nro_pasaje),
    CONSTRAINT fk_pasajes_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_pasajes_servicios FOREIGN KEY (id_tipo_servicio) REFERENCES tipos_servicios(id_tipo_servicio)
);

CREATE TABLE detalles_facturas (
    id_detalle INT IDENTITY,
    precio DECIMAL(10,2),
    nro_pasaje INT,
    id_pasajero INT,
    id_vuelo INT,
    CONSTRAINT pk_detalles_facturas PRIMARY KEY (id_detalle),
    CONSTRAINT fk_detalles_pasajeros FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_detalles_vuelos FOREIGN KEY (id_vuelo) REFERENCES vuelos(id_vuelo),
    CONSTRAINT fk_detalles_pasajes FOREIGN KEY (nro_pasaje) REFERENCES pasajes(nro_pasaje)
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
    CONSTRAINT pk_detalle_reserva PRIMARY KEY (id_detalle_reserva),
    CONSTRAINT fk_detalle_reserva FOREIGN KEY (nro_reserva) REFERENCES reservas(nro_reserva),
    CONSTRAINT fk_detalle_pasajero FOREIGN KEY (id_pasajero) REFERENCES pasajeros(id_pasajero),
    CONSTRAINT fk_detalle_preferenciacomida FOREIGN KEY (id_preferencia_comida) REFERENCES preferencias_comidas(id_preferencia_comida),
    CONSTRAINT fk_detalle_asistencias FOREIGN KEY (id_asistencia) REFERENCES asistencias_especiales(id_asistencia),
    CONSTRAINT fk_detalle_servicio FOREIGN KEY (id_tipo_servicio) REFERENCES tipos_servicios(id_tipo_servicio)
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
