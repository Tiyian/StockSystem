using StockModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataAccess
{
    #region 数据库上下文组件
    

    public class StockContext : DbContext

    {

        public StockContext() : base("name=StockContext")

        { }

        public DbSet<UserInfo> UserInfos { get; set; }

        public DbSet<PostInventoryModel> PostInventories { get; set; }

        public DbSet<PostOutStockModel> PostOutStocks { get; set; }

        public DbSet<PostIncomingModel> PostIncomings { get; set; }

        public DbSet<PostOutcomingModel> PostOutcomings { get; set; }

        public DbSet<PostWarehouseInfoModel> PostWarehouseInfos { get; set; }

        public DbSet<PostPartInfoModel> PostPartInfos { get; set; }
    }
    
    #endregion
}
