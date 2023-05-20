using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using coqueiros_modulo1_semana9_exercicio.Context;
using coqueiros_modulo1_semana9_exercicio.Model;

namespace coqueiros_modulo1_semana9_exercicio.Controllers
{

    [Route("semana")]
    [ApiController]
    public class SemanaController : Controller
    {
        private readonly SemanaContext _semana;
        public SemanaController(SemanaContext semana) 
        {
            _semana = semana;
        }

        [HttpPost]
        public ActionResult Post([FromBody] SemanaModel semanaModel)
        {
            if (semanaModel.Id != 0)
            {
                return BadRequest();
            }
            else
            {
                _semana.Semanas.Add(semanaModel);
                _semana.SaveChanges();
                return Ok();
            }
        }

        [HttpGet]
        public ActionResult  GetAll()
        {
                return Ok(_semana.Semanas.ToList());
            
        }

        [HttpGet("{id}")]
        public ActionResult GetId([FromRoute]int id) 
        {
                var filtro=_semana.Semanas.Where(s => s.Id == id);
                return Ok(filtro.ToList());
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] SemanaModel semanaModel,[FromRoute] int id)
        {
             var filtro = _semana.Semanas.Where(s => s.Id == id).FirstOrDefault();
            filtro.DataSemana = semanaModel.DataSemana;
            filtro.AplicadoConteudo = semanaModel.AplicadoConteudo;
            filtro.Conteudo = semanaModel.Conteudo;
            _semana.Semanas.Attach(filtro);
            _semana.SaveChanges();
             return Ok();
                
             
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteId([FromRoute] int id)
        {
            var filtro = _semana.Semanas.Where(s => s.Id == id).FirstOrDefault();
            if (filtro != null)
            {
                _semana.Remove(_semana.Semanas.Where(s => s.Id == id).FirstOrDefault());
                _semana.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
            
        }
    }
}
