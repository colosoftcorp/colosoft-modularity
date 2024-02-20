namespace Colosoft.Modularity
{
    public interface IModuleInfo
    {
        int Uid { get; }

        string FullName { get; }

        string ModuleType { get; }

        string Version { get; }

#pragma warning disable CA1819 // Properties should not return arrays
        string[] Dependencies { get; }
#pragma warning restore CA1819 // Properties should not return arrays

        InitializationMode InitializationMode { get; }
    }
}
