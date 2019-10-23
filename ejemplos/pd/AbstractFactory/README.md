

ABSTRACT FACTORY 

Definición:
El patrón Abstract Factory nos permite crear, mediante una interfaz, conjuntos o familias de objetos (denominados productos) que dependen mutuamente y todo esto sin especificar cuál es el objeto concreto.

Usos:
Este patrón se puede aplicar cuando:
Un sistema debe ser independiente de cómo sus objetos son creados.
Un sistema debe ser 'configurado' con una cierta familia de productos.
Se necesita reforzar la noción de dependencia mutua entre ciertos objetos.


Estructura:
La estructura típica del patrón Abstract Factory es la siguiente:
Cliente: La clase que llamará a la factoría adecuada ya que necesita crear uno de los objetos que provee la factoría, es decir, Cliente lo que quiere es obtener una instancia de alguno de los productos (ProductoA, ProductoB).
AbstractFactory: Es la definición de la interfaces de las factorías. Debe de proveer un método para la obtención de cada objeto que pueda crear. ("crearProductoA()" y "crearProductoB()")
Factorías Concretas: Estas son las diferentes familias de productos. Provee de la instancia concreta de la que se encarga de crear. De esta forma podemos tener una factoría que cree los elementos gráficos para Windows y otra que los cree para Linux, pudiendo poner fácilmente (creando una nueva) otra que los cree para MacOS, por ejemplo.
Producto abstracto: Definición de las interfaces para la familia de productos genéricos. En el diagrama son "ProductoA" y "ProductoB". En un ejemplo de interfaces gráficas podrían ser todos los elementos: Botón, Ventana, Cuadro de Texto, Combo... El cliente trabajará directamente sobre esta interfaz, que será implementada por los diferentes productos concretos.
Producto concreto: Implementación de los diferentes productos. Podría ser por ejemplo "BotónWindows" y "BotónLinux". Como ambos implementan "Botón" el cliente no sabrá si está en Windows o Linux, puesto que trabajará directamente sobre la superclase o interfaz.


Ventajas/Desventajas:
+ Brinda flexibilidad al aislar a las clases concretas.
+ Facilita cambiar las familias de productos.
- Para agregar nuevos productos se deben modificar tanto las fábricas abstractas como las concretas.
