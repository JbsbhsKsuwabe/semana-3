using cadastro.Models;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:8000");

var app = builder.Build();

app.MapGet("/", () => "API funcionando com ASP.NET!");

app.MapGet("/for", () => {
    for(int i = 0; i < 5; i++) {
        Console.WriteLine(i);
    }

}
);

app.MapGet("/while", () => {
    int i = 0;
    while(i < 5) {
        Console.WriteLine(i++);
    }
}
);

app.MapGet("/objeto/{nome}", (string nome) => {
    Funcionario funcionario = new Funcionario();
        funcionario.Nome = nome;
        Console.WriteLine("Nome: " + funcionario.Nome);
        return Results.Ok(new
            {
                nome = nome
            });
}
);

app.Run();