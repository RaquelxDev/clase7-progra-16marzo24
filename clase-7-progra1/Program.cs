
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
    Console.WriteLine($"El promedio es: "{ promedio});

    Console.WriteLine("Original");
    foreach (int nota in notas)
    {
        Console.WriteLine(nota);
    }



}
//promedio();

/*
static void promedio_for()
{
    int[] calificaciones = {85, 92, 77 68, 94 };

    for (int i = 0; i < calificaciones.Length i++)

    {
        Console.WriteLine($"calificaciones{i + 1}: { calificaciones[i]}");
    }

}
*/
static void calificaciones()
{
    int[] calificaciones = { 85, 92, 77, 68, 94 };
    bool hayAprobados = Array.Exists(calificaciones, calif => calif >= 60);

}
//calificaciones();

static void ejercicio1()
{
    string[] num1 = {"juan", "ana", "pedro", "monica", "andrea" };
    for (int i = num1.Length - 1; i >= 0; i--)
        Console.WriteLine(num1[i]);
}
ejercicio1();

