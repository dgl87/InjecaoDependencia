namespace InjecaoDependenciaTeste
{
    public class Operacao : IOperacao
    {
        public Operacao()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }

    public interface IOperacao
    {
        Guid Id { get; set; }
    }
}