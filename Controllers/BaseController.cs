using System.ComponentModel;
using System.Runtime.ConstrainedExecution;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using CadastroTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace CadastroTeste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase where T : class 
    {
        IServiceBase<T> serv;

        public BaseController(IServiceBase<T> _serv)
        {
            serv = _serv;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var entities = await serv.Get();
                if (entities == null)
                {
                    return NotFound();
                }

                return Ok(entities);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("/id")]
        public async Task<IActionResult> GetById(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            try
            {
                var entity = await serv.GetById((int)id);

                if (entity == null)
                {
                    return NotFound();
                }

                return Ok(entity);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] T model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await serv.Add(model);
                    return Ok();

                }
                catch (Exception)
                {

                    return BadRequest();
                }

            }

            return BadRequest();
        }

        [HttpDelete]
        public async Task<IActionResult> Remove([FromBody] T model)
        {

            try
            {
                await serv.Remove(model);

                return Ok();
            }
            catch (Exception)
            {

                return BadRequest();
            }
        }


        [HttpPut]
        public async Task<IActionResult> Update([FromBody] T model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await serv.Update(model);

                    return Ok();
                }
                catch (Exception ex)
                {
                    if (ex.GetType().FullName == "Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException")
                    {
                        return NotFound();
                    }

                    return BadRequest();
                }
            }

            return BadRequest();
        }
    }
}