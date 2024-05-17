Estudiate: Radhames Emil Ventura Paniagua
Matricula: 1116252

# Requerimientos, Criterios, Casos

1. ¿Qué es un Coding Dojo? referencia [https://lorenzosolano.com/what-is-coding-dojo/](https://lorenzosolano.com/what-is-coding-dojo/)

Un coding Dojo es una reunión donde un grupo de programadores se juntan para trabajar juntos en la resolución de un problema de programación. El objetivo es que cada programador haga práctica deliberada para poder mejorar sus habilidades.

2. Diferencia entre Requerimientos, Criterios de Aceptación y Escenarios de Prueba. Dar ejemplos a partir de un problema distinto a la referencia. Referencia [https://lorenzosolano.com/requirements-acceptance-criteria-and/](https://lorenzosolano.com/requirements-acceptance-criteria-and/)

- **Requerimiento**: - Se puede interpretar como una propiedad que debe cumplir el producto para resolver una problemática.
  Ejemplo:

- **Criterios de aceptación** - Los criterios de aceptación son aquellas características que permiten indicar si se cumple el requerimiento
  Ejemplo:

- **Escenarios de prueba** - Es una serie de ejemplos que indican si se cumple un criterio de aceptación
  Ejemplo:

3. De dos ejemplos de requerimientos no-funcionales, y especifique cual es su categoría (seguridad, performance, portabilidad, etc.)

- La aplicación debe de estar disponible por lo menos 20h al día. (Requerimiento de disponibilidad)
- El sistema debe cerrar las transacciones luego de máximo 10 minutos de inactividad. (requerimiento de seguridad)

4. ¿Qué es TDD?

El test driven development (TDD) o en español desarrollo guiado por pruebas, es un enfoque de programación que se utiliza durante el desarrollo de software en el que se realizan pruebas unitarias antes de escribir el código.

Fases:

- **Desarrollo y Escritura de la prueba:**
- **Validación de las pruebas:**
- **Refactorización:**

(¿Qué es y para qué sirve un TDD o Test Driven Development?,[ Intelequia](https://intelequia.com/es/blog/post/qu%C3%A9-es-y-para-qu%C3%A9-sirve-un-tdd-o-test-driven-development#:~:text=%C2%BFQu%C3%A9%20es%20Test%20Driven%20Development,antes%20de%20escribir%20el%20c%C3%B3digo.))

5. ¿Que son pruebas unitarias automatizadas?

Las pruebas automatizadas consisten en la aplicación de herramientas de software para automatizar el proceso manual de revisión y validación de un producto de software que lleva a cabo una persona.

6. ¿Cual fue el 1er framework de pruebas unitarias y para cual lenguaje fue creado?

SUnit desarrollado por Kent Belt, escrito en SmallTalk, un lenguaje de programacion orientado a objetos.

( A Brief History of Test Frameworks, [Shebanator](https://shebanator.com/2007/08/21/a-brief-history-of-test-frameworks/))

7. ¿Describa los componentes de la arquitectura xUnit?

- Setup: Preparar las condiciones necesarias para la prueba.
- Act: Ejecuta la unidad de codigo para probar
- Assert: Verifica la unidad de codigo actua como se esperaba
- Teardown: Limpiar cualquier recurso utilizado durante el test

8. Indique al menos tres desventajas de las pruebas unitarias automatizadas

- **Falsa sentido de calidad**: Las pruebas solo revisan lo que ya conocemos, pero los errores normalmente son cosas inesperadas.
- **No Siempre son Fiables**: Las pruebas se pueden romper y dar errores falsos.
- **Esfuerzo de mantenimiento**: Las pruebas, al igual que los programas, necesitan de mantenimiento. Por tanto, es un tiempo agregado a cada cambio que se realice.

9. Indique al menos tres ventajas de las pruebas unitarias automatizadas

- Eficiencia de recursos: Al no depender de una persona, después de diseñar son poco propensas a errores.
- Repetición continúa: Pueden utilizarse constantemente para asegurar que cada componente sigue funcionando correctamente.
- Precisión en la obtención de resultados: Después del diagnóstico, arrojan un reporte de la información analizada.

## 10. Tomando el algoritmo de conversión de números arábigos o "decimales" a números Romanos:

\* Cree un documento donde se listen los Requerimientos, Criterios de Aceptación y Casos de Prueba para una aplicación de consola

### Requerimientos

0 a 3999

#### Convertir una entrada de numero arabigos a numeros romanos.

##### Criterios de aceptacion

- Dar un numero romano cuando el usuario ingresa un numero decimal despues de presionar enter.

##### Casos de prueba

**CP1**

- Entrada 4
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "IV"

CP2:

- Entrada: 6
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "VI"

CP3:

- Entrada: 500
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "D"

CP4:

| Entrada              | Accion                                     | Resultado                             |
| -------------------- | ------------------------------------------ | ------------------------------------- |
| Carpeta del proyecto | Ejecutar convertidor.exe                   | El programa inicia y abre una consola |
| 4                    | Usuario ingresa el numero 4 en la consola  | La consola presenta "IV"              |
| 500                  | Usuario ingresa el numero y presiona enter | La consola presenta "D"               |
|                      |                                            |                                       |

CP5:
 
- Entrada: -10
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "Error: numero fuera de rango"
CP6:
 
- Entrada: 45
- Accion: Convertidor.ConvertirDecimalRomano(int numDecimal): string
- Resultado: "XLV"


#### Recibir una entrada numerico entera desde una consola.

\* Los casos de prueba deben ser de dos categorías: End-To-End (desde el UI) y Unitarios (caja blanca, código, bajo nivel)

11. Utilizando el lenguaje de su preferencia cree cinco o mas casos de prueba unitarios automatizados utilizando un framework de automatización de pruebas para el algoritmo en cuestion
