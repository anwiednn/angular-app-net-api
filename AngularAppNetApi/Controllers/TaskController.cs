using AngularAppNetApi.Services;
using AngularAppNetApi.Models.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AngularAppNetApi.Controllers
{
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ILogger<TaskController> _logger;
        private readonly ITaskService _taskService;

        public TaskController(
            ILogger<TaskController> logger,
            ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService;
        }

        [HttpPost("api/tasks/create")]
        public Task<int> CreateTaskAsync([FromBody] TaskCreateModel createModel)
        {
            // Verify user exists (active?)

            return null;
            //return _taskService.CreateTaskAsync(createModel);
        }

        [HttpGet("api/tasks/create/view")]
        public Task<TaskCreateViewModel> GetTaskCreateViewAsync()
        {
            return null;
            //return _taskService.GetTaskCreateViewAsync();
        }

        [HttpGet("api/tasks/{id:int}/detail")]
        public Task<TaskDetailViewModel> GetTaskDetailViewAsync(int id)
        {
            // Verify task exists

            return null;
            //return _taskService.GetTaskDetailViewAsync(id);
        }

        [HttpGet("api/tasks/index")]
        public Task<TaskIndexViewModel> GetTaskIndexViewAsync()
        {
            return null;
            //return _taskService.GetTaskIndexViewAsync();
        }

        [HttpPost("api/tasks/index/page")]
        public Task<TaskIndexViewModel.PageModel> GetTaskIndexViewPageAsync([FromBody] TaskIndexViewModel.PredicateModel predicateModel)
        {
            return null;
            //return _taskService.GetTaskIndexViewPageAsync(predicateModel);
        }

        [HttpPut("api/tasks/{id:int}")]
        public Task UpdateTaskAsync(int id, [FromBody] TaskUpdateModel updateModel)
        {
            // Verify task exists
            // Verify user exists (and active?)

            return null;
            //return _taskService.UpdateTaskAsync(updateModel);
        }
    }
}
