﻿using Microsoft.AspNetCore.Mvc;
using PlasticisingTile.API.DTO.Plasticising;

namespace PlasticisingTile.API.Controllers;

[ApiController]
[Route("api/plasticising-tile")]
public class PlasticisingTileController : ControllerBase
{
    private readonly ILogger<PlasticisingTileController> _logger;

    public PlasticisingTileController(ILogger<PlasticisingTileController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Retrieves plasticising tile with the given id.
    /// </summary>
    /// <param name="id">The id of the plasticising tile.</param>
    /// <returns>A plasticising tile with the given id if exists</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
    ///
    /// </remarks>
    /// <response code="200">Returns plasticising tile with the given id if exists</response>
    /// <response code="404">If the item is not found by the given id</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Saves configuration for plasticising tile
    /// </summary>
    /// <returns>plasticising tile configuration</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     PUT /plasticising-tile/c575d3a9-05f3-4d4c-a4c7-6e820c29312c
    ///     {
    ///        "": "",
    ///        "": ""
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returns the configuration updated</response>
    /// <response code="201">Returns the configuration created</response>
    /// <response code="404">If the item is not found by the given id</response>
    [HttpPut("{id?}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileSaveResponseDto))]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(PlasticisingTileSaveResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> Put(Guid? id, PlasticisingTileSaveRequestDto request)
    {
        throw new NotImplementedException();
    }
}
