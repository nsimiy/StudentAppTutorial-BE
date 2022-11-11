using StudentAppTutorial_BE.Model;

namespace StudentAppTutorial_BE.App_Repositories.Interface
{
    public interface IRegisterRepo
    {
        //Task<string> createStudent(Register register);
        Register createStudent(Register register);
        Task<Register> updateStudent(Register register);
        //string RegisterStudent(Register register);
        Task<Register> AccountExists(string studentId);
    }
}
