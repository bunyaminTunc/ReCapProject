using Core.DataAccess.EntityFramework;
using Core.Entities.DTOs;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapDataContext>, IRentalDal
    {
        public bool deleteRentalIfReturnDateNull(Rental rental)
        {
            using (ReCapDataContext contex = new ReCapDataContext())
            {
                var find = contex.Rentals.Any(i => i.Id == rental.Id && i.ReturnDate == null);
                if (!find)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapDataContext context =new ReCapDataContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.Id
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new RentalDetailDto
                             {
                                 Id=r.Id,
                                 CarId=c.Id,
                                 CompanyName=cu.CompanyName,
                                 BrandName=b.Name,
                                 ColorName=co.Name,
                                 DailyPrice=c.DailyPrice,
                                 RentDate=r.RentDate,
                                 ReturnDate=r.ReturnDate
                                 

                             };
                return result.ToList();
                          



            }
            
        }
    }
}
