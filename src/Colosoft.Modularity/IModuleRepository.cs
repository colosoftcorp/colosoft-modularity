namespace Colosoft.Modularity
{
    public interface IModuleRepository
    {
        string GetModuleDirectory(IModuleInfo moduleInfo);

        bool ValidateVersion(IModuleInfo moduleInfo);
    }
}
