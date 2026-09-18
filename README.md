# 🛠️ TechStore — Patrones de Diseño Creacionales en C#

![.NET](https://img.shields.io/badge/.NET-8.0%20%7C%2010.0-512BD4?logo=dotnet)
![C#](https://img.shields.io/badge/Language-C%23-239120?logo=csharp)
![Architecture](https://img.shields.io/badge/Architecture-Design%20Patterns-blue)
![License](https://img.shields.io/badge/License-MIT-green)

Aplicación de consola desarrollada en **C#** para la gestión modular de pedidos e inventario en la tienda **TechStore**.

Este proyecto demuestra la refactorización de un sistema inicialmente acoplado mediante la implementación de los **5 patrones creacionales del GoF (Gang of Four)**, buscando un código mantenible, escalable y alineado con los principios de **SOLID**.

---

## 📌 Tabla de Contenidos

* [Vista General del Proyecto](#-vista-general-del-proyecto)
* [Objetivos](#-objetivos)
* [Arquitectura y Patrones Implementados](#-arquitectura-y-patrones-implementados)

  * [Factory Method](#1--factory-method)
  * [Builder](#2--builder)
  * [Singleton](#3--singleton)
  * [Abstract Factory](#4--abstract-factory)
  * [Prototype](#5--prototype)
* [Estructura del Repositorio](#-estructura-del-repositorio)
* [Tecnologías Utilizadas](#-tecnologías-utilizadas)
* [Instalación y Ejecución](#-instalación-y-ejecución)
* [Demostración del Menú Interactivo](#-demostración-del-menú-interactivo)
* [Relación con SOLID](#-relación-con-solid)
* [Conclusiones](#-conclusiones)
* [Autor](#-autor)
* [Licencia](#-licencia)

---

## 🚀 Vista General del Proyecto

**TechStore** es una aplicación de consola orientada a la gestión de procesos relacionados con una tienda de tecnología.

El sistema contempla diferentes operaciones relacionadas con:

* 🛒 Creación y gestión de pedidos.
* 📦 Gestión de entregas y empaques.
* 💻 Configuración de equipos tecnológicos.
* 🔔 Envío de notificaciones.
* 💳 Procesamiento de pagos.
* 📊 Generación de reportes.
* ☁️ Integración conceptual con servicios Cloud.
* 📝 Registro y auditoría de eventos.
* 📋 Creación de objetos a partir de plantillas.

El diseño original fue refactorizado progresivamente para reducir el acoplamiento entre las clases, utilizando **interfaces, abstracciones, fábricas y mecanismos controlados de creación de objetos**.

---

## 🎯 Objetivos

Los principales objetivos del proyecto son:

1. Implementar los **5 patrones creacionales del GoF**.
2. Reducir el acoplamiento entre componentes.
3. Separar la creación de objetos de su utilización.
4. Aplicar principios de diseño orientado a objetos.
5. Favorecer la reutilización de código.
6. Facilitar la extensión del sistema con nuevas implementaciones.
7. Aplicar conceptos relacionados con los principios **SOLID**.
8. Integrar los diferentes patrones en una aplicación funcional de consola.

---

# 🏗️ Arquitectura y Patrones Implementados

El proyecto está organizado en **5 módulos principales**, cada uno correspondiente a uno de los patrones creacionales definidos por el **Gang of Four (GoF)**.

---

## 1. 🏭 Factory Method

📁 `Patrones/A_FactoryMethod`

El patrón **Factory Method** permite delegar la creación de objetos a métodos especializados, evitando que el código cliente dependa directamente de las clases concretas que necesita instanciar.

### Aplicaciones en TechStore

#### 🔔 Notificaciones

Permite generar diferentes tipos de notificaciones:

* `Email`
* `SMS`
* `WhatsApp`

La aplicación puede seleccionar el mecanismo de comunicación sin que el código cliente tenga que conocer directamente la implementación concreta.

#### 📊 Reportes

Permite generar diferentes formatos de reportes:

* `PDF`
* `EXCEL`
* `CSV`

Esto facilita agregar nuevos formatos posteriormente sin modificar considerablemente la lógica existente.

#### 💳 Pagos

Permite procesar diferentes modalidades de pago:

* `Tarjeta`
* `Transferencia`
* `Efectivo`

### Beneficios

* Reduce el acoplamiento.
* Centraliza la creación de objetos.
* Facilita la incorporación de nuevas implementaciones.
* Favorece el principio **Open/Closed**.

---

## 2. 🧱 Builder

📁 `Patrones/B_Builder`

El patrón **Builder** permite construir objetos complejos paso a paso, evitando constructores con demasiados parámetros y permitiendo configurar solamente las propiedades necesarias.

La implementación utiliza una interfaz fluida mediante **Method Chaining**.

### Aplicaciones en TechStore

#### 🛒 Pedidos

Permite construir pedidos de diferentes niveles de complejidad:

* Pedido mínimo.
* Pedido completo.
* Pedido personalizado.

Por ejemplo, conceptualmente:

```csharp
var pedido = new PedidoBuilder()
    .ConCliente("Cliente")
    .ConProducto("Laptop")
    .ConCantidad(2)
    .ConDireccion("Ambato")
    .Build();
```

#### 💻 Computadoras

Permite configurar equipos para diferentes perfiles:

* `Oficina`
* `Gaming`

Cada configuración puede incluir componentes diferentes según las necesidades del usuario.

#### 📦 Paquetes de Entrega

Permite construir paquetes logísticos en modalidades:

* `Normal`
* `Premium`

### Beneficios

* Facilita la creación de objetos complejos.
* Mejora la legibilidad.
* Evita constructores excesivamente grandes.
* Permite diferentes configuraciones del mismo tipo de objeto.

---

## 3. 🔒 Singleton

📁 `Patrones/C_Singleton`

El patrón **Singleton** garantiza que exista una única instancia de una determinada clase durante el ciclo de vida de la aplicación.

En este proyecto se utiliza `Lazy<T>` para realizar una inicialización segura y **Thread-Safe**.

### Aplicaciones en TechStore

#### 📝 Bitácora

Mantiene un único registro centralizado de eventos y acciones del sistema.

Permite almacenar información relacionada con:

* Eventos.
* Operaciones.
* Auditoría.
* Mensajes del sistema.

#### ⚙️ Configuración Global

Centraliza configuraciones generales de la aplicación como:

* Moneda.
* Nombre de la tienda.
* Variables de entorno.
* Parámetros globales.

#### 🔢 Contador de Pedidos

Permite controlar métricas acumulativas relacionadas con la cantidad de pedidos procesados.

### Beneficios

* Garantiza una única instancia.
* Proporciona acceso controlado a recursos compartidos.
* Utiliza inicialización segura mediante `Lazy<T>`.
* Centraliza información global de la aplicación.

> ⚠️ El patrón Singleton debe utilizarse con criterio, especialmente cuando una dependencia global puede dificultar las pruebas unitarias o aumentar el acoplamiento.

---

## 4. 🏢 Abstract Factory

📁 `Patrones/D_AbstractFactory`

El patrón **Abstract Factory** permite crear **familias de objetos relacionados** sin especificar directamente sus clases concretas.

En TechStore se utiliza para coordinar diferentes productos que deben pertenecer a una misma familia.

### Aplicaciones en TechStore

#### 📦 Familias de Venta

Permite coordinar conjuntamente:

* Entrega.
* Empaque.

Las familias disponibles incluyen:

* `Normal`
* `Premium`
* `Corporativa`

Esto permite garantizar que los productos creados sean compatibles entre sí.

#### 💻 Proveedores Tecnológicos

Permite crear familias de equipamiento tecnológico de diferentes marcas:

* `Dell`
* `Lenovo`

Cada fábrica puede producir los componentes correspondientes a su familia tecnológica.

#### ☁️ Infraestructura Cloud

Permite abstraer diferentes proveedores Cloud:

### AWS

* `S3`
* `SQS`

### Azure

* `Blob Storage`
* `Service Bus`

El código cliente trabaja con las abstracciones y no necesita conocer los detalles de implementación de cada proveedor.

### Beneficios

* Crea familias de objetos relacionados.
* Mantiene la compatibilidad entre productos.
* Reduce la dependencia de implementaciones concretas.
* Facilita cambiar de una familia tecnológica a otra.

---

## 5. 📑 Prototype

📁 `Patrones/E_Prototype`

El patrón **Prototype** permite crear nuevos objetos mediante la clonación de objetos existentes.

Es especialmente útil cuando crear un objeto desde cero resulta más costoso o cuando se desea utilizar una configuración previamente establecida como plantilla.

### Aplicaciones en TechStore

#### 🛒 Pedido Base

Permite generar nuevos pedidos a partir de pedidos utilizados como plantillas.

Esto evita reconstruir manualmente configuraciones que se repiten.

#### 🧪 Equipos de Laboratorio

Permite duplicar configuraciones de equipos para diferentes laboratorios:

* `LAB-A`
* `LAB-B`
* `LAB-C`

Cada laboratorio puede partir de una configuración base y posteriormente realizar sus propias modificaciones.

#### 🖥️ Servidores — Deep Copy

Se implementa clonación profunda para garantizar que los objetos internos también sean independientes.

Por ejemplo:

```text
Servidor
│
├── Nombre
├── CPU
├── RAM
└── ConfiguracionRed
    ├── IP
    ├── Mascara
    └── Gateway
```

Al realizar una copia profunda, modificar `ConfiguracionRed` del servidor clonado no debe afectar al servidor original.

### Beneficios

* Facilita la creación de objetos similares.
* Permite utilizar objetos existentes como plantillas.
* Reduce la necesidad de reconstrucción manual.
* La clonación profunda evita referencias compartidas no deseadas.

---

# 📂 Estructura del Repositorio

```text
TechStoreAppTaller/
│
├── Program.cs
│   └── Menú principal e integración de patrones
│
├── TechStoreAppTaller.csproj
│   └── Archivo de configuración del proyecto .NET
│
├── .gitignore
│   └── Archivos excluidos del control de versiones
│
└── Patrones/
    │
    ├── A_FactoryMethod/
    │   └── Ejercicios 01 - 04
    │
    ├── B_Builder/
    │   └── Ejercicios 05 - 08
    │
    ├── C_Singleton/
    │   └── Ejercicios 09 - 12
    │
    ├── D_AbstractFactory/
    │   └── Ejercicios 13 - 16
    │
    └── E_Prototype/
        └── Ejercicios 17 - 19
```

El ejercicio de integración general corresponde al **Ejercicio 20**, ubicado en `Program.cs`.

---

# 🛠️ Tecnologías Utilizadas

| Tecnología                           | Uso                         |
| ------------------------------------ | --------------------------- |
| **C#**                               | Lenguaje principal          |
| **.NET 8**                           | Framework de ejecución      |
| **.NET 10**                          | Compatibilidad              |
| **Programación Orientada a Objetos** | Diseño de la aplicación     |
| **Interfaces**                       | Abstracción de contratos    |
| **SOLID**                            | Principios de diseño        |
| **GoF Design Patterns**              | Patrones creacionales       |
| **Git**                              | Control de versiones        |
| **GitHub**                           | Alojamiento del repositorio |

---

# 💻 Instalación y Ejecución

## 📋 Requisitos Previos

Antes de ejecutar el proyecto se recomienda disponer de:

* **.NET SDK 8.0** o superior.
* Compatibilidad con **.NET 10** si se desea utilizar esta versión.
* **Visual Studio 2022**, **Visual Studio Code** o cualquier editor compatible.
* Git para clonar el repositorio.

---

## 1. 📥 Clonar el repositorio

```bash
git clone https://github.com/ManuelCusme/TECHSTOREAPP-TALLER-PR-CTICO-PATRONES-CREACIONALES.git
```

Posteriormente, ingresar al directorio del proyecto:

```bash
cd TechStoreAppTaller
```

---

## 2. 📦 Restaurar dependencias

Ejecutar:

```bash
dotnet restore
```

Este comando restaura las dependencias necesarias para compilar el proyecto.

---

## 3. 🔨 Compilar el proyecto

Para comprobar que el proyecto puede compilarse correctamente:

```bash
dotnet build
```

---

## 4. ▶️ Ejecutar la aplicación

Ejecutar:

```bash
dotnet run
```

La aplicación iniciará el menú interactivo de **TechStore**.

---

# 🖥️ Demostración del Menú Interactivo

El punto de entrada principal de la aplicación es `Program.cs`.

Desde este archivo se integran los diferentes patrones creacionales implementados en el proyecto.

El menú principal presenta opciones como las siguientes:

```text
========================================
               TECHSTORE
========================================
1. Crear pedido NORMAL
2. Crear pedido PREMIUM
3. Crear pedido CORPORATIVO
4. Crear pedido desde plantilla
5. Probar notificaciones
6. Probar Builder
7. Mostrar contador de pedidos
8. Mostrar configuración
0. Salir

Seleccione una opción:
```

### Opciones disponibles

| Opción | Funcionalidad                | Patrón relacionado |
| -----: | ---------------------------- | ------------------ |
|      1 | Crear pedido NORMAL          | Abstract Factory   |
|      2 | Crear pedido PREMIUM         | Abstract Factory   |
|      3 | Crear pedido CORPORATIVO     | Abstract Factory   |
|      4 | Crear pedido desde plantilla | Prototype          |
|      5 | Probar notificaciones        | Factory Method     |
|      6 | Probar Builder               | Builder            |
|      7 | Mostrar contador de pedidos  | Singleton          |
|      8 | Mostrar configuración        | Singleton          |
|      0 | Salir                        | —                  |

---

# 🔗 Relación entre los Patrones

Los patrones no funcionan como módulos completamente aislados. La aplicación los integra para representar un flujo de trabajo coherente.

Una representación simplificada sería:

```text
                         ┌─────────────────────┐
                         │      TechStore      │
                         └──────────┬──────────┘
                                    │
              ┌─────────────────────┼─────────────────────┐
              │                     │                     │
              ▼                     ▼                     ▼
       Factory Method           Builder              Singleton
              │                     │                     │
       ┌──────┼──────┐        ┌─────┴─────┐       ┌──────┼──────┐
       │      │      │        │           │       │      │      │
     Email   SMS  WhatsApp  Pedido   Computadora  Log  Config. Contador
       │      │      │        │           │
       └──────┼──────┘        └───────────┘
              │
              ▼
       Reportes / Pagos


                   Abstract Factory
                          │
            ┌─────────────┼─────────────┐
            ▼             ▼             ▼
         Normal        Premium     Corporativa
            │             │             │
            └─────────────┼─────────────┘
                          │
                          ▼
                 Familias relacionadas


                     Prototype
                         │
            ┌────────────┼────────────┐
            ▼            ▼            ▼
       Pedido Base   Laboratorio   Servidor
                                      │
                                      ▼
                               Deep Copy
```

---

# 🧩 Principios de Diseño Aplicados

La implementación de los patrones busca mantener una arquitectura orientada a la separación de responsabilidades y al bajo acoplamiento.

## 🔹 Single Responsibility Principle — SRP

Cada clase debe concentrarse en una responsabilidad específica.

Por ejemplo:

* Una fábrica se encarga de crear objetos.
* Un Builder se encarga de construir un objeto complejo.
* Un Singleton administra un recurso compartido.
* Un Prototype se encarga de proporcionar mecanismos de clonación.

---

## 🔹 Open/Closed Principle — OCP

El sistema está diseñado para facilitar la incorporación de nuevas implementaciones sin modificar continuamente el código cliente.

Por ejemplo, se pueden agregar nuevos tipos de notificación o pago implementando las abstracciones correspondientes.

---

## 🔹 Liskov Substitution Principle — LSP

Las implementaciones concretas deben poder utilizarse mediante sus abstracciones sin alterar el comportamiento esperado por el código cliente.

---

## 🔹 Interface Segregation Principle — ISP

Las interfaces deben representar contratos específicos y evitar obligar a las clases a implementar funcionalidades que no necesitan.

---

## 🔹 Dependency Inversion Principle — DIP

El código de alto nivel debe depender de abstracciones en lugar de depender directamente de implementaciones concretas.

Esto resulta especialmente importante en:

* Factory Method.
* Abstract Factory.
* Builder.
* Servicios de notificación.
* Sistemas de pago.
* Proveedores Cloud.

---

# 📊 Resumen de los 5 Patrones

| Patrón                  | Problema que resuelve                                                            | Aplicación en TechStore            |
| ----------------------- | -------------------------------------------------------------------------------- | ---------------------------------- |
| 🏭 **Factory Method**   | Controlar la creación de un producto sin acoplar al cliente a una clase concreta | Notificaciones, reportes y pagos   |
| 🧱 **Builder**          | Construir objetos complejos paso a paso                                          | Pedidos, computadoras y paquetes   |
| 🔒 **Singleton**        | Garantizar una única instancia                                                   | Bitácora, configuración y contador |
| 🏢 **Abstract Factory** | Crear familias de objetos relacionados                                           | Ventas, proveedores y Cloud        |
| 📑 **Prototype**        | Crear objetos mediante clonación                                                 | Pedidos, laboratorios y servidores |

---

# 🧪 Ejercicios Implementados

| Ejercicios  | Patrón           | Módulo              |
| ----------- | ---------------- | ------------------- |
| **01 - 04** | Factory Method   | `A_FactoryMethod`   |
| **05 - 08** | Builder          | `B_Builder`         |
| **09 - 12** | Singleton        | `C_Singleton`       |
| **13 - 16** | Abstract Factory | `D_AbstractFactory` |
| **17 - 19** | Prototype        | `E_Prototype`       |
| **20**      | Integración      | `Program.cs`        |

---

# 📈 Ventajas de la Arquitectura

La utilización conjunta de los patrones creacionales permite:

* ✅ Reducir el acoplamiento.
* ✅ Separar la creación de objetos de la lógica de negocio.
* ✅ Mejorar la reutilización del código.
* ✅ Facilitar la incorporación de nuevas funcionalidades.
* ✅ Mejorar la mantenibilidad.
* ✅ Facilitar las pruebas de componentes.
* ✅ Aplicar abstracciones mediante interfaces.
* ✅ Evitar dependencias innecesarias de clases concretas.
* ✅ Representar diferentes configuraciones mediante Builders y Prototypes.
* ✅ Gestionar familias completas de productos mediante Abstract Factory.

---

# 📝 Conclusiones

El proyecto **TechStore** demuestra cómo los patrones creacionales del **Gang of Four** pueden utilizarse para resolver diferentes problemas relacionados con la creación y configuración de objetos.

Cada patrón aborda una necesidad particular:

* **Factory Method** abstrae la creación de productos individuales.
* **Builder** permite construir objetos complejos de manera controlada.
* **Singleton** administra recursos que requieren una única instancia.
* **Abstract Factory** permite crear familias completas de objetos relacionados.
* **Prototype** permite reutilizar configuraciones existentes mediante clonación.

La combinación de estas técnicas permite construir una aplicación más modular y preparada para incorporar nuevas funcionalidades sin depender excesivamente de implementaciones concretas.

Además, el proyecto sirve como ejercicio práctico para comprender la relación entre los **patrones de diseño creacionales**, la **programación orientada a objetos** y los principios **SOLID**.

---

# 👤 Autor

**Manuel Cusme**
*Estudiante de Ingeniería de Software*
**Universidad Técnica de Ambato**

Proyecto desarrollado como parte del taller práctico de la asignatura **Patrones de Software**.

---

# 📄 Licencia

Este proyecto se distribuye bajo la licencia **MIT**.

Puedes consultar los términos de la licencia en el archivo `LICENSE` del repositorio.

---

<p align="center">
  <strong>🛠️ TechStore — Patrones Creacionales en C#</strong>
  <br>
  <sub>Proyecto académico de Ingeniería de Software</sub>
</p>
