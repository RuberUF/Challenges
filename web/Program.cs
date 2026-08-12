using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapPost("/validar",([FromForm] string flag)=>{
    if (flag == "CSU{x0r_15_345y???}"){
      return "Correct";
    }else{
      return "Incorrect";
    }
}).DisableAntiforgery();
app.Run();
