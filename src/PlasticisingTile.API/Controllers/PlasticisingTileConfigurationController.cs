using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlasticisingTile.API.DTO.Plasticising;
using PlasticisingTile.Core.Interfaces;

namespace PlasticisingTile.API.Controllers;

[ApiController]
[Route("api/plasticising-tile-configuration")]
public class PlasticisingTileConfigurationController : ControllerBase
{
    private readonly ILogger<PlasticisingTileConfigurationController> _logger;
    private readonly IPlasticisingTileConfigurationService _service;
    private readonly IMapper _mapper;

    public PlasticisingTileConfigurationController(
        ILogger<PlasticisingTileConfigurationController> logger,
        IPlasticisingTileConfigurationService service,
        IMapper mapper)
    {
        _logger = logger;
        _service = service;
        _mapper = mapper;
    }

    /// <summary>
    /// Retrieves plasticising tile default configuration.
    /// </summary>
    /// <returns>A plasticising tile default configuration</returns>
    /// <remarks>
    /// Sample request:
    ///
    ///     GET /plasticising-tile-configuration
    ///
    /// </remarks>
    /// <response code="200">Returns plasticising tile default configuration</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileConfigurationDto))]
    public async Task<IActionResult> GetAsync()
    {
        var configurationBo = await _service.GetPlasticisingTileConfiguration();
        var configurationDto = _mapper.Map<PlasticisingTileConfigurationDto>(configurationBo);

        return Ok(configurationDto);
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
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileConfigurationDto))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAsync(Guid id)
    {
        var configurationBo = await _service.GetPlasticisingTileConfiguration(id);
        var configurationDto = _mapper.Map<PlasticisingTileConfigurationDto>(configurationBo);

        return Ok(configurationDto);
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
// TODO: remove pragma warning disable when implemented
#pragma warning disable 1998
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileConfigureResponseDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync(PlasticisingTileConfigureRequestDto request)
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
#pragma warning restore 1998
}
