using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Inmemory;

public class InMemoryCarDal : ICarDal
{
    List<Car> _cars;

    public InMemoryCarDal(){
        _cars = new List<Car>{
            new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=1500, Description= "This is a Cadillac", ModelYear=1988},
            new Car{Id=2, BrandId=2, ColorId=2, DailyPrice=500, Description= "This is a Chevrolet", ModelYear=2008},
            new Car{Id=3, BrandId=3, ColorId=3, DailyPrice=3500, Description= "This is a Hammer", ModelYear=2012},
        };
    }
    public void Add(Car car)
    {
        _cars.Add(car);
    }

    public void Delete(Car car)
    {
        Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        _cars.Remove(car);
    }

    public List<Car> GetAll()
    {
        return _cars;
    }

    public Car GetById(int Id)
    {
        return _cars.Find(c => c.Id == Id);
    }

    public void Update(Car car)
    {
        Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.Description = car.Description;
    }
}
