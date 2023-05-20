using Locacao.Context;
using Locacao.DTO;
using Locacao.Model;
using Microsoft.AspNetCore.Mvc;

namespace Locacao.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly LocacaoContext _bd;
        public CarroController(LocacaoContext bd)
        {
            _bd = bd;
        }
//Cadastrar
        [HttpPost]
        public ActionResult Inserir([FromBody] CarroDTO carroDTO)
        {
            if (carroDTO == null)
            {
                return BadRequest("Precisa inserir dados.");
            }
            else
            {
                if (carroDTO.Codigo != 0)
                {
                    return BadRequest("Código deve ser igual a zero(0).");
                }
                else
                {
                    var buscaMarca = _bd.Marcas.Where(marca => marca.ID == carroDTO.CodigoMarca).FirstOrDefault();
                    if (buscaMarca != null)
                    {
                        CarroModel carroModel = new CarroModel()
                        {
                            Id = carroDTO.Codigo,
                            Nome = carroDTO.DescricaoCarro,
                            DataLocacao = carroDTO.DataLocacao,
                            //IdMarca = buscaMarca.ID,
                            Marca = buscaMarca

                        };
                        _bd.Carros.Add(carroModel);
                        _bd.SaveChanges();
                        return Ok("Salvo com sucesso.");
                    }
                    else { return BadRequest("Código de marca não encontrado."); }
                }
            }
        }

//Obter todos
        [HttpGet]
        public ActionResult<List<CarroMarcaGetDTO>> ObterTodos()
        {
            {
                List<CarroMarcaGetDTO> listaCarroGetDTO = new List<CarroMarcaGetDTO>();

                foreach (var buscaCarro in _bd.Carros)
                {
                    var carroGetDTO = new CarroMarcaGetDTO();
                    carroGetDTO.Codigo = buscaCarro.Id;
                    carroGetDTO.DescricaoCarro = buscaCarro.Nome;
                    //carroGetDTO.CodigoMarca = buscaCarro.Marca.ID;
                    carroGetDTO.DataLocacao = buscaCarro.DataLocacao;
                    carroGetDTO.ListaMarcaDTO = new List<MarcaDTO>();
                    foreach (var buscaMarca in _bd.Marcas)
                    {
                        if (buscaMarca.ID == buscaCarro.Marca.ID)
                        {
                            MarcaDTO marcaDTO = new MarcaDTO()
                            {
                                Codigo = buscaMarca.ID,
                                Nome = buscaMarca.Nome
                            };
                            carroGetDTO.ListaMarcaDTO.Add(marcaDTO);
                        }
                    }
                    listaCarroGetDTO.Add(carroGetDTO);
                }
                return Ok(listaCarroGetDTO);
            }
        }
//Obter por Codigo
        [HttpGet("codigo/{codigo}")]
        public ActionResult<CarroMarcaGetDTO> ObterCodigo([FromRoute] int codigo)
        {
            var filtro = _bd.Carros.Where(o => o.Id == codigo).FirstOrDefault();
            var carroGetDTO = new CarroMarcaGetDTO();
            var item = _bd.Carros.Where(carro => carro.Id == codigo).FirstOrDefault();
            if (item != null)
            {
                carroGetDTO.Codigo = item.Id;
                carroGetDTO.DescricaoCarro = item.Nome;
                //carroGetDTO.CodigoMarca = item.IdMarca;
                carroGetDTO.DataLocacao = item.DataLocacao;
                carroGetDTO.ListaMarcaDTO = new List<MarcaDTO>();
                foreach (var buscaMarca in _bd.Marcas)
                {
                    if (buscaMarca.ID == carroGetDTO.CodigoMarca)
                    {
                        MarcaDTO marcaDTO = new MarcaDTO()
                        {
                            Codigo = buscaMarca.ID,
                            Nome = buscaMarca.Nome
                        };
                        carroGetDTO.ListaMarcaDTO.Add(marcaDTO);
                    }
                }
                return Ok(carroGetDTO);
            }
            else { return BadRequest("Não foi possivel encontrar o código."); }
        }

//Atualizar dados
        [HttpPut("codigo/{codigo}")]
        public ActionResult EditarPorCodigo([FromBody] CarroDTO carroAtualizado, [FromRoute] int codigo)
        {
            if (carroAtualizado == null)
            {
                return BadRequest("Insira os dados.");
            }else
            {
                var buscaCarro = _bd.Carros.Where(carro => carro.Id == codigo).FirstOrDefault();
                if (buscaCarro != null)
                {
                    buscaCarro.Id = codigo;
                    buscaCarro.Nome = carroAtualizado.DescricaoCarro;
                    buscaCarro.DataLocacao = carroAtualizado.DataLocacao;
                    //buscaCarro.IdMarca = carroAtualizado.CodigoMarca;
                    MarcaModel buscaMarca = _bd.Marcas.Where(marca => marca.ID == carroAtualizado.CodigoMarca).FirstOrDefault();
                    if(buscaMarca != null)
                    {
                        buscaCarro.Marca = buscaMarca;
                    }
                    _bd.Carros.Attach(buscaCarro);
                    _bd.SaveChanges();
                    return Ok();
                }
                
            }
            return Ok();
        }

//Deletar por código:
        [HttpDelete("codigo/{codigo}")]
        public ActionResult DeletarPorCodigo([FromRoute] int codigo)
        {
            CarroModel buscaCarro = _bd.Carros.Where(carro => carro.Id == codigo).FirstOrDefault();
            if (buscaCarro != null)
            {
                _bd.Carros.Remove(buscaCarro);
                _bd.SaveChanges();
                return Ok();
            }
            else
            {  return BadRequest("Código não encontrado."); }
        }
    }
}
