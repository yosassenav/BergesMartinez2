# Object Pool

Es un patrón de diseño de software que usa un conjunto de objetos inicializados preparados para su uso. Esto es más efectivo normalmente 
que ir creando y destruyendo los objetos bajo demanda. Un cliente del 
pool le pedirá un objeto para realizar las operaciones con el objeto. Cuando 
el cliente termina retorna el objeto al pool para que lo retenga hasta 
que vuelva a necesitar usarse. Es decir, los objetos no se crean (salvo
la primera vez) ni se destruyen, simplemente se van reciclando.

**Cuándo usarlo**

Cuando es necesario trabajar con un gran número de objetos que son 
particularmente costosos para instanciar y cada objeto solo se necesita 
durante un corto período de tiempo, ya que esto hace que el rendimiento 
de una aplicación completa puede verse afectado negativamente y al 
utilizar este patrón se puede evitar que eso ocurra. 


**Ejemplos de implementaciones**

Es común usar los Object Pools para la creación de recursos gráficos, 
conexiones a base de datos, sockets y en general cualquier objeto cuya 
creación es costosa. En ciertas ocasiones el uso de este patrón es más 
costoso.
