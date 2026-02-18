using ModelValidationExample.CustomModelBinders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers(options =>
{
    //options.ModelBinderProviders.Insert(0, new PersonBinderProvider ());
}).AddXmlDataContractSerializerFormatters();
var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
