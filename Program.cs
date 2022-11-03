//  Algoritmo donde se simula la presentacion de cada familia con las otras sin presentarse ellos mismos utilizando arrays

using System.Runtime.CompilerServices;

String[][] amigos_familia = new string[][]
{
    new string[] { "Miguel", "Sandra" },                //  Familia 1
    new string[] { "Maite", "Alex", "Juan", "Pedro" },  //  Familia 2
    new string[] { "Andres", "Olivia", "Azuka" },       //  Familia 3
};

for (var linea = 0; linea < amigos_familia.Length; linea ++)
{
    for (var columna = 0; columna < amigos_familia[linea].Length; columna ++)
    {
        var soy = amigos_familia[linea][columna];
        for (var familia = 0; familia < amigos_familia.Length; familia ++)
        {
            if (linea != familia)
                for (var otracol = 0; otracol < amigos_familia[familia].Length; otracol++)
                {
                    Console.WriteLine($"Hola, soy {soy}, gusto en concerle {amigos_familia[familia][otracol]}");
                }
        }
    }
}



































