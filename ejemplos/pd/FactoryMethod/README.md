# Factory Method

Es un patrón de diseño creacional que resuelve el problema de crear objetos de producto sin especificar sus clases 
concretas. Para cumplir con su propósito define un método, que debe usarse para crear objetos en 
lugar de la llamada de constructor directo ( newoperador). Las subclases
pueden anular este método para cambiar la clase de objetos que se crearán.

Cuándo usarlo:

* Una clase no puede anticipar qué objetos de clase debe crear.

* Una clase usa sus subclases para especificar qué objetos crea.

* Se necesita localizar el conocimiento de qué clase se crea.

Es muy útil para el desarrollo de aplicaciones.
