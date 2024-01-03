using API.Application.DataContract.Request.User;
using API.Application.Interfaces;
using API.Domain.Validations.Base;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;

        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            Response response = await _userApplication.GetAll();

            if (response.Report.Count > 0)
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            Response response = await _userApplication.GetById(id);

            if (response.Report.Count > 0)
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] CreateUserRequest request)
        {
            Response response = await _userApplication.Create(request);
            
            if(response.Report.Count > 0)
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] CreateUserRequest request)
        {
            Response response = await _userApplication.Update(request);

            if (response.Report.Count > 0)
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            Response response = await _userApplication.Delete(id);

            if (response.Report.Count > 0)
                return UnprocessableEntity(response.Report);

            return Ok(response);
        }
    }
}
