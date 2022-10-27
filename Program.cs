//Brandon Le
//10-25-22
//Mini Challenge 5 - Greater Than or Less Than
//Web API project that will take the users input in the URL and compare the two numbers.
//It will print out whether the 2 numbers are greater than, less than, or equal to one another.
//Peer Review: Andrew Nilsson - All inputs worked in postman. returns a string, great job at making that one string look like 2 different ones. All 3 >, <, and = comparisons work.


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
