var builder = WebApplication.CreateBuilder(args);

// Add Controllers
builder.Services.AddControllers();


//Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();


// Enable Controllers
app.MapControllers();

app.Run();