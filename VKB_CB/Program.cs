using Services;
using VK;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(opt =>
{
    opt.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Http clients and services
builder.Services.AddHttpClient();
builder.Services.AddSingleton<VkApiManager>();
builder.Services.AddSingleton<KeyboardProvider>();
builder.Services.AddSingleton<ConversationStateService>();
builder.Services.AddSingleton<FileLogger>();
builder.Services.AddScoped<IMessageService, MessageService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();
