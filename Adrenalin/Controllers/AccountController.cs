using Adrenalin.Data;
using Adrenalin.DTOs;
using Adrenalin.Entities;
using Adrenalin.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adrenalin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ITokenService _tokenService;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, ITokenService tokenService, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _tokenService = tokenService;
            _roleManager = roleManager;
        }

        public IActionResult GetAll()
        {

            var users = _context.Users.ToList();
            List<UserDto> listDto = new List<UserDto>();

            foreach (var user in users)
            {
                UserDto userDto = new UserDto();
                userDto.Token = _tokenService.CreateToken(user);
                userDto.Username = user.UserName;
                listDto.Add(userDto);
            }

            return Ok(listDto);
        }
    }
}
