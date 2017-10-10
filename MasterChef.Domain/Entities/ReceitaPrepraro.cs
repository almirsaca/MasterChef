namespace MasterChef.Domain.Entities
{
    public class ReceitaPrepraro : EntityBase
    {
        public int ReceitaPrepraroID { get; set; }
        public int ReceitaID { get; set; }
        public string ModoPreparo { get; set; }

        public Receita Receita { get; set; }

        protected ReceitaPrepraro() { }
    }
}
