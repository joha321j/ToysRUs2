using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ToysRUs2.Models;
using ToysRUs2.Persistency;

namespace ToysRUs2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothesController : ControllerBase
    {

        private readonly ILogger<ClothesController> _logger;
        private readonly ClothesDatabaseContext _context;
        
        public ClothesController(ILogger<ClothesController> logger, ClothesDatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public Task<ActionResult<IEnumerable<Clothes>>> Get(int? clothingId, bool withImages = false)
        {
            try
            {
                return GetClothes(clothingId, withImages);
            }
            catch (Exception exception)
            {
                LogException(exception);
                throw;
            }
        }
        
        private Task<ActionResult<IEnumerable<Clothes>>> GetClothes(int? clothingId, bool withImages)
        {
            if (clothingId.HasValue)
            {
                return GetSpecificPieceOfClothes(clothingId.Value, withImages);
            }

            return GetAllClothes(withImages);
        }
        private async Task<ActionResult<IEnumerable<Clothes>>> GetSpecificPieceOfClothes(int clothingId,
            bool withImages)
        {
            List<Clothes> clothesList = new List<Clothes>();
            if (withImages)
            {
                Clothes clothes = await _context.ClothingSet
                    .Include(c => c.Images)
                    .AsNoTracking()
                    .FirstAsync(clothing => clothing.Id == clothingId);
                
                clothesList.Add(clothes);
            }
            else
            {
                Clothes clothes = await _context
                    .ClothingSet
                    .FirstAsync(clothing => clothing.Id == clothingId);
                clothesList.Add(clothes);
            }

            return clothesList;
        }

        private async Task<ActionResult<IEnumerable<Clothes>>> GetAllClothes(bool withImages)
        {
            List<Clothes> clothesList;

            if (withImages)
            {
                clothesList = await _context.ClothingSet
                    .Include(clothing => clothing.Images)
                    .AsNoTracking()
                    .ToListAsync();
            }
            else
            {
                clothesList = await _context.ClothingSet.ToListAsync();
            }

            return clothesList;
        }

        private void LogException(Exception exception)
        {
            _logger.Log(LogLevel.Error, @"Could not return clothes: {Exception}", exception);
        }
    }
}