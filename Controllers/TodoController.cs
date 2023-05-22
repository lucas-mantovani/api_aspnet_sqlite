using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using api_aspnet.Data;
using api_aspnet.Models;
using api_aspnet.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_aspnet.Controllers
{
    [ApiController]
    [Route("v1")]
    public class TodoController : ControllerBase
    {
        [Route("tarefas")]
        public async Task<IActionResult> GetAsync(
            [FromServices] AppDbContext context
        )
        {
            var Tarefas = await context.Tarefas.AsNoTracking().ToListAsync();
            return Ok(Tarefas);
        }


        [Route("tarefas/{id}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id
        )
        {
            var tarefa = await context.Tarefas.AsNoTracking().FirstOrDefaultAsync(tarefa => tarefa.Id == id);
            return tarefa != null ? Ok(tarefa) : NotFound();
        }


        [HttpPost("tarefas")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] CreateTarefa model
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var tarefa = new Tarefa
            {
                Date = System.DateTime.Now,
                Done = false,
                Title = model.Title
            };

            try
            {

                await context.Tarefas.AddAsync(tarefa);
                await context.SaveChangesAsync();
                return Created(uri: $"v1/tarefas/{tarefa.Id}", tarefa);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpPut("tarefas/{id}")]
        public async Task<IActionResult> PutAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id,
            [FromBody] CreateTarefa model
        )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var tarefa = await context.Tarefas.FirstOrDefaultAsync(tarefa => tarefa.Id == id);
            if (tarefa == null)
            {
                return NotFound();
            }

            try
            {

                tarefa.Title = model.Title;

                context.Tarefas.Update(tarefa);
                await context.SaveChangesAsync();
                return Ok(tarefa);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpDelete("tarefas/{id}")]
        public async Task<IActionResult> DeleteAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id
        )
        {
            var tarefa = await context.Tarefas.FirstOrDefaultAsync(tarefa => tarefa.Id == id);

            try
            {
                context.Tarefas.Remove(tarefa);
                await context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}