using my_new_app.Models;
using my_new_app.Services;
using Microsoft.AspNetCore.Mvc;

namespace my_new_app.Controllers
{
    public class AboutController : Controller
    {
        private AboutRepository m_AboutRepository;

        public AboutController()
        {
            this.m_AboutRepository = new AboutRepository();
        }

        // GET
        public About[] Get()
        {
            return m_AboutRepository.GetAllAbouts();
        }
    }
}