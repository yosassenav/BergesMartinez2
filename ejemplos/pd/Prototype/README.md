# Prototype

El concepto de este patrón es simple: en lugar de crear un objeto, se 
clona, es decir, se realiza una copia exacta de otro objeto dado, 
denominado prototipo.

Entran en juego tres elementos:

* Cliente: clase que solicita al prototipo que se clone.

* IPrototipo: interfaz o clase abstracta que define la operación de 
clonado.

* PrototipoConcreto: implementa IPrototipo y su método Clone() para 
proceder al clonado del objeto.

El proceso de clonado comienza instanciando una clase de forma habitual. 
Una vez que disponemos de una instancia funcional, el resto de 
instancias se generarán creando copias de la primera.

La forma de aplicar este patrón es simple:

* Se define una interfaz que expondrá el método utilizado para realizar 
el clonado del objeto.

* Las clases que realicen el clonado utilizarán este método para esta 
operación.

**Cuándo usarlo**

Este patrón es útil en casos en los que el coste de generar 
una nueva instancia sean altos en comparación al coste de realizar una 
copia de una instancia ya existente.

**Ejemplos de implementaciones**

Si se tiene una clase que se encarga de almacenar datos de una 
sesión web es buena idea emplear este patrón, ya que al instanciar esta 
clase, el objeto se comunica con un servidor externo para realizar un proceso de autenticación mediante unas credenciales. 
Este proceso es costoso, por lo que si a lo largo de la ejecución del 
programa fuese necesario instanciar un nuevo objeto con los mismos 
datos, el proceso de instanciación requerirá consumir una gran cantidad 
de recursos. Con Prototype es más sencillo realizar una copia exacta del 
objeto anterior, evitando de este modo acceder a un servidor externo para 
rellenar el objeto actual.

Se puede sustituir el proceso de conectar a otro servidor por 
cualquier otro proceso de alto coste computacional, como operaciones de 
acceso de base de datos o procesamiento de algoritmos complejos. Siempre que 
se requiera instanciar un objeto cuyos datos han sido obtenidos previamente podemos recurrir a este patrón para evitar el proceso de 
instanciado realizando una copia de un objeto existente.

Otro posible escenario en el que este patrón es útil puede ser cuando 
sea necesario “salvar” el estado de un objeto en un determinado momento 
realizando una copia del mismo.

