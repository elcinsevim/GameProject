using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    class UserValidationManager : IUserValidationService

    {
        public bool Validate(Gamer user)
        {
            if (user.BirthYear == 1996 && user.FirstName == "ELÇİN" && user.LastName == "SEVİM" && user.IdentityId == "1234")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
