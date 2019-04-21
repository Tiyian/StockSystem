using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockModel
{
    //现有库存表单
    public class PostInventoryModel
    {
        [Key]
        public int PostInventoryID { get; set; }
        public int PartType { get; set; }
        public int Total { get; set; }
        public short Wno { get; set; }
        public DateTime InDate { get; set; }
        public int Operator { get; set; }
    }
    //已出库表单
    public class PostOutStockModel
    {
        public string PartName { get; set; }
        public int PartType { get; set; }
        public int OutTotal { get; set; }
        public DateTime OutDate { get; set; }
    }
    //入库清单表单
    public class PostIncomingModel
    {
        public int CodeId { get; set; }
        public string PartName { get; set; }
        public int PartType { get; set; }
        public int Amount { get; set; }
    }
    //出库清单表单
    public class PostOutcomingModel
    {
        public int CodeId { get; set; }
        public string PartName { get; set; }
        public int PartType { get; set; }
        public int Amount { get; set; }
    }
    //仓库基本信息表
    public class PostWarehouseInfoModel
    {
        public short Wno { get; set; }
        public string Wvolume { get; set; }
    }
    //零件基本信息表
    public class PostPartInfoModel
    {
        public int PartType { get; set; }
        public string PartName { get; set; }
        public float PartPrice { get; set; }
    }

    public class PostListModel
    {
        public List<PostInventoryModel> Posts { get; set; }
        public int Count { get; set; }
        public int Pages { get; set; }
        public int PageCount { get; set; }
    }
}