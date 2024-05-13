using CSharpFunctionalExtensions;

namespace Clinic.Core.Models
{
    public class Image
    {
        public const int MAX_FILENAME_LENGTH = 250;

        private Image(string fileName)
        {
            FileName = fileName;
        }

        public int Id { get; }
        public string FileName { get; }

        public static Result<Image> Create(string fileName)
        {
            if(string.IsNullOrEmpty(fileName) || fileName.Length > MAX_FILENAME_LENGTH)
            {
                return ResultICD.Failure<Image>($"'{nameof(fileName)}' cannot be Null, empty or more than {MAX_FILENAME_LENGTH}");
            }

            var image = new Image(fileName);

            return ResultICD.Success(image);
        }
    }
}
