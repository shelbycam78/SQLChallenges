using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Challenges.ChallengeBonus
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string CourseCode { get; set; }
        public List<Professor> ProfessorId { get; set; }

    }
}
