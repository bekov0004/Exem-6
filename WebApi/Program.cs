using Infrastructure.Data;
using Infrastructure.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(conf => conf.UseNpgsql(connection));
builder.Services.AddControllers();
builder.Services.AddScoped<StudentAttendanceServices>();
builder.Services.AddScoped<ClassroomServices>();
builder.Services.AddScoped<ClassroomStudentServices>();
builder.Services.AddScoped<ExamServices>();
builder.Services.AddScoped<IssuesServices>();
builder.Services.AddScoped<ResultServices>();
builder.Services.AddScoped<StudentServices>();
builder.Services.AddScoped<SubjectServices>();
builder.Services.AddScoped<TeacherServices>();
builder.Services.AddScoped<TeacherAttendanceServices>();
builder.Services.AddScoped<TimeTableServices>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
