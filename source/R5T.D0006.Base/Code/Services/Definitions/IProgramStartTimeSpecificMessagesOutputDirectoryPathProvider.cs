using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0006
{
    [ServiceDefinitionMarker]
    public interface IProgramStartTimeSpecificMessagesOutputDirectoryPathProvider : IServiceDefinition
    {
        Task<string> GetProgramStartTimeSpecificMessagesOutputDirectoryPathAsync();
    }
}
