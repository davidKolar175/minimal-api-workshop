- **[Not true anymore]** No support for filters. i.e. `IAsyncAuthorizationFilter`, `IAsyncActionFilter`,** **`IAsyncExceptionFilter`, `IAsyncResultFilter`, `IAsyncResourceFilter`
- **[Not true anymore]** No support for model binding. i.e. `IModelBinderProvider`, `IModelBinder`. Support can be added with a custom binding shim.
- **[Not true anymore]** No support for binding from forms. This includes binding `IFormFile` (this will be added in the future).

- No built-in support for validation. i.e. `IModelValidator`
- No support for application parts or the application model. There's no way to apply or build your own conventions.
- No built-in view rendering support. We recommend using Razor Pages for rendering views.
- No support for [OData](https://www.nuget.org/packages/Microsoft.AspNetCore.OData/), see [this issue](https://github.com/OData/AspNetCoreOData/issues/578) fro more details.
- No support for [ApiVersioning](https://www.nuget.org/packages/Microsoft.AspNetCore.Mvc.Versioning/), see [this issue](https://github.com/dotnet/aspnet-api-versioning/issues/751) for more details.