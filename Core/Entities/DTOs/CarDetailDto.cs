using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.DTOs
{
   public class CarDetailDto:IDto
    {
        //CarName, BrandName, ColorName, DailyPrice
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal DailyPrice { get; set; }
        public string Decription { get; set; }
        public int ModelYear { get; set; }

    }

    
}
