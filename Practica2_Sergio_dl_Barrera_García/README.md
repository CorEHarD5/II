Cuestionario #04: Lenguajes regulares y autómatas finitos (Tema 2)# Práctica 2

## Introducción a los scripts en Unity

* Autor: Sergio de la Barrera García
* Asignatura: Interfaces Inteligentes
* Centro: Universidad de La Laguna

## 1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo

###  a) Ninguno de los objetos será físico

Añadimos los objetos y al no tener físicas se quedarán estáticos

![imagen](./img/Captura1.PNG)

### b) La esfera tiene físicas, el cubo no

![imagen](./img/Captura2.PNG)

Una vez añadidas las físicas, podemos ver en el panel derecho como nos ha  añadido el componente

![imagen](./img/Captura2.1.PNG)

Y una vez le damos a jugar, veremos como la esfera tiene movimiento y el cubo se queda estático

![imagen](./img/Captura2.2.gif)

### c) La esfera y el cubo tienen físicas

Hacemos lo mismo que anteriormente pero esta vez con el cubo y este es el resultado

![imagen](./img/Captura3.gif)

### d) La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo

Añadimos más masa a la esfera en el panel derecho del objeto en sus configuraciones en el apartado *Rigibody*. Allí veremos una casilla llamada *Mass* e introducimos el valor que queremos, en este caso 10

![imagen](./img/Captura3.1.PNG)

Una vez hecho esto, comprobamos si funciona y podemos ver como la esfera es capaz de desplazarlo

![imagen](./img/captura4.gif)

### e) La esfera tiene físicas y el cubo es de tipo IsTrigger

En este caso iremos al panel derecho del cubo, al componente *Box Collider* y activamos la opción *Is Trigger*

![imagen](./img/Captura5.PNG)

A continuación vemos como el cubo es capaz de ser atravesado por la esfera

![imagen](./img/captura5.2.gif)

### f) La esfera tiene físicas, el cubo es de tipo IsTrigger y tiene físicas

Ahora vemos como el cubo es capaz de atravesar el terreno y caerá al infinito

![imagen](./img/captura5.1.gif)

### g) La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ

Para hace esto vamos al apartado *Ridigbody* del cubo, en la pestaña *Constraints* veremos la opción *Freeze Rotation*, elegimos los ejes X y Z para impedir que roten

![imagen](./img/Captura6.PNG)

Además vemos que la esfera tiene 10 veces la masa del cubo

![imagen](./img/Captura3.1.PNG)

Vamos a ver la diferencia con dos gifs:

- Cuando no se impide la rotación

![imagen](./img/captura6.1.gif)
- Cuando se impide la rotación

![imagen](./img/captura6.2.gif)

## 2. Sobre la escena que has trabajado ubica un cubo que represente un personaje que vas a mover. Se debe implementar un script que haga de CharacterController

Cuando el jugador pulse las teclas de flecha (o aswd) el jugador se moverá en la dirección que estos ejes indican.

### a) Crear un script para el personaje que lo desplace por la pantalla, sin aplicar simulación física

Crearemos una carpeta en *Assets* que se llame *Scripts* y crearemos un fichero *Csharp*

Este script tendrá lo siguiente

![imagen](./img/Captura7.PNG)

### b) Agregar un campo público que permita graduar la velocidad del movimiento desde el inspector de objetos

Para acceder al atributo *speed* hay que añadirlo como un atributo público de esta forma

![imagen](./img/Captura8.PNG)

