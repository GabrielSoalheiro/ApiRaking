#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using RankingApi.Services;
using RankingApi.Context;

namespace RankingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RankingController : ControllerBase
    {
         #region [Quizzes que virão da api]
        private  readonly Quiz[] quizes = new Quiz[]
        {
            new Quiz
            {
                Id=1,
                Nome="Gabriel Fernando",
                NotaTotal= 9,
                TempoTotal=new TimeSpan(70,70,70),
            },
            new Quiz
            {
                Id=2,
                Nome="Jorge Alves",
                NotaTotal= 10,
                TempoTotal=new TimeSpan(0,10,40),
            },
            new  Quiz
            {
                Id=3,
                Nome="Jorge Alencar",
                NotaTotal= 8,
                TempoTotal=new TimeSpan(40,0,0),
            },
            new  Quiz
            {
                Id=4,
                Nome="Pedro Jorge",
                NotaTotal= 7,
                TempoTotal=new TimeSpan(20,0,0),
            },
            new  Quiz
            {
                Id=5,
                Nome="Lucas Jorge",
                NotaTotal= 6,
                TempoTotal=new TimeSpan(10,0,0),
            },
            new  Quiz
            {
                Id=6,
                Nome="Gabriel Jorge",
                NotaTotal= 5,
                TempoTotal=new TimeSpan(8,0,0),
            },
            new Quiz
            {
                Id=7,
                Nome="Gabriel Soalheiro",
                NotaTotal= 4,
                TempoTotal=new TimeSpan(7,0,0),
            },
            new Quiz
            {
                Id=8,
                Nome="Gel Só",
                NotaTotal= 3,
                TempoTotal=new TimeSpan(6,0,0),
            },
            new Quiz
            {
                Id=9,
                Nome="Soalheiro Jorge",
                NotaTotal= 2,
                TempoTotal=new TimeSpan(5,0,0),
            },
            new Quiz
            {
                Id=10,
                Nome="Gabriel Silva",
                NotaTotal= 1,
                TempoTotal=new TimeSpan(4,0,0),
            },
             new Quiz
            {
                Id=10,
                Nome="Uai",
                NotaTotal= 2,
                TempoTotal=new TimeSpan(12,0,0),
            }
        };
        #endregion
        [HttpGet("userranking")]
        public IEnumerable<Ranking> UserRanking()
        {
            var quizzes = this.quizes;
            return new RankingService().GetTop10(quizzes);
        }
    }
}
