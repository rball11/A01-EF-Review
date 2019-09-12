using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WestWindConsole.Entities
{
    [Table("Territories")]
    public class Territory
    {
        [Key, Range(0, 20)]
        public int TerritoryID { get; set; }

        [Required, StringLength(50, ErrorMessage = "Territory description is limited to 50 characters.")]
        public string TerritoryDescription { get; set; }

        public int RegionID { get; set; }
    }
}
