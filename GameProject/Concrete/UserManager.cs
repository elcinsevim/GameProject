using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class UserManager : IUserService
    {
        IUserValidationService _userValidationService; 

        public UserManager(IUserValidationService userValidationService)  
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer user)
        {
            if (_userValidationService.Validate(user) == true)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " user was authenticated in the system.");
            }
            else
            {
                Console.WriteLine("verification failed");
            }

        }
        public void Delete(Gamer user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " user registration deleted");
        }

        public void Update(Gamer user)
        {
            Console.WriteLine(user.FirstName + " " + user.LastName + " user registration updated");
        }
    }
}
