using Lezione2.PcPartPicker.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/CreateBuild", (CPU cpu) =>
{
    PCBuild build = new PCBuild(){ Id = Guid.NewGuid() };
    build.CPU = cpu;
});

app.Run();