using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICompaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "with the campaign" + campaign.CampaignContent + "added with content");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " delete campaign");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " update campaign");
        }
    }
}
