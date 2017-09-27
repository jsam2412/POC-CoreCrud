using CoreCrud.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreCrud.Service
{
    public interface IUserProfileService
    {
        UserProfile GetUserProfile(long id);
    }
}
