using Amazon.Rekognition.Model;

namespace Atividade15
{
    public interface IRekognitionClientWrapper
    {
        Task<DetectTextResponse> DetectTextAsync(DetectTextRequest request);
    }
}
