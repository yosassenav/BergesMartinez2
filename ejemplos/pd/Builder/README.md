
Patrón Builder

Teoría para equipo de vane y regina
Definición:
El patrón de diseño Builder permite crear objetos que habitualmente son complejos utilizando otro objeto más simple que los construye paso por paso.

Uso:
Este patrón Builder se utiliza en situaciones en las que debe construirse un objeto repetidas veces o cuando este objeto tiene gran cantidad de atributos y objetos asociados, y en donde usar constructores para crear el objeto no es una solución cómoda.

Es bastante útil también en la ejecución de test (unit test por ejemplo) en donde debemos crear el objeto con atributos válidos o por defecto

Elementos:
La interfaz IBuilder de la cual implementaremos el / los Builder/s (Se necesita un objeto Builder que creará el objeto que se concrete en base a parámetros que le vayan pasando paso por paso.)
La implementación de la interfaz builder que implementar el método build y que contiene el resto de métodos que recibirán los parámetros necesarios para construir el objeto final (Como buena práctica buena práctica crear una interfaz con un método build que nos devolverá el objeto que deseamos.).
