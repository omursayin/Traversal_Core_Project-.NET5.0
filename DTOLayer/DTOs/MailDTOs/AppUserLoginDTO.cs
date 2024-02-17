using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.MailDTOs
{
    public class AppUserLoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
