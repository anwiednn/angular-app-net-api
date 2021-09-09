using AngularAppNetApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngularAppNetApi.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(
            ILogger<UserController> logger,
            IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        [HttpGet("api/users/check-email-available"))]
        public Task<bool> CheckEmaiAvailableAsync(int? id, string email)
        {
            return _userService.CheckEmaiAvailableAsync(id, email);
        }

        [HttpPost("api/users/create"))]
        public Task<int> CreateUserAsync([FromBody] UserCreateModel createModel)
        {
            // Verify user email available

            return _userService.CreateUserAsync(createModel);
        }

        [HttpGet("api/users/{id:int}/detail"))]
        public Task<UserDetailViewModel> GetUserDetailViewAsync(int id)
        {
            // Verify user exists

            return _userService.GetUserDetailViewAsync(id);
        }

        [HttpGet("api/users/index"))]
        public Task<UserIndexViewModel> GetUserIndexViewAsync()
        {
            return _userService.GetUserIndexViewAsync();
        }

        [HttpPost("api/users/index/page"))]
        public Task<UserIndexViewModel.PageModel> GetUserIndexViewPageAsync([FromBody] UserIndexViewModel.PredicateModel predicateModel)
        {
            return _userService.GetUserIndexViewPageAsync(predicateModel);
        }

        [HttpDelete("api/users/{id:int}"))]
        public Task DeleteUserAsync(int id)
        {
            // Verify user exists

            return _userService.GetUserIndexViewPageAsync(predicateModel);
        }

        [HttpPut("api/users/{id:int}"))]
        public Task UpdateUserAsync(int id, [FromBody] UserUpdateModel updateModel)
        {
            // Verify user exists
            // Verify user email available

            return _userService.UpdateUserAsync(updateModel);
        }
    }
}
