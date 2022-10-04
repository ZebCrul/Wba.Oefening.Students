using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wba.Oefening.Students.Core
{
    public class StudentsRepository
    {
        public IEnumerable<Student> GetStudents()
        {
            return new List<Student>
            {
                new Student{ Id = 1, FirstName = "Boris", LastName = "Schmitzer", Course = "Bachelor Expert"  },
                new Student{ Id = 2, FirstName = "Boris", LastName = "Schmatzer",Course = "Web Frontend Advanced"   },
                new Student{ Id = 3, FirstName = "Boris", LastName = "Schmotzer", Course = "Programming Expert"   },
                new Student{ Id = 3, FirstName = "Boris", LastName = "Schmutzer", Course = "Web Backend" }
            };
        }
    

    }
}
