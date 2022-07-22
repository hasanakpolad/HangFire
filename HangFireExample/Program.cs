using Hangfire;
using Hangfire.MySql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddHangfire(conf =>
{
    conf.UseStorage(new MySqlStorage(Environment.GetEnvironmentVariable("MYSQL_URI"), new MySqlStorageOptions()
    {
        TablesPrefix = "Hangfire"
    }));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
app.UseSwagger();
app.UseSwaggerUI();

app.UseHangfireDashboard();

app.UseAuthorization();

app.MapControllers();

app.Run();
