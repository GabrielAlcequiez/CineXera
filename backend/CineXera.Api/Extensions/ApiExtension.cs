namespace CineXera.Api.Extensions
{
    public static class ApiExtension
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app, IEndpointRouteBuilder routeBuilder)
        {
            app.UseSwagger();
            app.UseSwaggerUI(opt =>
            {
                var versionDescriptons = routeBuilder.DescribeApiVersions();

                if(versionDescriptons != null && versionDescriptons.Any())
                {
                    foreach(var apiVersion in versionDescriptons)
                    {
                        var url = $"/swagger/{apiVersion.GroupName}/swagger.json";
                        var name = $"ArtemisBankingPro API - {apiVersion.GroupName.ToUpperInvariant()}";
                        opt.SwaggerEndpoint(url, name);
                    }
                }
            });
        }
    }
}