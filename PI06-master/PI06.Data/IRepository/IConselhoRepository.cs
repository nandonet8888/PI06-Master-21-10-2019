﻿using PI06.IRepository;
using PI06.Models.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PI06.Data.IRepository
{
   public interface IConselhoRepository : IRepository<Conselho> 
    {

        Conselho ConselhosExistente(string conselhosE);
       IEnumerable<Conselho> GetAllIncludingProperties();



    }
}
