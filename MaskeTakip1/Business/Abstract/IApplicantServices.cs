using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IApplicantServices
	{
		//interfaceler yazılımda bağımlılığı azaltır.
		void ApplyforMask(Person person);
		List<Person> GetList();
		bool CheckPerson(Person person);

	}
}
