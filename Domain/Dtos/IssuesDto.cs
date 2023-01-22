namespace Domain.Dtos;

public class IssuesDto
{
    public int IssueId { get; set; }
    public string Type { get; set; }
    public string Details { get; set; }
    public bool IsResolved { get; set; }

    public IssuesDto()
    {
        
    }

    public IssuesDto(int issueId, string type, string details, bool isResolved)
    {
        IssueId = issueId;
        Type = type;
        Details = details;
        IsResolved = isResolved;
    }
}