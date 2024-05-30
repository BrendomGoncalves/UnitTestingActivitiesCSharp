using Amazon.Rekognition.Model;
using Amazon.Rekognition;
namespace Atividade15
{
    public class RekognitionClientWrapper : IRekognitionClientWrapper
    {
        private readonly AmazonRekognitionClient _rekognitionClient;

        public RekognitionClientWrapper(AmazonRekognitionClient rekognitionClient)
        {
            _rekognitionClient = rekognitionClient;
        }

        public async Task<DetectTextResponse> DetectTextAsync(DetectTextRequest request)
        {
            return await _rekognitionClient.DetectTextAsync(request);
        }
    }
}
