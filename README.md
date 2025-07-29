# Aeropuerto---WinForms

# 📦 Proyecto de Base de Datos: Gestión Operativa de un Aeropuerto

## ✈️ Enunciado General

Un importante aeropuerto internacional de nuestra región, que opera vuelos nacionales e internacionales a diario, requiere la implementación de una base de datos integral para la gestión de sus operaciones y servicios clave.

Este sistema deberá permitir registrar, organizar y consultar información relacionada con vuelos, aerolíneas, pasajeros, aviones, personal aeroportuario y servicios logísticos, con el fin de optimizar la operatividad y mejorar la experiencia de viaje.

---

## 🧩 Requisitos Funcionales

### 📌 Registro y Gestión de Aerolíneas
- Alta de aerolíneas, con datos institucionales y contactos.
- Registro de su flota de aviones (matrícula, modelo, capacidad, autonomía, etc.).
- Carga de personal asignado (pilotos, auxiliares, tripulación).

### 🛫 Programación de Vuelos
- Alta de vuelos con información detallada:
  - Número de vuelo, origen y destino.
  - Horario estimado de salida y llegada.
  - Frecuencia (diaria, semanal, etc.).
  - Tipo de servicio (nacional o internacional).
  - Avión y tripulación asignada.
- Asignación de pistas y puertas de embarque según disponibilidad.

### 👥 Gestión de Pasajeros
- Registro de pasajeros: DNI, nacionalidad, contacto, preferencias, asistencia especial.
- Asociación a programas de fidelización (si corresponde).
- Compra de pasajes por distintos canales (presencial, web, agencia).

### 🧳 Check-in y Equipaje
- Registro de check-in con validación de identidad.
- Asignación de asientos y emisión de boarding pass.
- Carga de equipaje: cantidad de piezas, peso, dimensiones.

### 📡 Seguimiento Operativo
- Estados de vuelos en tiempo real: en horario, embarcando, retrasado, cancelado, etc.
- Registro de eventos relevantes: desvíos, mantenimiento, cambios de puerta, etc.
- Control migratorio para vuelos internacionales.

### 👨‍✈️ Personal Aeroportuario
- Registro de empleados del aeropuerto: nombre, rol, sector (embarque, limpieza, torre, etc.).
- Gestión de turnos y asignación a sectores.

### 💰 Facturación y Estadísticas
- Cálculo de cargos por servicios prestados a aerolíneas:
  - Uso de pista, estacionamiento, logística, etc.
- Generación de reportes:
  - Pasajeros por destino.
  - Puntualidad por aerolínea.
  - Utilización de infraestructura.
  - Vuelos por franja horaria.

---

## 🛠️ Objetivos del Proyecto

- Diseñar un modelo relacional normalizado que represente adecuadamente las entidades y relaciones del dominio aeroportuario.
- Implementar la base de datos en SQL Server.
- Garantizar integridad referencial, control de claves primarias/foráneas y tipos de datos adecuados.
- Facilitar consultas complejas y reportes operativos.

---

## 📎 Consideraciones Técnicas

- El sistema deberá contemplar la escalabilidad de operaciones.
- Deberá permitir múltiples vuelos diarios, pasajeros concurrentes y asignaciones dinámicas de infraestructura.
- Se recomienda diseñar procedimientos almacenados para tareas repetitivas como check-in, asignación de puertas y facturación.

---

## 📌 Nota Final

Este proyecto simula la operación de un aeropuerto moderno y busca integrar conocimientos de modelado de datos, lógica de negocio, optimización y trazabilidad operativa. El diseño debe anticipar situaciones como sobreventa, vuelos cancelados, pasajeros en tránsito y múltiples métodos de pago.

---
