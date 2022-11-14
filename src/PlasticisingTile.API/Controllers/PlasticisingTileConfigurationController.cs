﻿using Microsoft.AspNetCore.Mvc;
using PlasticisingTile.API.DTO.Plasticising;

namespace PlasticisingTile.API.Controllers;

[ApiController]
[Route("api/plasticising-tile-configuration")]
public class PlasticisingTileConfigurationController : ControllerBase
{
    private readonly ILogger<PlasticisingTileConfigurationController> _logger;

    public PlasticisingTileConfigurationController(ILogger<PlasticisingTileConfigurationController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Retrieves plasticising tile configuration with the given id.
    /// </summary>
    /// <param name="id">The id of the plasticising tile configuration.</param>
    /// <returns>A plasticising tile configuration with the given id if exists</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /plasticising-tile-configuration/5993049c-7cb1-47fe-87f0-35f06d5982f9
    ///
    /// </remarks>
    /// <response code="200">Returns plasticising tile configuration with the given id if exists</response>
    /// <response code="404">If the item is not found by the given id</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Fetches plasticising tile data based on configuration
    /// </summary>
    /// <returns>plasticising tile data</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     POST /plasticising-tile-configuration/
    ///
    /// </remarks>
    /// <response code="200">Returns plasticising tile data based on a configuration</response>
    /// <response code="400">If any of the parameters sent is invalid</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileConfigureResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Post(PlasticisingTileConfigureRequestDto request)
    {
        return Ok(new PlasticisingTileConfigureResponseDto
        {
            Series = new List<PlasticisingSerieDto>()
            {
                new PlasticisingSerieDto
                {
                    DataPoints = new List<int>() { 1, 2, 3, 4 },
                    Name = "Max Plasticising",
                }
            }
        });
    }
}
