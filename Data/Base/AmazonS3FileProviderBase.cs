

using Syncfusion.EJ2.FileManager.Base;

namespace SfFileService.FileManager.Base
{
    public interface AmazonS3FileProviderBase : FileProviderBase
    {
        void RegisterAmazonS3(string bucketName, string awsAccessKeyId, string awsSecretAccessKey, string bucketRegion);
    }

}
