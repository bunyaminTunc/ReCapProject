using Core.DataAccess.EntityFramework;
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
    }
}
