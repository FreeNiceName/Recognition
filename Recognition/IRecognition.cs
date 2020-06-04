namespace Recognition
{
    public interface IRecognition
    {
        RecognitionResult Run(string imagePath);
    }
}
