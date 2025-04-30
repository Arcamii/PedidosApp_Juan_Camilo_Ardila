**PEDIDOSAPP**

**Juan Camilo Ardila**

**Propósito**
El propósito de la aplicación es poder realizar pedidos y que estos se puedan identificar por tipo de mercancía que se solicita, haciendo también una diferenciación en que tipo de tranporte se llevará a cabo
esto dependiendo del tipo de mercancía, su peso, distancia y de si la entrega es urgente o no; y llevar un registro de los pedidos realizados por medio del historial de los mismos.

**Funcionalidades**
El código está compuesto por diferentes clases basadas en patrones Factory para la selección del transporte y el cálculo de la tarifa final; y el patrón singleton para centralizar el almacenamiento de todos los pedidos realizados y así mismo llevar un registro
de dichos pedidos.
Se hace uso de los principios SOLID durante el desarrollo de las funcionalidades, el cual se puede ver por ejemplo en la implementación de Factory para generar una clase para cada funcionalidad que esta a su vez se selecciona por medio de una clase interfaz.

El sistema permite la entrega de pedidos por medio de bicicleta, motocicleta, camión y drón; esto dependiendo de distintos factores anteriormente mencionados. Se permite también el almacenamiento del registro de los pedidos y exhibición de los mismos por
medio de un formulario que funciona como historial y el cual muestra dichos pedidos realizados.

**Ejecución**
El sistema es muy amigable y sencillo de usar. Se deben llenar los campos en su totalidad y seleccionar el botón "Calcular" para hacer la operación, seguido de esto se mostrará el tipo de vehículo de entrega y el costo total de la transacción.
Para ingresar al historial se selecciona el botón "Historial de pedidos", allí se pueden validar todos los pedidos realizados durante la sesión y/o filtrarlos por medio del combo box "Filtrar por:".

Para salir del sistema solo se necesita cerra las ventanas.



