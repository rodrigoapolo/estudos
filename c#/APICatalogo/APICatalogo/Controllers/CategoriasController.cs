using APICatalogo.Context;
using APICatalogo.DTOs;
using APICatalogo.DTOs.Mappings;
using APICatalogo.Filters;
using APICatalogo.Models;
using APICatalogo.Repositories;
using APICatalogo.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Umbraco.Core.Persistence;

namespace APICatalogo.Controllers;

[Route("[controller]")]
[ApiController]
public class CategoriasController : ControllerBase
{
    private readonly IUnitOfWork _uof;
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;

    public CategoriasController(IConfiguration configuration,
        ILogger<CategoriasController> logger,
        IUnitOfWork uof)
    {

        _configuration = configuration;
        _logger = logger;
        _uof = uof;
    }

    [HttpGet("LerArquivoConfiguracao")]
    public string GetValor()
    {
        var valor1 = _configuration["chave1"];
        var valor2 = _configuration["chave2"];

        var secao1 = _configuration["secao1:chave2"];

        return $"Chave1 = {valor1} \nChave2 = {valor2} \nSecao1 => chave2 = {secao1}";
    }

    [HttpGet("UsandoFromServices/")]
    public ActionResult<string> GetSaudacaoSemFromServices([FromServices] IMeuServico meuServico,
                                                            string nome)
    {
        return meuServico.Saudacao(nome);
    }

    [HttpGet("SemUsarFromServices/")]
    public ActionResult<string> GetSaudacaoFromServices(IMeuServico meuServico,
                                                        string nome)
    {
        return meuServico.Saudacao(nome);
    }

    //[HttpGet("produtos")]
    //public ActionResult<IEnumerable<Categoria>> GetCategoriasProdutos()
    //{
    //    _logger.LogInformation("=================get/api/categoria/produtos==================");
    //    //return _context.Categorias.Include(p => p.Produtos).ToList();
    //    return _context.Categorias.Include(p => p.Produtos).Where(c => c.CategoriaId <= 5).ToList();
    //}

    [HttpGet]
    [ServiceFilter(typeof(ApiLoggingFilter))]
    public ActionResult<IEnumerable<CategoriaDTO>> Get()
    {
        var categorias = _uof.CategoriaRepository.GetAll();
        var categoriasDto = categorias.ToCategoriaDTOList();
        return Ok(categorias);

    }

    [HttpGet("{id:int}", Name = "ObterCategoria")]
    public ActionResult<CategoriaDTO> Get([FromQuery] int id)
    {
        var categoria = _uof.CategoriaRepository.Get(c => c.CategoriaId == id);

        if (categoria is null)
        {
            _logger.LogWarning($"Categoria com id = {id} não encontrada...");
            return NotFound($"Categoria com id={id} não encontrado");
        }

        var categoriaDto = categoria.ToCategoriaDTO();
        return Ok(categoriaDto);     
    }

    [HttpPost]
    public ActionResult<CategoriaDTO> Post(CategoriaDTO categoriaDto)
    {

        if (categoriaDto is null)
        {
            _logger.LogWarning($"Dados inválidos...");
            return BadRequest("Dados inválidos");
        }

        var categoria = categoriaDto.ToCategoria();
        var categoriaCriada = _uof.CategoriaRepository.Create(categoria);
        _uof.Commit();

        var novaCategoriaDto = categoriaCriada.ToCategoriaDTO();

        return new CreatedAtRouteResult("ObterCategoria", new { id = novaCategoriaDto.CategoriaId }, novaCategoriaDto);
    }

    [HttpPut("{id:int}")]
    public ActionResult<CategoriaDTO> Put(int id, CategoriaDTO categoriaDto)
    {

        if (id != categoriaDto.CategoriaId)
        {
            _logger.LogWarning($"Dados inválidos...");
            return BadRequest("Dados inválidos");
        }
        var categoria = categoriaDto.ToCategoria();
        var categoriaAtualizada = _uof.CategoriaRepository.Update(categoria);
        _uof.Commit();

        var categoriaAtualizadaDto = categoriaAtualizada.ToCategoriaDTO();

        return Ok(categoriaAtualizadaDto); 
    }

    [HttpDelete("{id:int}")]
    public ActionResult<CategoriaDTO> Delete(int id)
    {

        var categoria = _uof.CategoriaRepository.Get(c => c.CategoriaId == id);

        if (categoria is null)
        {
            _logger.LogWarning($"Categoria com id={id} não localizado...");
            return NotFound($"Categoria com id={id} não localizado...");
        }

        var categoriaExcluida = _uof.CategoriaRepository.Delete(categoria);
        _uof.Commit();
        var categoriaExcluidaDto = categoriaExcluida.ToCategoriaDTO();

        return Ok(categoriaExcluidaDto);
    }
}
