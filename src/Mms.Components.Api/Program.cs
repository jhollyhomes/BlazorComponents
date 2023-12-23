using Mms.Components.Api.FakeServices;
using Mms.Components.Shared;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IFakeCompanyService, FakeCompanyService>();

var app = builder.Build();



app.Run();
