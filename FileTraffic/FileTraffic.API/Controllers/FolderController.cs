using AutoMapper;
using FileTraffic.Application.DTOs;
using FileTraffic.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileTraffic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FolderController : ControllerBase
    {
        private readonly IFolderService _folderService;

        public FolderController(IFolderService folderService)
        {
            _folderService= folderService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FolderDTO>>> GetFolders()
        {
            var folders = await _folderService.GetFolder();
            if (folders == null) {
                return NotFound("There aren't folders in database.");
            }

            return Ok(folders);
        }

        [HttpGet("{id}", Name = "GetFolders")]
        public async Task<ActionResult<IEnumerable<FolderDTO>>> GetFolders(int id)
        {
            var folders = await _folderService.GetFolderById(id);
            if (folders == null)
            {
                return NotFound("There isn't any folder in database.");
            }

            return Ok(folders);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] FolderDTO folderDTO)
        {
            if (folderDTO == null)
                return BadRequest("Data Invalid");

            await _folderService.Add(folderDTO);

            return new CreatedAtRouteResult("GetFolder",
                new { id = folderDTO.Id }, folderDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] FolderDTO folderDTO)
        {
            if (id != folderDTO.Id)
            {
                return BadRequest("Data invalid");
            }

            if (folderDTO == null)
                return BadRequest("Data invalid");

            await _folderService.Update(folderDTO);

            return Ok(folderDTO);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<FolderDTO>> Delete(int id)
        {
            var folderDTO = await _folderService.GetFolderById(id);

            if (folderDTO == null)
            {
                return NotFound("Product not found");
            }

            await _folderService.Remove(id);

            return Ok(folderDTO);
        }

    }
}
