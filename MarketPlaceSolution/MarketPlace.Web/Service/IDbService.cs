using ApiHub.Service.DTO.Common;

namespace MarketPlace.Web.Service
{
    public interface IDbService
    {
        Task<DtoPagedResponse<TOutput>> GetPaginatedResultset<TOutput>(DtoPageRequest input, string procedureName);
    }
}
