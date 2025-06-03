namespace ToDo
{
    

  public class Tarea
    {
        private int tareaID;
        private string? descripcion;
        private int duracion;

        public int TareaID { get => tareaID; set => tareaID = value; }
        public string? Descripcion { get => descripcion; set => descripcion = value; }
        public int Duracion { get => duracion; set => duracion = value; }

        public Tarea(int tareaID, string? descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            if (duracion>10 && duracion<100)
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