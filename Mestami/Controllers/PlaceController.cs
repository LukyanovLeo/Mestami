using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Dapper;
using System.Data.SqlClient;
using Npgsql;
using Mestami.Domain.Models.Geo;
using Mestami.Infrastructure.Repositories.Infra.Interfaces;
using Mestami.Domain.Aggregates.PlaceAggregate.Place;
using Mestami.Infrastructure.Repositories.Interfaces;
using System.Collections;
using Mestami.Infrastructure.DTO;
using Mestami.Domain.Aggregates.PlaceAggregate.Place;
using Mestami.Infrastructure.Requests;

namespace Mestami.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class LoungeBarController : Controller
    {
        private readonly ILogger<LoungeBarController> _logger;
        private readonly IDbConnectionFactory<NpgsqlConnection> _connectionFactory;
        private readonly ILoungeBarRepository _loungeBarRepository;

        public LoungeBarController(
            ILogger<LoungeBarController> logger, 
            IDbConnectionFactory<NpgsqlConnection> connectionFactory,
            ILoungeBarRepository loungeBarRepository)
        {
            _logger = logger;
            _connectionFactory = connectionFactory;
            _loungeBarRepository = loungeBarRepository;
        }


        [HttpGet]
        [Route("all")]
        public async Task<IEnumerable<LoungeBarDTO>> GetAllLoungeBars()
        {
            var allLoungeBars = await _loungeBarRepository.GetAllAsync();
            var allLoungeBarsDTO = allLoungeBars.Select(hp => ToDTO(hp));

            return allLoungeBarsDTO;
        }

        // TODO: сделать GET методом
        [HttpPost]
        [Route("filter")]
        public async Task<IEnumerable<LoungeBarDTO>> GetLoungeBarsByFilter([FromBody] GetLoungeBarsByFilterRequest request)
        {
            var allLoungeBars = await _loungeBarRepository.GetByFilterAsync(request.City, request.Title, request.Address, request.MetroStation);
            var allLoungeBarsDTO = allLoungeBars.Select(hp => ToDTO(hp));

            return allLoungeBarsDTO;
        }

        [HttpPost]
        [Route("new")]
        public async Task CreateNewLoungeBar([FromBody] CreateNewLoungeBarRequest request)
        {
            await _loungeBarRepository.AddLoungeBar(request);
        }

        private static LoungeBarDTO ToDTO(LoungeBar loungeBar)
        {
            return new LoungeBarDTO(
                loungeBar.Id,
                loungeBar.Title,
                loungeBar.City,
                loungeBar.Address,
                loungeBar.ApproxPrice,
                loungeBar.Pros,
                loungeBar.Cons,
                loungeBar.Quality.ToString(),
                loungeBar.VipRoomInfo
                );
        }
    }
}