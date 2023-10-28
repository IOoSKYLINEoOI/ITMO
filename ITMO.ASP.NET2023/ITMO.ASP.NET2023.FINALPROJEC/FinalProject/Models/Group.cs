using System.Numerics;

namespace FinalProject.Models
{
    public class Group
    {
        public int GroupId { get; set; }

        public string NumberGroup { get; set; }


        public IEnumerable<Student> Students { get; set; }

    }
}
