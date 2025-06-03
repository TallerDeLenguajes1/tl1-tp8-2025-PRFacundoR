// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using ToDo;




void mostrarTareaPendiente(List<Tarea> tarea){

    Console.WriteLine("Ingrese la descripccion de la tarea que quieres ver");

    string descrip=Console.ReadLine();
        foreach (Tarea tareaP in tarea)
        {
            if(tareaP.Descripcion.IndexOf(descrip)!=-1){
                Console.WriteLine("la/s tarea/s que cumple con esa descripcion es/son");
                Console.WriteLine($"Id:{tareaP.TareaID}");
                Console.WriteLine($"Descripcion:{tareaP.Descripcion}");
                Console.WriteLine($"Duracion:{tareaP.Duracion}");
            }

        }

}

void MostrarTareas(List<Tarea> tarea){
foreach (Tarea tareaP in tarea)
        {
            
                Console.WriteLine("Las tareas son :");
                Console.WriteLine($"Id:{tareaP.TareaID}");
                Console.WriteLine($"Descripcion:{tareaP.Descripcion}");
                Console.WriteLine($"Duracion:{tareaP.Duracion}");
            

        }

}

void agregarTareas(List<Tarea> tarea){

    string salir;
do
{
    Console.WriteLine("Si quiere dejar de agregar tareas escriba  'salir', si no escriba 'si' ");
    salir=Console.ReadLine();

    if (salir!="salir")
    {
        Console.WriteLine("ingrese la descripcion de la tarea de la tarea");
        string descripcion=Console.ReadLine();

        Console.WriteLine("ingrese el id de la tarea");
        string Id=Console.ReadLine();

        Console.WriteLine("ingrese la duracion de la tarea");
        string tiempo=Console.ReadLine();

        if(int.TryParse(tiempo,out int duracion) && int.TryParse(Id,out int id) ){


            tarea.Add( new Tarea(id,descripcion,duracion));
        }else
        {
            Console.WriteLine("ingreso una duracion incorrecta o un id no valido");

        }

    }

} while (salir!="salir" && salir=="si");
    
}

void pasajeDeTPaTR(List<Tarea> tareaP,List<Tarea> tareaR){
string salir;
do
{

    Console.WriteLine("Si quiere pasar una tarea pendiente a realizada, escriba 'si', sino, escriba 'salir'");
    salir=Console.ReadLine();
    
        

    if (salir!="salir")
    {

        Console.WriteLine("Ingrese el id de la tarea que quieres pasar");
        string idTarea=Console.ReadLine();

        if (int.TryParse(idTarea,out int IdTarea) )
        {
            for(int i=tareaP.Count-1; i>=0; i--){//otra forma de eliminar, remove no dentro de un foreach

                if(tareaP[i].TareaID==IdTarea){

                tareaR.Add(tareaP[i]);
                tareaP.RemoveAt(i);      


                }

            }

        }

    }
    
} while (salir!="salir" && salir=="si");



}



List<Tarea> tareasPendientes=new List<Tarea>();
List<Tarea> tareasRealizadas=new List<Tarea>();


Console.WriteLine("oprima 1 si quiere agregar una tarea, 2 si quiere pasar una tarea pendiente a realizada, ");
Console.WriteLine("3 si busca una tarea pendiente por id, 4 si quiere ver tareas pendientes y 5 si quiere ver las realizadas");
Console.WriteLine("si desea salir oprima 9");

string menu=Console.ReadLine();
int menuT;
do
{
    if (int.TryParse(menu, out menuT))
    {
        
        switch (menuT)
        {
            case 1:
            agregarTareas(tareasPendientes);
                break;
            case 2:
            pasajeDeTPaTR(tareasPendientes,tareasRealizadas);
                break;
            case 3:
            mostrarTareaPendiente(tareasPendientes);
                break;
            case 4:
            MostrarTareas(tareasPendientes);
                break;
            case 5:
            MostrarTareas(tareasRealizadas);
                break;    
        }


    }else
    {
        Console.WriteLine("ingrse una letra, no un numero");
    }


    
} while (menuT!=9);










