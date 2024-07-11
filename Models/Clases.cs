namespace WebApplication1.Models;

public class Clases
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public Plan PlanActual { get; set; }
    }

    public class Plan
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Comida> Comidas { get; set; }
    }

    public class Comida
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ingredientes { get; set; }
        public string ValorNutricional { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
    }

    public class Pago
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaPago { get; set; }
    }

    public class Entrega
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime FechaEntrega { get; set; }
        public string EstadoEntrega { get; set; }
    }

    public class Feedback
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int ComidaId { get; set; }
        public Comida Comida { get; set; }
        public string Comentarios { get; set; }
        public int Calificacion { get; set; }
    }
}