using Business.Concrete;
using Entities.Concrete;

Person person = new Person();
person.NationalIdentity = 1234;
person.FirstName= "MURAT";
person.LastName = "DERELİ";
person.DateOfBirthYear = 2024;
PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);
