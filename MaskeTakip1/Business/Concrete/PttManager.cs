using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class PttManager : ISuupplierService
	{
		private IApplicantService _applicantService;
		

		public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır.
		{
			_applicantService = applicantService;
		}

		
		public void GiveMask(Person person)
		{
			if (_applicantService.CheckPerson(person))
			{
                Console.WriteLine(person.FirstName+" " + person.LastName + "İçin maske verildi");
            }
			else
			{
				Console.WriteLine(person.FirstName + " " + person.LastName + "İçin maske verilemedi");
			}
		}

		public void GiveMask(object person1)
		{
			throw new NotImplementedException();
		}
	}
}
