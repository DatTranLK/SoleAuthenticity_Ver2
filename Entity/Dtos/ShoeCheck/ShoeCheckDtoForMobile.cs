using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Dtos.ShoeCheck
{
    public class ShoeCheckDtoForMobile
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string ShoeName { get; set; }
        public bool? IsAuthentic { get; set; }
        public string ImgPath { get; set; }
    }
}
