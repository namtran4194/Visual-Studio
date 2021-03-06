﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using DemoWebApiConnectDb.Models;

namespace DemoWebApiConnectDb.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        DbLazadaContext lazadaContext;
        public ValuesController(DbLazadaContext lazadaContext)
        {
            this.lazadaContext = lazadaContext;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<LoaiSanPham> Get()
        {
            return lazadaContext.tbLoaiSanPham.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
