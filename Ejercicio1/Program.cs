using System;

/*Dada una oración con palabras separadas por espacios, se debe invertir el orden de las palabras para formar una nueva oración.

Ejemplo:
- "me gusta mucho programar"
Resultado:
- "programar mucho gusta me"
 
Para resolver el problema, utilizar solo arreglos y bucles.*/

// Oración inicial.
string[] grupoPalabras1 = { "ME", "GUSTA", "MUCHO", "PROGRAMAR" };
foreach (string palabra in grupoPalabras1)
{
    Console.Write(palabra + " ");
}
Console.Write("\n");

// Oración invertida.
string[] grupoPalabras2 = { "ME", "GUSTA", "MUCHO", "PROGRAMAR" };
Array.Reverse(grupoPalabras2);
foreach (string palabra in grupoPalabras2)
{
    Console.Write(palabra + " ");
}