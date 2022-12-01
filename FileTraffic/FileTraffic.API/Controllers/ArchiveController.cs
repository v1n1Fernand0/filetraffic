using FileTraffic.Application.DTOs;
using FileTraffic.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileTraffic.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArchiveController : ControllerBase
    {
        private readonly IArchiveService _archiveService;
        public ArchiveController(IArchiveService archiveService)
        {
            _archiveService= archiveService;
        }

        [HttpGet("{folderKey}")]
        public async Task<ActionResult<IEnumerable<ArchiveDTO>>> GetArchives()
        {
            var archives = await _archiveService.GetArchives();
            if (archives == null)
            {
                return NotFound($"There are not archives in database.");
            }

            return Ok(archives);
        }

        [HttpGet("{id},{folderkey}", Name = "GetArchives")]
        public async Task<ActionResult<ArchiveDTO>> GetArchives(int id)
        {
            var folders = await _archiveService.GetArchiveById(id);
            if (folders == null)
            {
                return NotFound("There isn't any folder in database.");
            }

            return Ok(folders);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ArchiveDTO archiveDTO)
        {
            if (archiveDTO == null)
                return BadRequest("Data Invalid");

            await _archiveService.Add(archiveDTO);

            return new CreatedAtRouteResult("GetArchive",
                new { id = archiveDTO.Id }, archiveDTO);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ArchiveDTO archivesDTO)
        {
            if (id != archivesDTO.Id)
            {
                return BadRequest("Data invalid");
            }

            if (archivesDTO == null)
                return BadRequest("Data invalid");

            await _archiveService.Update(archivesDTO);

            return Ok(archivesDTO);
        }

        [HttpDelete("{id},{fileKey}")]
        public async Task<ActionResult<FolderDTO>> Delete(int id)
        {
            var archiveDTO = await _archiveService.GetArchiveById(id);

            if (archiveDTO == null)
            {
                return NotFound("Archive not found");
            }

            await _archiveService.Remove(id);

            return Ok(archiveDTO);
        }
    }
}
