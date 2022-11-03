
String[][] amigos_familia = new string[][]
{
    new string[] { "Miguel", "Sandra" },
    new string[] { "Maite", "Alex", "Juan", "Pedro" },
    new string[] { "Andres", "Olivia", "Azuka" },
};

for (var i = 0; i < amigos_familia.Length; i++)
{
    for (var l = 0; l < amigos_familia[i].Length; l++)
    {
        var soy = amigos_familia[i][l];
        for (var x = 0; x < amigos_familia.Length; x++)
        {
            if (i != x)
                for (var e = 0; e < amigos_familia[x].Length; e++)
                    Console.WriteLine($"Hola soy {soy}, gusto en concerte {amigos_familia[x][e]}");
        }
    }
}


