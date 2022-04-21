using EncommerceMongoDB.core.Dtos;
using EncommerceMongoDB.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncommerceMongoDB.core
{
    public static class Extensions
    {
        public static TrademarkDto Trademark_Dto(this Trademark _tm)
        {
            return new TrademarkDto
            {
                Id = _tm.Id,
                trade_name = _tm.trade_name,
                create_date = _tm.create_date
            };
        }

        public static ProductDto Product_Dto(this Product _tm)
        {
            return new ProductDto
            {
                Id = _tm.Id,
                pro_name = _tm.pro_name,
                pro_price = _tm.pro_price,
                pro_quantity = _tm.pro_quantity,
                pro_description = _tm.pro_description,
                pro_sale = _tm.pro_sale,
                pro_active = _tm.pro_active, 
                pro_createDate = _tm.pro_createDate,
                pro_updateDate = _tm.pro_updateDate,
                pro_trademarkId = _tm.pro_trademarkId,
                pro_detailId = _tm.pro_detailId
            };
        }
    }
}
