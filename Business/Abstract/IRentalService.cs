using Core.Entities.DTOs;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IDataResult<List<Rental>> GetAll();
        IResult Rent(Rental rental);
        IResult Deliver(int rentId, DateTime dateTime);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
