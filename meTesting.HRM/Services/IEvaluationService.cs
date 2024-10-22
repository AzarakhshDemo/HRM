using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meTesting.HRM.Services;

public interface IEvaluationService
{
    Task<EvaluationResult> GetUserEvaluation(int userId);
    Task<EvaluationResult> SetEvaluationResult(int userId, int score);
}

public class EvaluationResult
{
    public int UserId { get; set; }
    public int Score { get; set; }
}