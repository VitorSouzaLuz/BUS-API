using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUSAPI.Data;
using BUSAPI.Models;
using BUSAPI.Models.Enuns;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BUSAPI.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class OnibusControllerDB : ControllerBase
    {
        private readonly DataContext _context;

        public OnibusControllerDB(DataContext context)
        {
            _context = context;              
            
       }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetBus(int id)
    {
        try 
        {
            Onibus o = await _context.TB_ONIBUS.FirstOrDefaultAsync(oBusca => oBusca.Id == id);

            return Ok(o);

        }

        catch (System.Exception ex)
        {
            return BadRequest(ex.Message);

        }
    
    }
    
    [HttpPost("adicionar")]
    public async Task<IActionResult> Add(Onibus novoOnibus)
    {
    try  
     { 

       await _context.TB_ONIBUS.AddAsync(novoOnibus);
       await _context.SaveChangesAsync();

       return Ok(novoOnibus.Id);

     
     }
     catch (System.Exception ex)
     {
        return BadRequest(ex.Message);
     }
       
     }

     [HttpPut("Atualiza")]
    public async Task<IActionResult> Atualiza(Onibus novoOnibus)
    {
        
    try
        
     { 

       _context.TB_ONIBUS.Update(novoOnibus);
       int linhas = await _context.SaveChangesAsync();

       return Ok(linhas + "A linha foi alterada");

     
     }
     catch (System.Exception ex)
     {
        return BadRequest(ex.Message);
     }
       
     }

/*
    [HttpDelete("{id}")]
    public async Task<IActionResult> Deletar(int id)
    {
        
    try
        
     { 

        Onibus remove = await _context.TB_ONIBUS.FirstOrDefaultAsync(x => x.Id == id);

       _context.TB_ONIBUS.Remove(remove);
       int linhas = await _context.SaveChangesAsync();

        return Ok("A linha Pertencente ao " + id + " Foi Excluido :(");

     
     }
     catch (System.Exception ex)
     {
        return BadRequest(ex.Message);
     }
       
     }
*/
     

     }
   
 }
