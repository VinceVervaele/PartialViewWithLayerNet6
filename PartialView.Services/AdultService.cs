using PartialView.Models;
using PartialView.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialView.Services
{
    public class AdultService
    {
        private AdultDAO adultDAO;
        public AdultService()
        {
            adultDAO = new AdultDAO();
        }

        public IEnumerable<Adult> GetAll(JobType type)
        {
            return adultDAO.GetAll(type);
        }

    }
}
