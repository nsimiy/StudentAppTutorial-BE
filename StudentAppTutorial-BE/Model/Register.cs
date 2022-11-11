using System.ComponentModel.DataAnnotations;

namespace StudentAppTutorial_BE.Model
{
    public class Register
    {
        [Key]
        public string studentId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int mobile { get; set; }
        public string gender { get; set; }
        public string password { get; set; }
        public string repeatPassword { get; set; }
    }
}
