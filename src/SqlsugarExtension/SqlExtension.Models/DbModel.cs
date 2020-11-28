using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlExtension.Models
{
    public class DatabaseModel
    {
        public string DatabaseName;

        public List<DbTableDto> Tables = null;
    }

    public class DbTableDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
