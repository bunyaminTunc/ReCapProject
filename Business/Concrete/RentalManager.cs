using Business.Abstract;
using Business.Constans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
  public  class RentalManager:IRentalService
    {
        IRentalDal _rentalDal;
        

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
            
        }

       

        public IResult Delete(Rental rental)
        {
            var result =_rentalDal.deleteRentalIfReturnDateNull(rental);
            if (result)
            {
                _rentalDal.Delete(rental);
                return new SuccessResult(Messages.Delete);
            }
            return new ErrorResult(Messages.NotDelete);
        }



        public IResult Deliver(int rentId, DateTime dateTime)
        {
            var result = _rentalDal.Get(r => r.Id == rentId && r.ReturnDate == null);
            if (result != null)
            {
                result.ReturnDate = dateTime;
                _rentalDal.Update(result);
                return new SuccessResult(Messages.ArabaTeslimEdildi);
            }
            return new ErrorResult();
        }



        public IResult Rent(Rental rental)
        {
            var result = _rentalDal.Get(r => r.Id == rental.CarId && r.ReturnDate==null);
            if (result!=null)
            {
                return new ErrorResult(Messages.ReturnDateIsNull);
            }

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.Added);

        }



        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdate);
        }
    }
}
