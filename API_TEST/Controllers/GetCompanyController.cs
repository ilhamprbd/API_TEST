﻿using API_TEST.DB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_TEST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetCompanyController : ControllerBase
    {


        private readonly API_DB_Context _context;

        public GetCompanyController(API_DB_Context context)
        {
            _context = context;
        }




        // GET: api/Ouputs
        [HttpPost]
       // public async Task<ActionResult<IEnumerable<NBApplication>>> GetOuput(Input input)
             public async Task<ActionResult<IEnumerable<GetCompanyOutput>>> GetOuput()
            {
            string StoredProc = "exec [SP_API_COMPANY] ";// +
           //  "'" + input.strCode + "'";


            return await _context.GetCompanyOutput.FromSqlRaw(StoredProc).ToListAsync();
        }
    }
}
