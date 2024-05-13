using CSharpFunctionalExtensions;
using System.Diagnostics.Metrics;

namespace Clinic.Core.Models;

public class ResultICD
{
    public const int MAX_ICD_LENGTH = 60;
    public const int MAX_DESCRIPTION_RESULT_LENGTH = 250;

    private ResultICD(int id, string iCDCode, string? description, int receptionId)
    {
        Id = id;
        ICDCode = iCDCode;
        Description = description;
        ReceptionId = receptionId;
    }

    public int Id { get; set; }
    public string ICDCode { get; set; } = string.Empty;
    public string? Description { get; set; }
    public int ReceptionId { get; set; }

    public static Result<ResultICD> Create(int id, string iCDCode, string? description, int receptionId)
    {
        if (string.IsNullOrEmpty(iCDCode) || iCDCode.Length > MAX_ICD_LENGTH)
        {
            return Result.Failure<ResultICD>($"'{nameof(iCDCode)}' cannot be Null, empty or more than {MAX_ICD_LENGTH}");
        }
        if (description.Length > MAX_DESCRIPTION_RESULT_LENGTH)
        {
            return Result.Failure<ResultICD>($"'{nameof(description)}' cannot be more than {MAX_DESCRIPTION_RESULT_LENGTH}");
        }

        var resultICD = new ResultICD(id, iCDCode, description, receptionId);

        return Result.Success(resultICD);
    }
}
