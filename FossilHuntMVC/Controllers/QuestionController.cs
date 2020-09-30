using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FossilHuntMVC.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FossilHuntMVC.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionRepo _questionRepo;

        public QuestionController (IQuestionRepo questionRepo)
        {
            _questionRepo = questionRepo;
        }



        public IActionResult Index()
        {
            var questionList = _questionRepo.GetAll();
            return View(questionList);
        }
    }
}
