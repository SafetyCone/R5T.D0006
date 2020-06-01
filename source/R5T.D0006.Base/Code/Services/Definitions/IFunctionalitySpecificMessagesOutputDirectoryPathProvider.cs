using System;
using System.Threading.Tasks;


namespace R5T.D0006
{
    public interface IFunctionalitySpecificMessagesOutputDirectorypathProvider
    {
        Task<string> GetFunctionalitySpecificMessagesOutputDirectoryPath(string functionalityName);
    }
}
