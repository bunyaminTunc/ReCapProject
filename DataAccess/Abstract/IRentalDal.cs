using Core.DataAccess;
using Core.Entities.DTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IRentalDal:IEntityRepository<Rental>
    {
        bool deleteRentalIfReturnDateNull(Rental rental);
        List<RentalDetailDto> GetRentalDetails();
    }
}
