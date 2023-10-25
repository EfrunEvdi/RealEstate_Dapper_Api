using RealEstate_Dapper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        //void CreateTestimonial(CreateTestimonialDto serviceDto);
        //void DeleteTestimonial(int id);
        //void UpdateTestimonial(UpdateTestimonialDto serviceDto);
        //Task<GetByIDTestimonialDto> GetTestimonial(int id);
    }
}
