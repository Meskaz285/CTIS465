var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CORE>("core");

builder.Build().Run();
