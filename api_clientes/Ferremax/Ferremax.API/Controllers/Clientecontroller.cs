using Ferremax.API.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Ferremax.API.Controllers
{
 
    [ApiController]
    [Route("Cliente")]
    public class Clientecontroller : ControllerBase
    {
        Cliente cliente1 = new Cliente(1, "Ferreteria don gato Lmtada", "122342341", "Avenida cardenal caro 2140, Loprado","Salvador","Rojas","967426874");
        Cliente cliente2 = new Cliente(2, "Ferreteria pepito el constructor Lmtada", "121231234", "Avenida vicuña mackenna 4860, Macul","Pepito","Perez","978216587");
        Cliente cliente3 = new Cliente(3, "Construmax","122341234","Pedro de valdivia 1265 ,macul","Gerardo","Reyes","983658223");
        Cliente cliente4 = new Cliente(4,"Importadora todo al costo","189994638","Avenida nueva providencia 3756 depto 87, Providencia","Ernesto","Cardenas","996174834");
        Cliente cliente5 = new Cliente(5 ,"Hagalo usted mismo","186547775","Guardia vieja 2046, Estacion Central","Roberto","Lopez","954376543");
        private static IList<Cliente> cliente = new List<Cliente>() { new Cliente(2, "Ferreteria pepito el constructor Lmtada", "121231234", "avenida vicuña mackenna 4860, macul", "Pepito", "Perez", "978216587"), new Cliente(1,"Ferreteria don gato Lmtada", "122342341", "avenida cardenal caro 2140, Loprado","Salvador","Rojas", "967426874"), new Cliente(3, "Construmax", "122341234", "pedro de valdivia 1265 ,macul","Gerardo","Reyes", "983658223") 
        , new Cliente(4,"Importadora todo al costo","189994638","Avenida nueva providencia 3756 depto 87, Providencia","Ernesto","Cardenas","996174834") ,new Cliente(5,"Hagalo usted mismo","186547775","Guardia vieja 2046, Estacion Central","Roberto","Lopez","954376543")};
  

        [HttpGet]
        [Route("listar")]
        public dynamic ListarCliente()
        {
       
            return cliente;

        }

        [HttpGet]
        [Route("buscar")]
        public Cliente ListarCliente2(String rut)
        {
            Cliente clienteEncontrado = cliente.FirstOrDefault(x => x.rut == rut);
            return  clienteEncontrado;
        }
      

        [HttpPost]
        [Route("nuevo")]
        public void NuevoCliente([FromBody] Cliente nuevoCliente)
        {

            cliente.Add(nuevoCliente);

        }

        [HttpDelete]
        [Route("borra")]
        public IList<Cliente> borrarCliente([FromBody] String rut)
        {

            cliente.Remove(cliente.FirstOrDefault(x => x.rut == rut));
            return cliente;
        }


        [HttpPut]
        [Route("actualizar")]
        public Cliente actualizarCliente([FromBody] Cliente clienteActualizado)
        {
            Cliente clienteEncontrado = cliente.FirstOrDefault(x => x.rut == clienteActualizado.rut);
            return cliente[cliente.IndexOf(clienteEncontrado)] = clienteActualizado;
        }
        

    }
}
