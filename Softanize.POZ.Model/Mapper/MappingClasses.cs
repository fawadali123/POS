using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Softanize.POZ.DataAccess.Models;
using Softanize.POZ.Model.DTO;
namespace Softanize.POZ.Model.Mapper
{
    public class MappingClasses: Profile
    {
        public MappingClasses()
        {
            CreateMap<CategoryDTO, Category>().ReverseMap();
        }
    }   
}
