# Simple Factory

La definición del patrón Simple Factory establece que "una fábrica es un 
objeto que se utiliza para crear otros objetos". En términos técnicos, 
podemos decir que una fábrica es una clase con un método. Ese método 
creará y devolverá diferentes tipos de objetos basados ​​en el parámetro 
de entrada recibido.

Es una forma de abstracción, que oculta la lógica real de implementación 
de un objeto para que el código de inicialización pueda centrarse en el 
uso, en lugar del funcionamiento interno.

**Cuándo usarlo:**
Este patrón es útil cuando los "switch/else-if" se empiezan repetir en varios lugares de nuestro código porque nos permite 
encapsular la creación de objetos.

**Ventajas**

* Es muy fácil de implementar.

* El código del usuario permanece sin cambios cuando agregamos nuevas 
clases.
 

* Se puede saber qué subclases se emplean

**Desventajas**

* Si se requiere añadir una nueva subclase, entonces se necesita una 
nueva condición if-else en el método de la clase Factory. Esto viola el 
principio de diseño abierto / cerrado.

* También tenemos un acoplamiento estrecho entre la clase Factory y las 
clases de productos.

