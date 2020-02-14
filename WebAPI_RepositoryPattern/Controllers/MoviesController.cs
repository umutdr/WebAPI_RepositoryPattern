using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI_RepositoryPattern.Data;
using WebAPI_RepositoryPattern.Data.EFCore;
using WebAPI_RepositoryPattern.Models;

namespace WebAPI_RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : DataController<Movie, EfCoreMovieRepository>
    {
        public MoviesController(EfCoreMovieRepository repository) : base(repository)
        {

        }
    }
}
