namespace Sistema_Hotel_Penedo.Models
{
    public class CadastrarQuartoModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeHospedes { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public string Servicos { get; set; }
        public string Status { get; set; }
        public int Dimensao { get; set; }
        public int Camas { get; set; }
        public string Comidades { get; set; }

    }
}
