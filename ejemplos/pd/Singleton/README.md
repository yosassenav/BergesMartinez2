# Singleton

Es un patrón de diseño del tipo creacional cuyo propósito es 
garantizar la existencia de una sola instancia de una clase. Además el 
acceso a esa única instancia tiene que ser global. En C# la instrucción 
que contiene la palabra “new” sólo se puede ejecutar una vez, así nos 
aseguramos que sólo existe una instancia.

**Desventajas:**

* Esconden las dependencias de tu aplicación en tu código, en lugar de 
exponerlas a través de las interfaces.
 
* Violan el principio de responsabilidad única (SRP: Single 
Reponsability Principle) porque tienen dos responsabilidades: 1) 
controlar su ciclo de vida, 2) realizar el trabajo para el que se han diseñado.
 
* Implícitamente generan código acoplado. Esto dificulta la creación de 
“Moks” en tests unitarios.
 
* Si la clase tiene estado, ese estado es global y está presente durante 
todo el ciclo de vida de la aplicación. Lo cual es otro duro golpe a los 
test unitarios, puesto que los resultados podrían variar dependiendo del 
orden de ejecución de los tests unitarios.

**Cuándo usarlo**

Se utiliza cuando necesitamos asegurarnos de que solo se
creará una instancia de una clase en particular y luego proporcionar 
acceso global simple a esa instancia para toda la aplicación.

**Ejemplos de implementaciones**

* Proxies de servicio: como sabemos, invocar una API de servicio es una 
operación extensa en una aplicación. El proceso que lleva la mayor parte 
del tiempo es crear el cliente del Servicio para invocar la API del 
servicio. Si crea el proxy de servicio como Singleton, mejorará el 
rendimiento de su aplicación.

* Fachadas: también puede crear las conexiones de la base de datos como 
Singleton, lo que puede mejorar el rendimiento de la aplicación.

* Uso compartido de datos: si tiene valores constantes o valores de
configuración, puede mantener estos valores en Singleton para que otros
componentes de la aplicación puedan leerlos.

* Registros: en una aplicación, realizar la operación de E / S en un 
archivo es una operación costosa. Si crea su Logger como Singleton, 
mejorará el rendimiento de la operación de E / S.

* Almacenamiento en caché: como sabemos, recuperar los datos de una base 
de datos es un proceso lento. En su aplicación, puede almacenar en caché 
el maestro y la configuración en la memoria, lo que evitará las llamadas 
a la base de datos. En tales situaciones, la clase Singleton se puede 
usar para manejar el almacenamiento en caché con sincronización de 
subprocesos de una manera eficiente que mejora drásticamente el 
rendimiento de la aplicación.

