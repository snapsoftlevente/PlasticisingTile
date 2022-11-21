using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlasticisingTile.API.DTO.Plasticising;
using PlasticisingTile.Core.BusinessObjects.Plasticising;
using PlasticisingTile.Core.Interfaces.Services;

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
        var configurationBo = await _service.GetPlasticisingTileConfigurationAsync();
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
        var configurationBo = await _service.GetPlasticisingTileConfigurationAsync(id);
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
    ///     {
    ///         "dateTimeRangeFilter": {
    ///             "dateTimeFrom": "2018-07-09T14:20:00.000Z",
    ///             "dateTimeTo": "2018-07-09T14:40:00.000Z"
    ///         },
    ///         "selectedColumnKeys": [
    ///             "cx300_Plasticising_Linearity", 
    ///             "px050_Plasticising_Linearity", 
    ///             "px120_Plasticising_Linearity", 
    ///             "px160_Plasticising_Linearity", 
    ///             "px200_Plasticising_Linearity", 
    ///             "px080_Plasticising_Linearity"
    ///         ],
    ///         "selectedAggregations": [
    ///             "average", 
    ///             "minimum", 
    ///             "maximum"
    ///         ]
    ///     }
    ///
    /// </remarks>
    /// <response code="200">Returns plasticising tile data based on a configuration</response>
    /// <response code="400">If any of the parameters sent is invalid</response>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(PlasticisingTileDto))]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<IActionResult> PostAsync(PlasticisingTileConfigureRequestDto request)
    {
        var requestBo = _mapper.Map<PlasticisingTileConfigureRequestBo>(request);
        var tileBo = await _service.GetPlasticisingTileAsync(requestBo);
        var tileDto = _mapper.Map<PlasticisingTileDto>(tileBo);

        return Ok(tileDto);
    }
}
