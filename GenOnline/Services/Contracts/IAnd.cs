using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;
using GenOnline.Services.UriMappingConstants;

namespace GenOnline.Services.Contracts
{
    [ServiceContract]
    public interface IAnd
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = UriMappingsMisc.GetLoggedInUserId)]
        string GetLoggedInUserId();

        [OperationContract]
        [WebInvoke(Method = "POST", ResponseFormat = WebMessageFormat.Json, UriTemplate = UriMappingsMisc.DoNothing, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        string DoNothing();




    }
}
