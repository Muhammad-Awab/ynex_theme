public class AssignedToItem
{
    public string? Img { get; set; }
}
public class TaskList
{
    public string? TaskName { get; set; }
    public string? TaskListId { get; set; }
    public string? AssignedDate { get; set; }
    public string? Status { get; set; }
    public string? StatusColor { get; set; }
    public string? Priority { get; set; }
    public string? PriorityColor { get; set; }
    public string? DueDate { get; set; }
    public List<AssignedToItem>? AssignedTo { get; set; }
    public bool Selected { get; set; } // This is the Selected property
    public bool IsDeleting { get; set; }
}


