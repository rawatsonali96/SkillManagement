using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SkillRepository
{
    public static class DbInitializer
    {
        public static void Initialize(DatabaseSet context)
        {
            context.Database.EnsureCreated();
            if (context.Skills.Any())
            {
                

            }
        }
    }
}
