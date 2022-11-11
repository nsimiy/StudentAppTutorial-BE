using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAppTutorial_BE.App_Repositories.Implementation;
using StudentAppTutorial_BE.App_Repositories.Interface;
using StudentAppTutorial_BE.Data;
using StudentAppTutorial_BE.Model;


namespace StudentAppTutorial_BE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        public readonly IRegisterRepo _registerRepo;
        public readonly STATDbContext _sTATDbContext;

        public RegisterController(IRegisterRepo register, STATDbContext sTATDbContext)
        {
            _registerRepo = register;
            _sTATDbContext = sTATDbContext;
        }

        //[HttpPost("registration")]
        //public IActionResult RegisterStudent([FromBody] Register register)
        //{
        //    return new OkObjectResult(_registerRepo.RegisterStudent(register));
        //}

        [HttpPost("CreateStudent")]
        public  IActionResult createStudent([FromBody] Register register)
        {
            Response response = new Response();
            try
            {
                // var createStudent = await _sTATDbContext.Palette.Where(x => x.studentId.Contains(register.studentId)).FirstOrDefaultAsync();

                _registerRepo.createStudent(register);
                response.Status = true;
                response.Message = "successful";
                return new OkObjectResult(response);

            }
            catch
            {
                response.Status = false;
                response.Message = "failed";
                return BadRequest(response);
            }


        }
    }
}
