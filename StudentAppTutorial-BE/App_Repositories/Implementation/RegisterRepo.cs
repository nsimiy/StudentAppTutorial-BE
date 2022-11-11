using StudentAppTutorial_BE.App_Repositories.Interface;
using StudentAppTutorial_BE.Data;
using StudentAppTutorial_BE.Model;

namespace StudentAppTutorial_BE.App_Repositories.Implementation
{
    public class RegisterRepo : IRegisterRepo
    {
        private readonly STATDbContext _sTATDbContext;
        public RegisterRepo(STATDbContext sTATDbContext)
        {
            _sTATDbContext = sTATDbContext;
        }

        public Task<Register> AccountExists(int studentId)
        {
            throw new NotImplementedException();
        }

        public Task<Register> AccountExists(string studentId)
        {
            throw new NotImplementedException();
        }

        public Register createStudent(Register register)
        {
            _sTATDbContext.Palette.Add(register);
            _sTATDbContext.SaveChanges();
            return register;


        }

        //public string RegisterStudent(Register register)
        //{
        //     _sTATDbContext.Palette.AddAsync(register);
        //     _sTATDbContext.SaveChangesAsync();
        //    return "registered";
        //}

        public Task<Register> updateStudent(Register register)
        {
            throw new NotImplementedException();
        }

    }
}
