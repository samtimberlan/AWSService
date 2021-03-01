using Data.RequestDTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Threading.Tasks;

namespace AWSService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AWSFileUploadController : ControllerBase
    {
        private readonly IUploadService _uploadService;

        public AWSFileUploadController(IUploadService uploadService)
        {
            _uploadService = uploadService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] UploadRequestDto requestDto)
        {
            var result = await _uploadService.UploadImageToS3BucketAsync(requestDto);
            return StatusCode(result.StatusCode);
        }

        [HttpPost("create-bucket")]
        public async Task<IActionResult> CreateS3BucketAsync(string bucketName)
        {
            await _uploadService.CreateBucketAsync(bucketName);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
