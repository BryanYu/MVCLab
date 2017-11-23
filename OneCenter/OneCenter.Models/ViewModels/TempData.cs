using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace OneCenter.Models.ViewModels
{
    public class TempData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public IEnumerable<SelectListItem> DrowSelectList { get; set; }
    }
}