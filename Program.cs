using Microsoft.EntityFrameworkCore;
using StudentManagmentSystem.Data;
using StudentManagmentSystem.Service.Interface;
using StudentManagmentSystem.Service.Implementations;
using StudentManagmentSystem.Middlware;

var builder = WebApplication.CreateBuilder(args);

// ✅ Register DbContext with SQL Server
builder.Services.AddDbContext<MyAppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Register Services for Dependency Injection
builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<ICourseService, CourseService>();
builder.Services.AddScoped<IEnrollmentService, EnrollmentService>();

// ✅ Add Controllers and Configure Route Prefix
builder.Services.AddControllers(options =>
{
    options.Conventions.Insert(0, new RoutePrefixConvention("alexa-store"));
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Configure Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
