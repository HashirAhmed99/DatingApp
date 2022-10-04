﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.Controllers
{
    //http:localhost:5000/api/value
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            this._context = context;
        }
        //Get api/values
        [HttpGet]
        public async Task<IActionResult>Getvalue()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        //GET api/value/5
        [HttpGet("{id}")]
        public async Task <IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
        //PostApi Values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }


    }
}