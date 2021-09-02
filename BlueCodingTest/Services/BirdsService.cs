using BlueCodingTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlueCodingTest.Services
{
    public class BirdsService : IBirds
    {
        public BirdsDbContext _dbContext { get; set; }
        public BirdsService(BirdsDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<Birds> getList()
        {
            List<Birds> list = new List<Birds>();
            list = _dbContext.Set<Birds>().ToList();
            return list;
        }

    }
}
