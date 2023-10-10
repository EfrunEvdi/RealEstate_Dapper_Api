using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDtos;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreDetailRepository
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto categoryDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto categoryDto);
        Task<GetByIDWhoWeAreDetailDto> GetWhoWeAreDetail(int id);
    }
}
