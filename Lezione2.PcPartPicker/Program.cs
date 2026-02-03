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

#region Pc Builds API
app.MapGet("/Builds", () => Database.Builds);
app.MapGet("/Builds/{id}", (Guid id) => Database.Builds.SingleOrDefault(b => b.Id == id));
app.MapPost("/Builds", () =>
{
    PCBuild build = new PCBuild(){ Id = Guid.NewGuid() };
    Database.Builds.Add(build);
    return build;
});
app.MapPost("/Builds/{idBuild}/AddMB/{mbCode}", (Guid idBuild, string mbCode) =>
{
    PCBuild? build = Database.Builds.SingleOrDefault(b => b.Id == idBuild);
    if (build == null)
        return Results.BadRequest($"Build ID {idBuild} not found");
    build?.Motherboard = Database.Motherboards.SingleOrDefault(m => m.Code == mbCode);
    if (build.Motherboard == null)
        return Results.BadRequest($"Motherboard code {mbCode} not compatible");
    return Results.Ok();

    //return build.Motherboard == null 
    //? Results.BadRequest($"Motherboard code {mbCode} not compatible")
    //: Results.Ok();
});
#endregion

#region RAM API
app.MapGet("/RAM", () => Database.RAMs);
app.MapGet("/RAM/FilterByBuild/{idBuild}", (Guid idBuild) =>
{

});
#endregion

app.Run();

bool CheckBuildId(PCBuild build)
{
    Guid idBuild = Guid.NewGuid();
    return build.Id == idBuild;
}