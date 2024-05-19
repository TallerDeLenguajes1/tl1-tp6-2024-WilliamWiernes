# Ejercicio 4
### :question: ¿String es una tipo por valor o un tipo por referencia?

:black_nib: `String` es un tipo de dato por *referencia*.

### :question: ¿Qué secuencias de escape tiene el tipo string?

:black_nib: El tipo `String` admite varias secuencias de escape, entre ellas:
- `\n`: Nueva línea
- `\t`: Tabulación
- `\'`: Comilla simple
- `\"`: Comilla doble
- `\\`: Barra invertida

### :question: ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

:black_nib: Cuando se utiliza el `@`, la cadena de texto se convierte a _literal_, donde cualquier secuencia de escape se interpreta literalmente.  
En el caso del `$`, la cadena queda convertida a _interpolada_, pudiendo incluir expresion de código entre llaves "{}", dichas expresiones se evalúan para ser incluidas en la cadena de texto resultante.