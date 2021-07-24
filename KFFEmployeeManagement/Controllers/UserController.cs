using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using KFFEmployeeManagement.Data.Models;
using KFFEmployeeManagement.Domain.DTO;
using KFFEmployeeManagement.Domain.Entities;
using KFFEmployeeManagement.Domain.Interfaces;
using KFFEmployeeManagement.Domain.Models;
using KFFEmployeeManagement.Service.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KFFEmployeeManagement.Controllers
{
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        public IUserService _IUserService;
        //private readonly IUnitOfWork _unitOfWork;
        //private readonly IMapper _mapper;

        public UserController(IUserService IUserService)
        {
            this._IUserService = IUserService;
            //this._unitOfWork = unitOfWork;
            //this._mapper = mapper;
        }

        [Authorize]
        [HttpPost("api/User/RegisterUser")]
        public async Task<ActionResult> RegisterAsync([FromBody]UserRegisterModel model)
        {
            var result = await _IUserService.UserRegisterAsync(model);
            return Ok(result);
        }

        [HttpPost("api/User/GetToken")]
        public async Task<IActionResult> GetTokenAsync([FromBody]TokenRequestModel model)
        {
            var result = await _IUserService.GetTokenAsync(model);
            return Ok(result);
        }

        [Authorize]
        [HttpPost("api/User/AddRoleToUser")]
        public async Task<IActionResult> AddRoleToUserAsync([FromBody]AddRoleModel model)
        {
            var result = await _IUserService.AddRoleAsync(model);
            return Ok(result);
        }

        /// <summary>
        /// Create user
        /// </summary>       
        /// <returns></returns>
        //[HttpPost]
        //[Route("api/User/CreateUser")]
        //public IActionResult CreateUser([FromBody]UserDTO request)
        //{
        //    var userMapped = _mapper.Map<User>(request);
        //    if (userMapped != null)
        //    {
        //        _IUserService.AddUser(userMapped);
        //    }
        //    return Ok();
        //}

        //// GET: api/User/5
        //[HttpGet]
        //[Route("api/User/GetUsers")]
        //public List<UserDTO> GetUsers(int id)
        //{
        //    return _IUserService.GetAllUsers();
        //}

        // POST: api/User
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/User/5
        [HttpPut("api/User/UpdateUser/{id}")]
        public void Put(int id, [FromBody] string value)
        {
            throw new CustomException("An error occurred...");
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
