# Especificación de Requisitos de Software

Este documento comprende los principales requerimientos para lograr el **MVP**
del proyecto.

## 0. Tabla de Contenidos

# Tabla de Contenidos

- [Especificación de Requisitos de Software](#especificación-de-requisitos-de-software)
  - [0. Tabla de Contenidos](#0-tabla-de-contenidos)
- [Tabla de Contenidos](#tabla-de-contenidos)
  - [1. Introducción](#1-introducción)
    - [1.1 Propósito](#11-propósito)
    - [1.2 Alcance](#12-alcance)
  - [2. Descripción General](#2-descripción-general)
    - [2.1 Perspectiva del producto](#21-perspectiva-del-producto)
    - [2.2 Características del producto](#22-características-del-producto)
    - [2.3 Usuarios](#23-usuarios)
  - [3. Requisitos específicos](#3-requisitos-específicos)
    - [3.1 Requisitos funcionales](#31-requisitos-funcionales)
      - [RF-01: Gestión de usuarios y autenticación](#rf-01-gestión-de-usuarios-y-autenticación)
      - [RF-02: Consulta de cartelera](#rf-02-consulta-de-cartelera)
      - [RF-03: Selección de asientos](#rf-03-selección-de-asientos)
      - [RF-04: Gestión de reservas](#rf-04-gestión-de-reservas)
      - [RF-05: Historial de reservas](#rf-05-historial-de-reservas)
      - [RF-06: Cancelación de reservas](#rf-06-cancelación-de-reservas)
      - [RF-07: Modificación de reservas](#rf-07-modificación-de-reservas)
        - [**OBSERVACIÓN**](#observación)
    - [3.2 Requisitos no funcionales](#32-requisitos-no-funcionales)
      - [RNF-01: Seguridad](#rnf-01-seguridad)
      - [RNF-02: Rendimiento](#rnf-02-rendimiento)
      - [RNF-03: Usabilidad](#rnf-03-usabilidad)
      - [RNF-04: Mantenibilidad](#rnf-04-mantenibilidad)
      - [RNF-05: Compatibilidad](#rnf-05-compatibilidad)

## 1. Introducción

### 1.1 Propósito

El objetivo de este documento es definir los requerimientos funcionales y no funcionales
que el proyecto debe cumplir para poder lograr el Producto Minimo Viable a la hora de su
desarrollo.

El proyecto se trata de un sistema de reservas de asientos de cine, el cual permitirá al usuario
registrarse, ingresar, visualizar la cartelera y horarios y posteriormente podrá realizar su reserva
seleccionando previamente su asiento, y el sistema se asegurará de que no ocurran reservas duplicadas
al mismo tiempo. El cliente podrá cancelar su reserva y deberá liberarse el asiento posteriormente.

### 1.2 Alcance

El sistema debe permitir lo siguiente:

- Registro e Inicio de Sesión
- Visualización de la cartelera
- Creación de reserva
- Mapa interactivo para selección de asiento
- Protección contra reservas duplicadas
- Historial de reservas
- Cancelación de reservas

Está fuera de alcance para el MVP:

- Pasarela de pagos
- Sistema de notificaciones
- Compra de boletos
- Reseñas y calificaciones
- Panel administrativo

## 2. Descripción General

### 2.1 Perspectiva del producto

El sistema estará compuesto por lo siguiente:

- **Módulo de Autenticación (Login y Registro)**
- **Módulo para visualizar la cartelera**
- **Sistema de Reserva con Selección Dinámica de Asientos**
- **Base de Datos Relacional**

### 2.2 Características del producto

La principal característica del producto es la implementación de un sistema robusto a la hora de las reservas
evitando que dos clientes reserven el mismo asiento a la vez, contando con un sistema de historial que si el cliente
desea cambiar su asiento, podrá hacerlo dejando su anterior asiento bloqueado por 5 minutos por si desea volver a 
tomarlo, evitando asi equivocaciones e inconvenientes, permitiendo una sola modificación por reserva.

### 2.3 Usuarios 

En la fase inicial para lograr el **MVP** el sistema solamente estará enfocado en los clientes
que deseen reservar sus boletas para las peliculas.


## 3. Requisitos específicos

### 3.1 Requisitos funcionales

Los requisitos funcionales describen las operaciones y comportamientos que CineXera debe proporcionar a sus usuarios.

#### RF-01: Gestión de usuarios y autenticación

| Código | Requisito funcional |
|---|---|
| RF-01.1 | El sistema debe permitir a los usuarios registrarse mediante un formulario con los datos requeridos. |
| RF-01.2 | El sistema debe validar los datos proporcionados durante el registro. |
| RF-01.3 | El sistema debe impedir el registro de usuarios con una dirección de correo electrónico previamente registrada. |
| RF-01.4 | El sistema debe permitir a los usuarios iniciar sesión utilizando su correo electrónico y contraseña. |
| RF-01.5 | El sistema debe validar las credenciales y rechazar los intentos de autenticación incorrectos. |
| RF-01.6 | El sistema debe permitir a los usuarios autenticados cerrar sesión. |
| RF-01.7 | El sistema debe restringir las operaciones de reserva, consulta del historial y cancelación a usuarios autenticados. |

#### RF-02: Consulta de cartelera

| Código | Requisito funcional |
|---|---|
| RF-02.1 | El sistema debe permitir a los visitantes consultar las películas disponibles en cartelera sin necesidad de autenticarse. |
| RF-02.2 | El sistema debe mostrar información básica de cada película, incluyendo título, imagen, género y duración. |
| RF-02.3 | El sistema debe permitir consultar los detalles de una película seleccionada. |
| RF-02.4 | El sistema debe mostrar las funciones disponibles para cada película, incluyendo fecha, horario y sala de proyección. |
| RF-02.5 | El sistema debe permitir seleccionar una función para consultar sus asientos. |

#### RF-03: Selección de asientos

| Código | Requisito funcional |
|---|---|
| RF-03.1 | El sistema debe mostrar un mapa visual de los asientos correspondientes a la sala de la función seleccionada. |
| RF-03.2 | El sistema debe diferenciar visualmente los asientos disponibles, ocupados y seleccionados. |
| RF-03.3 | El sistema debe permitir al usuario seleccionar uno o varios asientos disponibles. |
| RF-03.4 | El sistema debe permitir al usuario deseleccionar asientos antes de confirmar la reserva. |
| RF-03.5 | El sistema debe impedir la selección de asientos que ya se encuentren reservados. |
| RF-03.6 | El sistema debe mostrar la cantidad de asientos seleccionados antes de confirmar la reserva. |

#### RF-04: Gestión de reservas

| Código | Requisito funcional |
|---|---|
| RF-04.1 | El sistema debe permitir a los usuarios autenticados crear reservas para una función seleccionada. |
| RF-04.2 | El sistema debe asociar cada reserva con el usuario, la función y los asientos seleccionados. |
| RF-04.3 | El sistema debe comprobar la disponibilidad de los asientos antes de confirmar una reserva. |
| RF-04.4 | El sistema debe impedir que un mismo asiento sea reservado por más de un usuario para una misma función. |
| RF-04.5 | El sistema debe procesar la creación de reservas de manera atómica, evitando reservas parciales cuando ocurra un error. |
| RF-04.6 | El sistema debe registrar la fecha y hora de creación de cada reserva. |
| RF-04.7 | El sistema debe mostrar una confirmación cuando una reserva se haya realizado correctamente. |
| RF-04.8 | El sistema debe informar al usuario cuando una reserva no pueda completarse, indicando si alguno de los asientos seleccionados ya no se encuentra disponible. |
| RF-04.9 | El sistema debe permitir la edición  |

#### RF-05: Historial de reservas

| Código | Requisito funcional |
|---|---|
| RF-05.1 | El sistema debe permitir a los usuarios autenticados consultar su historial de reservas. |
| RF-05.2 | El sistema debe mostrar la película, fecha y hora de la función, sala y asientos correspondientes a cada reserva. |
| RF-05.3 | El sistema debe mostrar el estado de cada reserva, diferenciando entre reservas activas y canceladas. |
| RF-05.4 | El sistema debe impedir que un usuario consulte las reservas pertenecientes a otros usuarios. |

#### RF-06: Cancelación de reservas

| Código | Requisito funcional |
|---|---|
| RF-06.1 | El sistema debe permitir a los usuarios autenticados cancelar sus propias reservas activas. |
| RF-06.2 | El sistema debe impedir que un usuario cancele reservas pertenecientes a otros usuarios. |
| RF-06.3 | El sistema debe impedir que una reserva previamente cancelada sea cancelada nuevamente. |
| RF-06.4 | El sistema debe actualizar el estado de una reserva a cancelada cuando la operación se complete correctamente. |
| RF-06.5 | El sistema debe bloquear temporalmente durante 5 minutos los asientos asociados a una reserva cancelada. |
| RF-06.6 | El sistema debe liberar los asientos bloqueados una vez transcurridos los 5 minutos. |
| RF-06.7 | El sistema debe permitir al usuario que canceló la reserva recuperar sus asientos durante el período de bloqueo mediante una nueva reserva. |

#### RF-07: Modificación de reservas 

| Código | Requisito funcional |
|---|---|
| RF-07.1 | El sistema debe permitir a los usuarios autenticados modificar los asientos de sus reservas activas. |
| RF-07.2 | El sistema debe verificar la disponibilidad de los nuevos asientos antes de confirmar una modificación. |
| RF-07.3 | El sistema debe bloquear temporalmente durante 5 minutos los asientos liberados mediante una modificación. |
| RF-07.4 | El sistema debe permitir al propietario de la reserva recuperar sus asientos anteriores durante el período de bloqueo. |
| RF-07.5 | El sistema debe liberar automáticamente los asientos bloqueados cuando transcurran los 5 minutos. |
| RF-07.6 | El sistema debe impedir que otros usuarios reserven asientos temporalmente bloqueados. |
| RF-07.7 | El sistema debe garantizar que la modificación de una reserva se realice de manera atómica. |

##### **OBSERVACIÓN**

Los datos iniciales de películas, salas, asientos y funciones serán incorporados mediante mecanismos de carga inicial de datos (*Data Seeding*), sin requerir una interfaz administrativa.

---


### 3.2 Requisitos no funcionales

Los requisitos no funcionales establecen las condiciones de calidad, seguridad y rendimiento que debe cumplir CineXera.

#### RNF-01: Seguridad

| Código | Requisito no funcional |
|---|---|
| RNF-01.1 | Las contraseñas de los usuarios deben almacenarse mediante un algoritmo de hashing seguro. |
| RNF-01.2 | El sistema debe utilizar JWT para autenticar y autorizar el acceso a los recursos protegidos. |
| RNF-01.3 | La comunicación entre el cliente y la API debe realizarse mediante HTTPS. |

#### RNF-02: Rendimiento

| Código | Requisito no funcional |
|---|---|
| RNF-02.1 | Las consultas de cartelera y funciones deben responder en menos de 3 segundos bajo condiciones normales de uso. |
| RNF-02.2 | El sistema debe mantener la integridad de las reservas ante solicitudes concurrentes. |

#### RNF-03: Usabilidad

| Código | Requisito no funcional |
|---|---|
| RNF-03.1 | La interfaz debe ser adaptable a dispositivos móviles y computadoras. |
| RNF-03.2 | El sistema debe mostrar mensajes claros ante errores de validación y operaciones fallidas. |

#### RNF-04: Mantenibilidad

| Código | Requisito no funcional |
|---|---|
| RNF-04.1 | El backend debe seguir la arquitectura Onion, manteniendo separadas las responsabilidades de cada capa. |
| RNF-04.2 | El código debe mantener una estructura organizada, legible y consistente. |

#### RNF-05: Compatibilidad

| Código | Requisito no funcional |
|---|---|
| RNF-05.1 | La aplicación web debe funcionar correctamente en las versiones recientes de Chrome, Firefox y Edge. |


