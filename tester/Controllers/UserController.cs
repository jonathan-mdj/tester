using Microsoft.AspNetCore.Mvc;

namespace tester.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // Lista temporal para simular la base de datos de usuarios
        private static List<User> users = new List<User>();

        // Método GET para obtener la lista de usuarios
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(users);
        }

        // Método POST para registrar un nuevo usuario con su localización
        [HttpPost]
        public IActionResult AddUser([FromBody] User newUser)
        {
            if (newUser == null)
            {
                return BadRequest("Usuario no puede ser nulo");
            }

            users.Add(newUser);
            return Ok(newUser);
        }
    }

    // Clase User para simular la estructura del usuario
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }

}
