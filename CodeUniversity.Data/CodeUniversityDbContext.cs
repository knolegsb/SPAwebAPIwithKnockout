using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUniversity.Data
{
    public class CodeUniversityDbContext : DbContext
    {
        public CodeUniversityDbContext() : base(nameOrConnectionString: "CodeUniversity") { }


    }
}
