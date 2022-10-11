﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_TEST.DB.Models;

namespace API_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OuputsController : ControllerBase
    {
        private readonly API_DB_Context _context;

        public OuputsController(API_DB_Context context)
        {
            _context = context;
        }

        // GET: api/Ouputs
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Ouput>>> GetOuput(Input input)
        {
            string StoredProc = "exec SP_API_POST_PROVIDER " +
             "'" + input.strCode + "'";

            
            return await _context.Ouput.FromSqlRaw(StoredProc).ToListAsync();
        }

    }
}
