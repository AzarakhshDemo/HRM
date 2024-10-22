
namespace meTesting.HRM.Services;

public interface IChartService
{
    Position Create(Position inp);
    Position GetChart(int id);
    void EditChart(Position chart);
    void AssignToPosition(int personnelId, int positionId);
    ReassignmentRequest GetReassignmentRequest(string trd);
    ReassignmentRequest CreateReassignmentRequest(int creatorUserId, int userId, int posId, string trId);
    IEnumerable<ReassignmentRequest> GetAllReassignmentRequest();
}

public class Position
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string[] Tags { get; set; }
    public int? AssigneeId { get; set; }
}

public class ReassignmentRequest
{
    public int Id { get; set; }
    public int CreatorId { get; set; }
    public int UserId { get; set; }
    public int PositionId { get; set; }
    public string TrId { get; set; }
    public ReassignmentRequestStateEnum State { get; set; }

    public enum ReassignmentRequestStateEnum
    {
        Approved = 1,
        Pending,
        Rejected
    }
}