using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DI
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString
    ("DevConnection")));

//syncfusion
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc0NTA4NEAzMjMxMmUzMTJlMzMzNWJKd3RjMHc" +
    "4OFZJejNFdHVMb1NmcjVNUUtVTjZMM2h0cm9qVUM3alI5OHM9; Mgo + DSMBaFt + QHFqVkNrWE5GckBAXWFKblB8QGRTfF5gBShNYlxTR3ZbQ1pjSntUdUVgUH9a; Mgo + DSMBMAY9C3t2VFhhQlJBfVtdX2dWfFN0RnNadVt3flZGcC0sT3RfQF5jTX9UdkZmXnxedHRRQg ==; Mgo + DSMBPh8sVXJ1S0d + X1RPckBAWXxLflF1VWBTell6d1VWESFaRnZdQV1nSHlTdUBkWn9acXNR; MTc0NTA4OEAzMjMxMmUzMTJlMzMzNWRWTnpJTGlicVhSUEEweER2eUMrRHlPZjR6SmRQQkJNNFVtYllKK1E1MVU9; NRAiBiAaIQQuGjN / V0d + XU9Hc1RGQmFNYVF2R2BJfFR1c19FYEwgOX1dQl9gSXpScUVgXHhdcHBTRmQ =; ORg4AjUWIQA / Gnt2VFhhQlJBfVtdX2dWfFN0RnNadVt3flZGcC0sT3RfQF5jTX9UdkZmXnxedHNSQg ==; MTc0NTA5MUAzMjMxMmUzMTJlMzMzNWR2U21Ybys4STRhVTduM0lUcTNhMkZ4Mk53ZHk2emE3WUJ3MEJ3NXZybFk9; MTc0NTA5MkAzMjMxMmUzMTJlMzMzNVAydTZib1cvT0F5WUppaHdsN1FRNlp1d21yZldaTU03TWU3SVd1QWpJS2c9; MTc0NTA5M0AzMjMxMmUzMTJlMzMzNVZMN0ZrOTdmdUxJN2JNakZMWldqRTdhRnp1T3hZTFF1Qlo0VHFnVTJ6dFk9; MTc0NTA5NEAzMjMxMmUzMTJlMzMzNUJISXlWclFTOHJyOW83Y2NzYzZaV1NVQlMrWWNDM3BhRFhxYlFaeG15L289; MTc0NTA5NUAzMjMxMmUzMTJlMzMzNWJKd3RjMHc4OFZJejNFdHVMb1NmcjVNUUtVTjZMM2h0cm9qVUM3alI5OHM9");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
