using Dapper;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            string query = "Select Count(*) From Categories Where Status=1";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ActiveEmployeeCount()
        {
            string query = "Select Count(*) From Employees Where Status=1";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ApartmentCount()
        {
            string query = "Select Count(*) From Products Where Title Like '%Daire%'";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public decimal AverageProductPriceByRent()
        {
            string query = "Select Avg(Price) From Products Where Type='Kiralık'";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public decimal AverageProductPriceBySale()
        {
            string query = "Select Avg(Price) From Products Where Type='Satılık'";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public int AvereageRoomCount()
        {
            string query = "Select Avg(RoomCount) From ProductDetails";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int CategoryCount()
        {
            string query = "Select Count(*) From Categories";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string CategoryNameByMaxProductCount()
        {
            string query = "Select Top(1) Name,Count(*) From Products Inner Join Categories On Products.ProductCategory=Categories.CategoryID Group By Name Order By Count(*) Desc";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string CityNameByMaxProductCount()
        {
            string query = "Select Top(1) City,Count(*) As 'product_count' From Products Group By City Order By product_count Desc";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }
        public int DifferentCityCount()
        {
            string query = "Select Count(Distinct(City)) From Products";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public string EmployeeNameByMaxProductCount()
        {
            string query = "Select Name,Count(*) 'product_count' From Products Inner Join Employees On Products.EmployeeID=Employees.EmployeeID Group By Name Order By product_count Desc";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public decimal LastProductPrice()
        {
            string query = "Select Top(1) Price From Products Order By ProductId Desc";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<decimal>(query);
                return values;
            }
        }

        public string NewestBuildingYear()
        {
            string query = "Select Top(1) BuildYear From ProductDetails Order By BuildYear Desc";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public string OldestBuildingYear()
        {
            string query = "Select Top(1) BuildYear From ProductDetails Order By BuildYear Asc";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<string>(query);
                return values;
            }
        }

        public int PassiveCategoryCount()
        {
            string query = "Select Count(*) From Categories Where Status=0";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCount()
        {
            string query = "Select Count(*) From Products";

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }
    }
}
