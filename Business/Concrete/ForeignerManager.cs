using Business.Abstract;
using Entities.Concrete;
using MerninsServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            KpsController kpsController = new KpsController();
            if (kpsController.Kps_Controller(person))
                return true;
            else
                return false;
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
