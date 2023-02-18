using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PME.Core.DTOs;
using PME.Core.Models;
using PME.Data;
using PME.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PME.Services.Implementations
{
    public class PersonalDetailsServices : IPersonalDetailsRepository
    {
        private readonly PMEDbContext _context;
        private readonly IMapper _mapper;
        public PersonalDetailsServices(PMEDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<PersonalDetailsDto> CreateMember(PersonalDetailsDto model)
        {
            var request = new PersonalDetails
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                DOB = model.DOB,
                ProgrammingLanguage = model.ProgrammingLanguage,
                PhoneNumber = model.PhoneNumber,
                Address = model.Address,
            };

            _context.PersonalDetails.Add(request);
            var result = _mapper.Map<PersonalDetailsDto>(request);
            await _context.SaveChangesAsync();

            return result;
        }

        public async Task<string> DeleteMemberById(string MemberId)
        {
            var check = await _context.PersonalDetails.FirstOrDefaultAsync(x => x.Id == MemberId);
            if (check == null)
            {
                return null;
            }
            _context.Remove(check);
            await _context.SaveChangesAsync();
            return "SUCCESSFULLY DELETED!";
        }

        public async Task<string> UpdateMember(string memberId, PersonalDetailsDto model)
        {
            var request = _context.PersonalDetails.FirstOrDefault(x => x.Id == memberId);
            if (request == null) return null;

            request.FirstName = model.FirstName;
            request.LastName = model.LastName;
            request.DOB = model.DOB;
            request.ProgrammingLanguage = model.ProgrammingLanguage;
            request.PhoneNumber = model.PhoneNumber;
            request.Address = model.Address;
            
            _context.PersonalDetails.Update(request);
            await _context.SaveChangesAsync();
            return "Updated!";
        }

        public async Task<List<PersonalDetails>> GetAllMembersAsync()
        {
            var requests = await _context.PersonalDetails.ToListAsync();
            return requests;
        }

        public async Task<PersonalDetails> GetMemberByIdAsync(string MemberId)
        {
            var check = await _context.PersonalDetails.FirstOrDefaultAsync(x => x.Id == MemberId);
            if(check == null)
            {
                return null;
            }
            return check;
        }
    }
}
