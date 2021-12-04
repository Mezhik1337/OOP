/*using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML
{
    class SAX : IStrategy
    {
        public List<Student> Algorithm(Student student, string path) 
        {
            info.clear();

            List<Student> result = new List<Student>();
            Student st = null;
            string _specality = null;
            string _group = null;

            while (BestReader.Read()) 
            {
                if (BestReader.Name == "specialty") 
                {
                    while (BetReader.MoveTextAttribute()) 
                    {
                        if (BestReader.Name == "SPECIALITY") 
                        {
                            _specality = BestReader.value;
                        }
                    }
                }

                if (BestReader.Name == "group")
                {
                    while (BetReader.MoveTextAttribute())
                    {
                        if (BestReader.Name == "GROUP")
                        {
                            _group = BestReader.value;
                        }
                    }
                }
                
            }

        }
    }
}
*/