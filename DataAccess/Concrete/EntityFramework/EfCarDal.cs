using Core.DataAccess.EntityFramework;
using Core.Entities.DTOs;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapDataContext>, ICarDal
    {
        public List<CarDetailDto> GetDetailsCar()
        {
            using (ReCapDataContext context = new ReCapDataContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto
                             {
                                 Id = c.Id,
                                 BrandName = b.Name,
                                 ModelYear = c.ModelYear,
                                 ColorName = co.Name,
                                 DailyPrice = c.DailyPrice,
                                 Decription = c.Description

                             };
                return result.ToList();

            }
        }
    }
}
