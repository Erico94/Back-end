using Microsoft.AspNetCore.Mvc;
using API_Pessoal.Context;
using API_Pessoal.Models;

namespace API_Pessoal.Controllers
{
    [ApiController]
    [Route("tarefa")]
    public class SemanaController : Controller
    {
        private readonly SemanasContext _semana;

        public SemanaController (SemanasContext semana)
        {
            _semana = semana;
        }
        [HttpPost]
        public ActionResult AdicionarTarefa([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel.Id != 0)
            {
                return BadRequest("Aceita-se apenas Id de número 0.");
            }else
            {
                _semana.Semanas.Add(semanaModel);
                _semana.SaveChanges();
                return Ok();
            }
           
        }

        [HttpGet]
        public ActionResult ObterTodas()
        {
            foreach(var s in _semana.Semanas)
            {
                return ;
            }
            return Ok();
        }

        [HttpGet("id/{id}")]
        public ActionResult ObterPorId([FromRoute] int id)
        {
            return Ok();
        }

        [HttpGet("{nome}")]
        public ActionResult BuscaPorNome([FromQuery]string nome)
        {
            return Ok();
        }

        [HttpPatch("{id}")]
        public ActionResult EditarId([FromRoute] int id, [FromBody] SemanaModel semanaModel)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult DeleteId([FromRoute] int id)
        {
            return Ok();
        }
        
    }
}
