﻿using Core.Entities.DTOs;
using Core.Utilities.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {

       IDataResult<List<Car>> GetAll();
       IDataResult<List<Car>> GetCarsByBrandId(int brandId);
       IDataResult<List<Car>>GetCarsByColorId(int colorId);
       IDataResult<List<CarDetailDto>> GetCarDetails();
        IDataResult<Car> GetById(int carId);

       IResult Add(Car car);
    }
}
