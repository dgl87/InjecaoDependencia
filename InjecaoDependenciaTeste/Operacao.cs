namespace InjecaoDependenciaTeste
{
    public class Operacao : IOperacaoTransient, IOperacaoScoped, IOperacaoSingleton
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
    public interface IOperacaoTransient : IOperacao
    {

    }
    public interface IOperacaoScoped : IOperacao
    {

    }
    public interface IOperacaoSingleton : IOperacao
    {

    }
}