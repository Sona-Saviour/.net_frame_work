using api_example2.context;
using api_example2.Models;

var builder = WebApplication.CreateBuilder(args);

//cors
//Add cors
builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader()
    .SetIsOriginAllowed((host) => true);
}

));






// Add services to the container.


builder.Services.AddControllers();


//builder.Services.AddTransient<Employeeservices>();
//builder.Services.AddTransient<Employeerepo>();
builder.Services.AddTransient<EmployeeModel>();
builder.Services.AddTransient<DataContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors("MyPolicy");

app.UseAuthorization();

app.MapControllers();

app.Run();
