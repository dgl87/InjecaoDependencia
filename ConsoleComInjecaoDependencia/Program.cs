// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.DependencyInjection;
using System.Security.Authentication.ExtendedProtection;

Console.WriteLine("Hello, World!");

// Criando uma coleção de serviços
var serviceCollection = new ServiceCollection();

// Configurando nossas classes na coleção de serviços
serviceCollection.AddScoped<IOperacao, Operacao>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var operacao = serviceProvider.GetRequiredService<IOperacao>();

Console.WriteLine(operacao.Id);
Console.ReadKey();

interface IOperacao
{
    Guid Id { get; set; }
}

class Operacao : IOperacao
{
    public Operacao()
    {
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
}