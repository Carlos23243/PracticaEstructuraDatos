# PracticaEstructuraDatos
# Implementación de Árboles Binarios de Búsqueda (BST) - Guía #04

Este proyecto corresponde a la **Guía de Prácticas #04** de la asignatura de **Estructura de Datos** de la Universidad Estatal Amazónica (UEA). El objetivo principal es la implementación y representación de estructuras no lineales para la resolución de problemas de ordenamiento y búsqueda eficiente.

## 📋 Descripción del Proyecto
La solución desarrollada en **C#** permite gestionar un Árbol Binario de Búsqueda alimentado por una fuente de datos externa (archivo `.txt`). El sistema es capaz de:
* Cargar datos dinámicamente desde un archivo plano.
* Organizar la información jerárquicamente siguiendo las reglas de un BST.
* Generar reportes de visualización mediante recorridos en **Inorden**.
* Analizar métricas de rendimiento en tiempo real (milisegundos).

## 🛠️ Tecnologías Utilizadas
* **Lenguaje:** C# (.NET 6.0 / 8.0)
* **IDE:** Visual Studio 2022
* **Estructura:** Árboles Binarios de Búsqueda (BST)
* **Manejo de Nulos:** Nullable Reference Types para mayor seguridad de memoria.

## 🚀 Instalación y Ejecución
1.  Clona este repositorio:
    ```bash
    git clone [https://github.com/tu-usuario/nombre-del-repo.git](https://github.com/tu-usuario/nombre-del-repo.git)
    ```
2.  Abre el archivo `.sln` en Visual Studio.
3.  Asegúrate de que el archivo `datos_arbol.txt` se encuentre en la carpeta de ejecución o raíz del proyecto.
4.  Ejecuta el proyecto (F5).

## 📊 Análisis Técnico
* **Ventajas:** La estructura permite una complejidad de búsqueda de $O(\log n)$, optimizando significativamente el tiempo de respuesta en comparación con estructuras lineales.
* **Rendimiento:** Se utiliza la clase `Stopwatch` para garantizar que el análisis de tiempo de ejecución sea preciso, cumpliendo con los estándares de la guía de práctica.

## 🤖 Uso de IA
Para el desarrollo de esta práctica, se utilizó un agente de IA para el **35%** del código, específicamente en la optimización del manejo de excepciones y la corrección de advertencias de nulidad en el compilador.

---
**Autor:** Carlos Segundo Arce Batallas  
**Carrera:** Tecnologías de la Información - UEA  
**Semestre:** Tercer Semestre  
**Período:** 2025-2026
