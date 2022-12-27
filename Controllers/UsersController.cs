using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using API.Interfaces;
using API.DTOs;
using AutoMapper;

namespace API.Controllers;
        [Authorize]
    public class UsersController : BaseApiController
    {
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;

    public UsersController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _userRepository.GetMembersAsync();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MemberDto>> GetUser(int id)
        {
            var user = await _userRepository.GetUserByIdAsync(id);

            return _mapper.Map<MemberDto>(user);
        }

        [HttpGet("username/{username}")]
        public async Task<ActionResult<MemberDto>> GetUserByUsername(string username)
        {
            return await _userRepository.GetMemberAsync(username);
        }
    }
    
