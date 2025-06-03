namespace ToDo
{
    

  public class Tarea
    {
       

        public int TareaID { get ; set ; }
        public string Descripcion { get ; set ; }
        public int Duracion { get ; set ; }

        public Tarea(int tareaID, string descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            if (duracion>=10 && duracion<=100)
            {
                this.Duracion = duracion;
            }else
            {
                this.Duracion= 10;
                Console.WriteLine("Como no puso una duracion valida y se establecio 10 por defecto");
            }
            
        }





    }
}