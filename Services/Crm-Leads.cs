
public class CrmLeads
{
    public string? ContactImg { get; set; }
    public string? ContactName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Status { get; set; }
    public string? CompanyImg { get; set; }
    public string? CompanyName { get; set; }
    public string? LeadsSource { get; set; }
    public List<LeadsTagItem>? LeadsTags { get; set; }
    public bool IsDeleting { get; set; }
    public bool Selected { get; set; } 
}
public class LeadsTagItem
{
    public string? status { get; set; }
    public string? statusColor { get; set; }    
}
