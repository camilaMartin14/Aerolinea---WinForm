# Aerolinea---WinForm

# ✈️ Proyecto de Base de Datos: Gestión Operativa de una Aerolínea

## 🧭 Enunciado General

Una importante aerolínea nacional, con operaciones regulares a diversas provincias argentinas y algunos destinos internacionales, requiere el desarrollo de un sistema para la **gestión integral de su actividad comercial y operativa**.

Este sistema estará orientado al **registro y administración de vuelos, flota, tripulaciones, reservas de pasajeros, check-in, y ventas**, así como a la generación de reportes estadísticos y financieros.

---

## 📌 Requisitos Funcionales

### 🛫 Programación de Vuelos
- Alta y edición de vuelos programados:
  - Número de vuelo, origen y destino.
  - Días y horarios de operación.
  - Duración estimada y tipo de servicio (nacional/internacional).
- Asignación de aeronave disponible y tripulación.

### 🛩️ Gestión de Flota
- Registro de aeronaves:
  - Matrícula, modelo, capacidad de pasajeros, autonomía.
  - Fecha de último mantenimiento.
- Asociación de cada avión con los vuelos asignados.

### 👨‍✈️ Gestión de Tripulaciones
- Alta de personal de vuelo:
  - Pilotos, copilotos, auxiliares de cabina.
  - Datos personales, licencias, idiomas, historial de vuelos.
- Validación de disponibilidad horaria y cumplimiento de normas de descanso.
- Evitar solapamiento de asignaciones.

### 🎟️ Reservas y Venta de Pasajes
- Registro de pasajeros:
  - Nombre, documento, nacionalidad, datos de contacto.
  - Preferencias de comida, asistencia especial.
- Reserva de pasajes por distintos canales (web, call center, agencia).
- Control de disponibilidad de asientos.
- Estado de la reserva: pendiente, confirmada, cancelada.

### 💳 Pagos y Promociones
- Registro del método de pago: tarjeta, efectivo, millas acumuladas.
- Aplicación de cupones promocionales (con control de vigencia y uso).
- Acumulación de millas según programa de fidelización.

### 🧳 Check-in y Equipaje
- Validación de identidad y reserva.
- Asignación de asiento (automática o elegida previamente).
- Registro de equipaje despachado: cantidad, peso y dimensiones.

### 📊 Reportes y Métricas
- Vuelos realizados por ruta y fecha.
- Ocupación promedio por vuelo y avión.
- Ventas por destino y canal.
- Millas acumuladas y redimidas por cliente.
- Reportes de uso de flota y disponibilidad operativa.

---

## 🎯 Objetivos del Proyecto

- Modelar una base de datos relacional normalizada para el dominio aeronáutico.
- Implementar el sistema en SQL Server.
- Garantizar integridad referencial, tipos de datos adecuados y relaciones sólidas.
- Preparar consultas SQL y reportes útiles para la toma de decisiones operativas y comerciales.

---

## 🛠️ Consideraciones Técnicas

- Control de restricciones: validación de solapamientos de tripulaciones y disponibilidad de aviones.
- Posibilidad de registrar vuelos recurrentes o únicos.
- Optimización de consultas para reportes de uso frecuente.
- Manejo eficiente de estados (reservas, vuelos, pagos).

---

## 🧩 Alcance del Sistema

Este sistema está diseñado para **uso interno de la aerolínea** por parte del personal administrativo, operativo y comercial.  
No está pensado para ser utilizado directamente por pasajeros ni por personal de aeropuertos.

---

## 📎 Archivos Relacionados

- Diagrama entidad-relación (ERD)
- Script de creación de base de datos en SQL Server
- Procedimientos almacenados de reservas, asignación de tripulación y check-in
- Vistas y consultas para reportes

---


## 📌 Nota Final

Este proyecto simula la operación de un aeropuerto moderno y busca integrar conocimientos de modelado de datos, lógica de negocio, optimización y trazabilidad operativa. El diseño debe anticipar situaciones como sobreventa, vuelos cancelados, pasajeros en tránsito y múltiples métodos de pago.

---
