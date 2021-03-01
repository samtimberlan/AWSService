using System;

namespace Infrastructure
{
    public class ConfigKeys
    {
        public object AwsBucketName { get; set; }
        public object AwsS3BaseUrl { get; set; }
        public object AwsRegion { get; set; }
        public long FileSize { get; set; }
    }
}
