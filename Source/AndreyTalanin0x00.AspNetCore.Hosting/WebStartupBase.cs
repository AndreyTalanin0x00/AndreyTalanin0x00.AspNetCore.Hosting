using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

// Disable the IDE0001 (Simplify name) notification to preserve explicit service types.
#pragma warning disable IDE0001

// Disable the IDE0130 (Namespace does not match folder structure) notification to add types to a namespace from the base package.
#pragma warning disable IDE0130

namespace AndreyTalanin0x00.Extensions.Hosting;

/// <summary>
/// Represents an abstract implementation of the <see cref="IWebStartupEx" /> <see langword="interface" />.
/// <para>The <see cref="StartupBase.ConfigureServices(IServiceCollection)" /> and <see cref="WebStartupBase.Configure(IApplicationBuilder)" /> methods must implemented by the <c>WebStartup</c> <see langword="class" /> of the application.</para>
/// </summary>
public abstract class WebStartupBase : StartupBase, IWebStartupEx
{
    /// <inheritdoc />
    public IWebHostEnvironment WebHostEnvironment { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebStartupBase" /> type using the application configuration and web hosting environment information provider.
    /// </summary>
    /// <param name="configuration">The application configuration.</param>
    /// <param name="webHostEnvironment">The web hosting environment information provider.</param>
    protected WebStartupBase(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
        : base(configuration, webHostEnvironment)
    {
        WebHostEnvironment = webHostEnvironment;
    }

    /// <inheritdoc />
    public abstract void Configure(IApplicationBuilder applicationBuilder);
}
