using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new MernisServiceAdapter());
            Gamer user1 = new Gamer { UserId = 1, FirstName = "ELÇİN", LastName = "SEVİM", BirthYear = 1996, IdentityId = "1234" };
           

            GameManager gameManager = new GameManager();
           

            CampaignManager campaignManager = new CampaignManager();
           
          
           
            

                    userManager.Add(user1);
               
                    userManager.Update(user1);
                  
                    userManager.Delete(user1);
                 
            }

        }
    }

    
