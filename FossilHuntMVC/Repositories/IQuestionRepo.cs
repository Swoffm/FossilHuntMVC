using FossilHuntMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FossilHuntMVC.Repositories
{
   public interface IQuestionRepo
    {
        public List<Question> GetAll();

    }   
}
