using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto bottomGridDto);
        void DeletePopularLocation(int id);
        void UpdatePopularLocation(CreatePopularLocationDto bottomGridDto);
        Task<GetByIDPopularLocationDto> GetPopularLocation(int id);
    }
}
