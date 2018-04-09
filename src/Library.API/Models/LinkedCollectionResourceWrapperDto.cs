using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.API.Models
{
    public class LinkedCollectionResourceWrapperDto<T> : LinkedResourceBasedDto 
        where T : LinkedResourceBasedDto
    {
        public IEnumerable<T> Value { get; set; }

        public LinkedCollectionResourceWrapperDto(IEnumerable<T> value)
        {
            Value = value;
        }
    }
}
