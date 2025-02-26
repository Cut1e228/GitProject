using GitProject.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ������������ ���������� �� �� �� ��������� ����� � appsettings.json
builder.Services.AddDbContext<AppDbConext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ������ ������ ��� ���������� �� �'����
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ������������ ������� HTTP-������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // �������� HSTS �� ������������� - 30 ���. �� ������ ������ �� ��� ���������� �������
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ������������� ��� ����������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
