# Crédito
## TL;DR
Implementar un programa que determine si un número de tarjeta de crédito proporcionado es válido según el algoritmo de Luhn.

Número: 378282246310005<br>
AMEX

## Antecedentes

Las probabilidades son usted o alguien que usted conozca tiene una tarjeta de crédito. Esa tarjeta tiene un número, impreso en su cara e incrustado (quizás con algunos otros datos) en la banda magnética en la parte posterior. Ese número también se almacena en una base de datos en algún lugar, por lo que cuando su tarjeta se utiliza para comprar algo, el acreedor sabe a quién facturar. Hay muchas personas con tarjetas de crédito en este mundo, por lo que esos números son bastante largos: American Express usa números de 15 dígitos, MasterCard usa números de 16 dígitos y Visa usa números de 13 y 16 dígitos. Y esos son números decimales (0 a 9), no binarios, lo que significa, por ejemplo, que American Express podría imprimir hasta 10 ^ (15) = 1,000,000,000,000,000 de tarjetas únicas! <br>

Ahora que es un poco de una exageración, porque los números de tarjetas de crédito realmente tienen algo de estructura para ellos. Todos los números de American Express empiezan con 34 o 37; Los números de MasterCard comienzan con 51, 52, 53, 54 o 55; y los números de Visa comienzan con 4. Pero los números de tarjetas de crédito también tienen una "suma de comprobación" incorporada en ellos, una relación matemática entre al menos un número y otros. Esa suma de comprobación permite a los ordenadores (o seres humanos que gustan de las matemáticas) detectar errores tipográficos, si no números fraudulentos, sin tener que consultar una base de datos, que puede ser lenta. (Considere el silencio incómodo que puede haber experimentado en algún momento, mientras que el pago con tarjeta de crédito en una tienda cuyo equipo utiliza un módem de acceso telefónico para verificar su tarjeta). Por supuesto. <br>

¿Cuál es la fórmula secreta? Bueno, la mayoría de las tarjetas utilizan un algoritmo inventado por Hans Peter Luhn, un buen tipo de IBM. Según el algoritmo de Luhn, puede determinar si un número de tarjeta de crédito es (sintácticamente) válido de la siguiente manera:<br>

Multiplique cada dígito por 2, comenzando con el segundo dígito del último dígito, y luego agregue los dígitos de los productos juntos.<br>

Agregue la suma a la suma de los dígitos que no fueron multiplicados por 2.<br>

Si el último dígito del total es 0 (o, ponga más formalmente, si el módulo 10 total es congruente a 0), ¡el número es válido!<br>

Eso es un poco confuso, así que vamos a probar un ejemplo con mi AmEx: 378282246310005.<br>

Para el bien de la discusión, vamos a subrayar primero cada otro dígito, comenzando con el número de segundo a último dígito:<br>

3 7 8 2 8 2 2 4 6 3 1 0 0 0 5<br>

Bueno, vamos a multiplicar cada uno de los dígitos subrayados por 2:<br>

7 • 2 + 2 • 2 + 2 • 2 + 4 • 2 + 3 • 2 + 0 • 2 + 0 • 2<br>

Eso nos da:<br>

14 + 4 + 4 + 8 + 6 + 0 + 0<br>

Ahora vamos a añadir los dígitos de los productos (es decir, no los productos en sí) juntos:<br>

1 + 4 + 4 + 4 + 8 + 6 + 0 + 0 = 27<br>

Ahora vamos a agregar esa suma (27) a la suma de los dígitos que no fueron multiplicados por 2:<br>

27 + 3 + 8 + 8 + 2 + 6 + 1 + 0 + 5 = 60<br>

Sí, el último dígito en esa suma (60) es un 0, por lo que mi tarjeta es legítima!<br>

Por lo tanto, la validación de números de tarjetas de crédito no es difícil, pero se pone un poco tediosa a mano.

## Especificación
*  Escriba un programa que solicite al usuario un número de tarjeta de crédito y luego informe si se trata de un número de tarjeta American Express, MasterCard o Visa válido, según las definiciones de cada formato en este documento.

* La última línea de salida de su programa sea AMEX o MASTERCARD o VISA o INVALIDA, nada más, nada menos.

* Para simplificar, puede suponer que la entrada del usuario será enteramente numérica (es decir, desprovista de guiones, como se podría imprimir en una tarjeta real)