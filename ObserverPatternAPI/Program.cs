using ObserverPatternAPI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<OrderSubject>();

var orderSubject = new OrderSubject();
var emailNotifier = new EmailNotification();
var stockUpdater = new StockUpdate();


orderSubject.Attach(emailNotifier);
orderSubject.Attach(stockUpdater);

builder.Services.AddSingleton(orderSubject);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
