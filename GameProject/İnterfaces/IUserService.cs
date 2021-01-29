using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserService
    {
        void Add(Gamer user);
        void Update(Gamer user);
        void Delete(Gamer user);
    }
}
