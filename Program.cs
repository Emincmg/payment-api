using System.Reflection;
using FluentValidation;
using PaymentProcessorApi.Factory;
using PaymentProcessorApi.FluentValidations;
using PaymentProcessorApi.Interfaces.Payment;
using PaymentProcessorApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDataProtection();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddScoped<PaymentService>();
builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<PaymentValidator>();
builder.Services.AddScoped<IPaymentStrategy, PaymentFactory>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();

app.Run();
