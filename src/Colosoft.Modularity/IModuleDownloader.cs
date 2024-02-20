using System.Collections.Generic;

namespace Colosoft.Modularity
{
    public interface IModuleDownloader : Net.IDownloader
    {
        IEnumerable<IModuleInfo> Modules { get; }

        void Add(IModuleInfo module);

        void AddRange(IEnumerable<IModuleInfo> modules);

        void Clear();
    }
}
