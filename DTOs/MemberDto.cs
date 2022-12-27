using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PhotoUrl { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; } 
        public string Description { get; set; }
        public string FavoriteTeam { get; set; }
        public string Country { get; set; }
        public ICollection<PhotoDto> Photos { get; set; }

    }
}