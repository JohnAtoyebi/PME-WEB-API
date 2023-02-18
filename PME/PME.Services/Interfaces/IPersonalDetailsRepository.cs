using PME.Core.DTOs;
using PME.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME.Services.Interfaces
{
    public interface IPersonalDetailsRepository
    {
        Task<PersonalDetails> GetMemberByIdAsync(string MemberId);
        Task<List<PersonalDetails>> GetAllMembersAsync();
        Task<PersonalDetailsDto> CreateMember(PersonalDetailsDto model);
        Task<string> UpdateMember(string memberId, PersonalDetailsDto model);
        Task<string> DeleteMemberById(string MemberId);
    }
}
