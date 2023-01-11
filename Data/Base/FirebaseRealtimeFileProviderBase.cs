

using Syncfusion.Blazor.FileManager.Base;

namespace SfFileService.FileManager.Base
{
    public interface FirebaseRealtimeFileProviderBase : FileProviderBase
    {
        void RegisterFirebaseRealtimeDB(string apiUrl, string rootNode, string serviceAccountKeyPath);
    }

}
