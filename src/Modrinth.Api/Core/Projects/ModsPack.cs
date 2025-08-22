using System.Net.Http;
using Modrinth.Api.Core.Repository;

namespace Modrinth.Api.Core.Projects;

public class ModsPack : Projects, IProjectRepository
{
    public ModsPack(ModrinthApi api, HttpClient httpClient) : base(api, httpClient)
    {
    }
}
