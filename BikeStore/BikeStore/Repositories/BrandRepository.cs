using BikeStore.Models.Database;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeStore.Repositories
{
    public class BrandRepository : BaseRepository, IBaseRepository<Brand>
    {
        public int DeleteData(Brand dataItem)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAllData()
        {
            List<Brand> dataItemList = new List<Brand>();
            string Query = "SELECT * FROM [DapperDB].[production].[brands]";

            dataItemList = connection.Query<Brand>(Query).ToList();

            return dataItemList;
        }

        public Brand GetDataById(int dataItemId)
        {
            Brand dataItem = null;
            string Query = $"SELECT * FROM [DapperDB].[production].[brands] where brand_id = {dataItemId}";
            
            dataItem = connection.QueryFirstOrDefault<Brand>(Query);

            return dataItem;
        }

        public int InsertData(Brand dataItem)
        {
            throw new NotImplementedException();
        }

        public int UpdateData(Brand dataItem)
        {
            throw new NotImplementedException();
        }
    }
}
