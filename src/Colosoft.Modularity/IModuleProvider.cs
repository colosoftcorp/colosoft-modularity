using System;
using System.Security.Principal;

namespace Colosoft.Modularity
{
    public interface IModuleProvider : IDisposable
    {
#pragma warning disable SA1305 // Field names should not use Hungarian notation
        IModuleInfo[] GetModules(IIdentity identity, string uiContextFullName);
#pragma warning restore SA1305 // Field names should not use Hungarian notation

        IModuleDownloader CreateDownloader();
    }
}
