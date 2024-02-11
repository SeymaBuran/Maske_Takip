using Entities.Concrete;

namespace Business.Concrete
{
	public interface IPersonManager
	{
		void ApplyForMask(Person person);
		bool CheckPerson(Person person);
		List<Person> GetList();
	}
}