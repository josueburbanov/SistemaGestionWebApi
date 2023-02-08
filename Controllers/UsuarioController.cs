using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Modelos;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("{usuario}/{contrasena}")]
        public Usuario Login(string usuario, string contrasena)
        {
            return ManejadorUsuario.Login(usuario, contrasena);
        }

        [HttpPost]
        public void CrearUsuario(Usuario usuario)
        {
            ManejadorUsuario.InsertarUsuario(usuario);
        }
    }
}
