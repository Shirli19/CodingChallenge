# CodingChallenge

## El problema
Tenemos un método que genera un reporte en base a una colección de formas geométricas, procesando algunos datos para presentar información extra. La firma del método es:

```
public static string Imprimir(List<FormaGeometrica> formas, int idioma)
```

Al mismo tiempo, encontramos muy díficil el poder agregar o bien una nueva forma geométrica, o imprimir el reporte en otro idioma. Nos gustaría poder dar soporte para que el usuario pueda agregar otros tipos de formas u obtener el reporte en otros idiomas, pero extender la funcionalidad del código es muy doloroso. ¿Nos podrías dar una mano a refactorear la clase FormaGeometrica? Dentro del código encontrarás un TODO con nuevos requerimientos a satisfacer una vez completada la refactorización.

Acompañando al proyecto encontrarás una serie de tests unitarios (librería NUnit) que describen el comportamiento del método Imprimir. Se puede modificar cualquier cosa del código y de los tests, con la única condición que los tests deben pasar correctamente al entregar la solución.

Se agradece también la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada.

## La solución

### Figuras
Para simplificar el agregado/quitado de una nueva forma geométrica se modificó la forma en que se encontraba implementado. Para esto se creó una clase base *FormaGeometrica* de la cual heredaran todas las figuras existentes y nuevas.

Cada figura se encuentra representada en una clase, de forma tal que esto permite que si se desea crear una nueva figura simplemente se crea una nueva clase y se implementa el cálculo del área y del perímetro propios de la misma. Además, al dividir las figuras en clase cada figura puede tener ahora sus propios atributos permitiendo crear, por ejemplo, triángulos de distintos lados.

Un atributo en común que poseen las diferentes figuras es que cada una tendrá su propio nombre. Este nombre nos servirá para luego buscar en nuestro "diccionario" el nombre de la figura dependiendo del idioma que haya seleccionado el usuario.


Nota: Se agregaron como figuras nuevas el rectángulo y el trapecio.

### Idioma

Para simplificar el agregado/quitado de un nuevo idioma se modificó la forma en que se encontraba implementado. Para esto se creó una interfaz *IIdioma* que nos permitirá asegurarnos que el nuevo idioma que se agregue devuelva las oraciones bases requeridas actualmente. Además, en un futuro si se requiere imprimir una nueva oración simplemente se deberá agregar en esta interfaz el nuevo requerimiento y de esta forma nos aseguraremos de que todos los idiomas deban ahora definirlo y asi asegurar que cumplan con el nuevo requerimiento.

En esta nueva implementación cada idioma es una clase. En caso de querer agregar un nuevo idioma simplemente deberemos crear una nueva clase que implemente la interfaz *IIdioma* e implementar los métodos requeridos.

Se agrego dentro de cada idioma una especie de diccionario de forma tal de poder tener almacenados el nombre de las distintas figuras. Esta es una primera implementación, pero no es la más optima.

Nota: Se agregaron los idiomas Alemán e Italiano.

Nota 2: Pido disculpas si alguna de las palabras utilizadas en estos idiomas no es correctas.

### Test
Finalmente se agregaron nuevos Test, dividiéndolos a modo de simplificar la visualización de cada uno en: 
- Un test dedicado a la validación del cálculo del área y del perímetro de cada figura. Ya que solo se busca la validación del cálculo se hizo uso de una sola figura y en el idioma castellano.
- Un test dedicado a la validación de los diferentes idiomas. Ya que solo se busca la validación de las oraciones impresas se hizo uso de una sola figura.
- El test que ya venía en la solución. A este se le agregó nuevos métodos que permitían validar el funcionamiento para más figuras en los nuevos idiomas, y la validación para todos los idiomas cuando la lista de figuras este vacía.


