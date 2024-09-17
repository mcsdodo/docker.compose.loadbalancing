var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

var data = new[]
{
    0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20
};

app.MapGet("/api", () =>
{
    return data;
})
.WithName("Api");

app.Run();

