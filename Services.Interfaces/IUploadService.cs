using Data;
using Data.RequestDTOs;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IUploadService
    {
        Task<bool> CreateBucketAsync(string bucketName);
        AWSUploadResult<string> GenerateAwsFileUrl(string bucketName, string key, bool useRegion = true);
        Task<AWSUploadResult<string>> UploadImageToS3BucketAsync(UploadRequestDto requestDto);
    }
}
