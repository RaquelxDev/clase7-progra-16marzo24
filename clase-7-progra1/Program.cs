
//Ejemplo 1
static void ejemplo1()
{
    //Declaración de un arreglo
    int[] calificaciones;

    //Creación de un arreglo con valores iniciales
    calificaciones = new int[] { 85, 77, 68, 94, 75};

    //Acceso a un elemento del arreglo
    Console.WriteLine(calificaciones[4]); //Esto imprime 77
}
//ejemplo1();

//Ejemplo 2
static void ejemplo2()
{
    string[] nombres = new string[3];
    nombres[0] = "Juan";
    nombres[1] = "Ana";
    nombres[2] = "Pedro";

    foreach (string nombre in nombres)//foreach declara una variable en singular 
                                      //y luego va a la variable nombre
    {
        Console.WriteLine(nombre);
    }
}
//ejemplo2();



//Ejemplo 3
static void promedio()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    int promedio = 0;
    //calcular promedio usando foreach


    foreach (int nota in notas)
    {
        promedio += nota;
        //Es lo mismo que usar suma = suma + nota;
        
    }
    promedio = promedio / 6;
    Console.WriteLine($"El promedio es: {promedio}");

    Console.WriteLine("Original");
    foreach (int nota in notas)
    {
        Console.WriteLine(nota);
    }
}

//promedio();


//Ejemplo 4

static void ejemplo4()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    double promedios = 0;

    for (int i = 0; i < notas.Length; i++)
    {
        promedios += notas[i];
    }
    double prom = promedios / notas.Length;
    Console.WriteLine(prom);

    Array.Sort(notas);
}
//ejemplo4();


//Ejemplo 5
static void calificaciones()
{
    int[] notas = { 80, 75, 90, 95, 73, 79 };
    bool aprobado = Array.Exists(notas, calif => calif >= 60);
    if (aprobado == true)
    {
        Console.WriteLine("aprobado");
    }
    else
    {
        Console.WriteLine("no aprobado");
    }
}
//calificaciones();


//Ejemplo 6

static void ejercicio6()
{
    string[] name = { "Juan", "Ana", "Pedro", "Maria", "Andrea" };
    string[] name2 = new string[name.Length];

    for (int i = 0; i < name.Length; i++)
    {
        name2[i] = name[name.Length - 1 - i];
    }

    for (int i = 0; i < name2.Length; i++)
    {
        Console.WriteLine(name2[i]);
    }
}
//ejercicio6();
