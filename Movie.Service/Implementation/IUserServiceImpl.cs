using Movie.Domain.Identity;
using Movie.Repository.Interface;
using Movie.Service.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.Service.Implementation
{
    public class IUserServiceImpl : IUserService
    {
        private readonly IUserRepository _userRepository;
        public IUserServiceImpl(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public MovieUsers Get(string id)
        {
            return _userRepository.Get(id);
        }
    }
}
