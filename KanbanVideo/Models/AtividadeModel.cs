namespace KanbanVideo.Models
{
    public class AtividadeModel
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public int StatusId { get; set; }
        public StatusModel Status { get; set; }

    }
}
