using GitProject.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Налаштування підключення до БД за допомогою рядка з appsettings.json
builder.Services.AddDbContext<AppDbConext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Додаємо сервіси для контролерів та в'юшок
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Налаштування конвеєра HTTP-запитів
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // Значення HSTS за замовчуванням - 30 днів. Ви можете змінити це для виробничих сценаріїв
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Маршрутизація для контролерів
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
