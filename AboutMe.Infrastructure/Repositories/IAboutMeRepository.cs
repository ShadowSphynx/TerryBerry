using System;
using System.Collections.Generic;
using System.Text;
using AboutMe.Domain.Entities;

namespace AboutMe.Infrastructure.Repositories
{
    public interface IAboutMeRepository
    {
        MyInfo showAboutMe();
    }
}
