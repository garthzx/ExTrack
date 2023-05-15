using Expense_Tracker.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
// DI
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTgzNjY0MUAzMjMxMmUzMTJlMzMzNVl0UVNxMzNnSmI1d290SSsvZlBjYU5GdWVrTjFZSjBVNm1PUW5tVlZJZWs9;Mgo+DSMBaFt+QHFqVkNrWU5GaV1CX2BZd1lyQmldeU4BCV5EYF5SRHJdR11qTXlXcENkUXo=;Mgo+DSMBMAY9C3t2VFhhQlJBfVpdX3xLflF1VWpTe1l6cFNWESFaRnZdQV1nS3tTf0FkXXlYeXJQ;Mgo+DSMBPh8sVXJ1S0d+X1RPc0BAQmFJfFBmTGldeFR0ckU3HVdTRHRcQllhTH5ackJnX3hfc3E=;MTgzNjY0NUAzMjMxMmUzMTJlMzMzNW9nNWtQVXdtbHhBOCtLbFM5SlBGYnlGS0VNaUxtaWNzc1cycDlmU2RvajQ9;NRAiBiAaIQQuGjN/V0d+XU9Hc1RHQmFWfFN0RnNQdVp3flFAcC0sT3RfQF5jTXxWdkxnXntYd3FQQw==;ORg4AjUWIQA/Gnt2VFhhQlJBfVpdX3xLflF1VWpTe1l6cFNWESFaRnZdQV1nS3tTf0FkXXlZd3ZQ;MTgzNjY0OEAzMjMxMmUzMTJlMzMzNVpJMWc0T1hjdGdqb29QVHF6TnlIcGxVcmlCeC9EaEM5UGJjVGZHSk51a1U9;MTgzNjY0OUAzMjMxMmUzMTJlMzMzNVdydzEwb0xLcGFZUmhpYXFiN1RNSldIbXBLT3BlUzVIYWpWQlZueDNRcFE9;MTgzNjY1MEAzMjMxMmUzMTJlMzMzNUNoMUdkUnBrMXhoczMvazM0OUIxNkdPbmJ4STdhMDM2bEFqMGliN3Raems9;MTgzNjY1MUAzMjMxMmUzMTJlMzMzNUdYT2d2ZmE5OHNYTUk1SkZYRm0xZFRLTnlldENTQVhiV3NXcjNrVkVuM2s9;MTgzNjY1MkAzMjMxMmUzMTJlMzMzNVl0UVNxMzNnSmI1d290SSsvZlBjYU5GdWVrTjFZSjBVNm1PUW5tVlZJZWs9");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment()) {
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
app.Run();
