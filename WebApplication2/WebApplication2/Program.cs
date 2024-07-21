using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using Task = System.Threading.Tasks.Task;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<JobTitleService>();  // Register your JobTitleService
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<TaskService>();

builder.Services.AddDbContext<MANAGEMENTContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ManagementDatabase")));

builder.Services.AddDbContext<MANAGEMENT_BPMContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ManagementBPMDatabase")));

// Configure Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Adding CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseAuthentication();
app.UseHttpsRedirection();
app.UseStaticFiles(); // Enables serving static files from wwwroot

app.UseRouting();
app.UseCors("AllowAll");

app.UseAuthorization();
app.MapControllers();

app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", context =>
    {
        context.Response.Redirect("/index.html");
        return Task.CompletedTask;
    });
    endpoints.MapControllers();
});
app.UseExceptionHandler("/error");  // Add this to handle exceptions globally

app.MapGet("/error", (HttpContext http) =>
{
    var exception = http.Features.Get<IExceptionHandlerFeature>()?.Error;
    return Results.Problem(title: "An error occurred", detail: exception?.Message);
});


app.Run();
