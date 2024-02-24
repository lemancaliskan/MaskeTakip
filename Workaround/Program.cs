using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
namespace Workaround
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Person person1 = new Person();
                person1.FirstName = "Leman";
                person1.LastName = "Çalışkan";
                person1.NationalIdentity = 01234567891;
                person1.DateOfBirthYear = 1994;
                PttManager pttManager = new PttManager(new PersonManager());
                pttManager.GiveMask(person1);
                Console.ReadLine();


            }
        }
    }

