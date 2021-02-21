using AboutMe.Domain.Entities;
using AboutMe.Infrastructure.Repositories;

namespace AboutMe.Domain.Abstract
{
    class AboutMe : IAboutMeRepository
    {
        MyInfo IAboutMeRepository.showAboutMe()
        {
            MyInfo info = new MyInfo();

            info.Name = "Rishabah Jain";
            info.Age = 24;
            info.Description = "Test Text";

            return info;
        }
    }
}
