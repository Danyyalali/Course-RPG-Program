using AutoMapper;
using CourseProgram.Dtos.Character;
using CourseProgram.Dtos.Weapon;
using CourseProgram.Models;
using Program.Models;

namespace CourseProgram
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();

        }
    }
}
