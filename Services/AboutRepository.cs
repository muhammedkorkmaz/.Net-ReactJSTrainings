using my_new_app.Models;

namespace my_new_app.Services
{
    public class AboutRepository
    {
        public About[] GetAllAbouts()
        {
            return new About[]
            {
                new About()
                {
                    FirstName = "Muhammed",
                    LastName = "Korkmaz"
                },

                new About()
                {
                    FirstName = "Larissa",
                    LastName = "Garcia"
                }
            };
        }
    }
}