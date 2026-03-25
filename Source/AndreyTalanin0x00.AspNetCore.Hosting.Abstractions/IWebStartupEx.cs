using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

// Disable the IDE0130 (Namespace does not match folder structure) notification to add types to a namespace from the base package.
#pragma warning disable IDE0130

namespace AndreyTalanin0x00.Extensions.Hosting;

/// <summary>
/// Defines a <c>WebStartup</c> <see langword="class" /> for an application using the ASP.NET Core web host.
/// </summary>
public interface IWebStartupEx : IStartupEx
{
    /// <summary>
    /// Gets the application's web hosting environment information.
    /// </summary>
    public IWebHostEnvironment WebHostEnvironment { get; }

    /// <summary>
    /// Configures the application's HTTP request pipeline.
    /// </summary>
    /// <param name="applicationBuilder">The request pipeline builder.</param>
    /// <remarks>This method gets called by the runtime. Use this method to configure the application's HTTP request pipeline.</remarks>
    public void Configure(IApplicationBuilder applicationBuilder);
}
