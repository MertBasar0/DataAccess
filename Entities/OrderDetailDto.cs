using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Keyless]
    public class OrderDetailDto
    {
        public int OrderID { get; set; }

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public DateTime OrderDate { get; set; }
    }
}