using BlueCodingTest;
using BlueCodingTest.Controllers;
using BlueCodingTest.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace BirdsUnitTest
{
    public class UnitTest1
    {
        public BirdsService _service;
        public static DbContextOptions<BirdsDbContext> dbContextOptions { get; }
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BirdsDB;Integrated Security=True";
        BirdsDbContext _context;

        static UnitTest1()
        {
            dbContextOptions = new DbContextOptionsBuilder<BirdsDbContext>()
                .UseSqlServer(connectionString)
                .Options;
            
        }
        public UnitTest1()
        {
            _context = new BirdsDbContext(dbContextOptions);
            _service = new BirdsService(_context);
        }
        [Fact]

        public void AllRecordFound()
        {
            var controller = new BirdsController(_service);
            var response=controller.Index();
            Assert.NotNull(response);
        }
        [Fact]

        public void SpecificRecordFound()
        {
            var controller = new BirdsController(_service);
            var response = controller.GetSpecificBird(1);
            Assert.NotNull(response);
        }
        [Fact]

        public void SpecificRecordNotFound()
        {
            var controller = new BirdsController(_service);
            var response = controller.GetSpecificBird(3);
            Assert.NotNull(response);
        }
    }
}
