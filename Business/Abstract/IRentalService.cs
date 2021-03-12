using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IRentalService
    {
        IResult Rent(Rental rental);
        IResult Deliver(int rentId, DateTime dateTime);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);
    }
}
