using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiDoodle.Net.Http.Client.Model;

namespace Meubelen.Model.Dtos
{
    public class ClientDto : IDto
    {

        public string Name { get; set; }
        public string Email { get; set; }

    }
}
