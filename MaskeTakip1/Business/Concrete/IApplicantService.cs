using Entities.Concrete;

namespace Business.Concrete
{
	public interface IApplicantService
	{
		bool CheckPerson(Person person);
	}
}