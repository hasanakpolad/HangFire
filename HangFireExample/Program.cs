using Hangfire;
using Hangfire.MySql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddHangfire(conf =>
{
    conf.UseStorage(new MySqlStorage("server=localhost;uid=root;pwd=root;database=root;Allow User Variables=True", new MySqlStorageOptions()
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
