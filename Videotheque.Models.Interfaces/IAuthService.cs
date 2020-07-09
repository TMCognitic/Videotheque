using System;

namespace Videotheque.Models.Interfaces
{
    public interface IAuthService<TUser>
    {
        void Register(TUser user);
    }
}
