
public class CrmContacts
{
    public string? ContactImg { get; set; }
    public string? ContactName { get; set; }
    public string? ContactDetails { get; set; }
    public string? ContactId { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public string? Company { get; set; }
    public string? CompanyImg { get; set; }
    public string? LeadSource { get; set; }    
    public List<TagItem>? Tags { get; set; }
    public bool IsDeleting { get; set; }
    public bool Selected { get; set; } // This is the Selected property
}
public class TagItem
{
    public string? status { get; set; }
    public string? statusColor { get; set; }    
}


