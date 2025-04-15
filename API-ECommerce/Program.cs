using API_ECommerce.Context;
using API_ECommerce.Interfaces;
using API_ECommerce.Models;
using API_ECommerce.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

//O .NET vai criar os objetos (Injecao de Dependencia)
//AddTransient - O C# CRIA UMA INSTANCIA NOVA TODA VEZ QUE UM METODO E CHAMADO. Por exemplo: O metodo cadastrar, se for fazer somente usar o ADDTransient.
//AddScoped - O C# cria uma instancia nova, toda vez que criar um controller.
//AddSingleton - So la mais pra frente, resumidamente ele cria para sua interface inteira. Ele sempre vai fazer em um objeto so, ele e mais arriscado.
//Esses tres sao usados somente no programam. Aqui voce ta configurando como que voce vai criar um new que seria um obejto ou uma classe.
builder.Services.AddScoped<EcommerceContext, EcommerceContext>(); //EcommerceContext e uma interface e ele nao tem O I por que ele nao tem uma interface

builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
builder.Services.AddTransient<IPagamentoRepository, PagamentoRepository>();
builder.Services.AddTransient<IItemPedidoRepository, ItemPedidoRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
//Aqui ele ta configurando a INTERFACE / REPOSITORY para que quando a criacao do obejto fosse feita forma correta e que o C# entendesse.


var app = builder.Build();

app.UseSwagger();

app.UseSwaggerUI();

app.MapControllers();

app.Run();