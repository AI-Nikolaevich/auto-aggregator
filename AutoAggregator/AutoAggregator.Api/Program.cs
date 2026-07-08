var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.RoutePrefix = string.Empty;
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "AutoAggregator API v1");
    });
}

app.UseHttpsRedirection();
app.MapGet("/api", () => "hello world");
app.UseAuthorization();

app.MapControllers();
app.Run();