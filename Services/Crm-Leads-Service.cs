
//  Crm Leads Data Start 
public class CrmLeadsService
{
    private List<CrmLeads> CrmLeadsLists = new List<CrmLeads>()
    {
        new CrmLeads { 
            ContactImg = "../assets/images/faces/4.jpg", 
            ContactName = "Lisa Convay", 
            Email="lisaconvay2981@gmail.com", 
            Phone = "1678-28993-223",
            Status = "New",
            CompanyName="Spruko Technologies", 
            CompanyImg = "../assets/images/company-logos/1.png", 
            LeadsSource = "Social Media", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "New Lead",statusColor="primary-transparent"},
                new LeadsTagItem { status = "Prospect",statusColor="primary-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/12.jpg", 
            ContactName = "Jacob Smith", 
            Email="jacobsmith289@gmail.com", 
            Phone = "8122-2342-4453",
            Status = "Follow-up",
            CompanyName="Spice Infotech", 
            CompanyImg = "../assets/images/company-logos/3.png", 
            LeadsSource = "Direct mail", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "Customer",statusColor="primary-transparent"},
                new LeadsTagItem { status = "Hot Lead",statusColor="danger-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/14.jpg", 
            ContactName = "Jake Sully", 
            Email="jakesully789@gmail.com", 
            Phone = "1902-2001-3023",
            Status = "Closed",
            CompanyName="Logitech ecostics", 
            CompanyImg = "../assets/images/company-logos/4.png", 
            LeadsSource = "Blog Articles", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "Partner",statusColor="success-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/6.jpg", 
            ContactName = "Kiara Advain", 
            Email="kiaraadvain290@gmail.com", 
            Phone = "1603-2032-1123",
            Status = "Contacted",
            CompanyName="Initech Info", 
            CompanyImg = "../assets/images/company-logos/5.png", 
            LeadsSource = "Affiliates", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "LostCustomer",statusColor="light text-default"},
                new LeadsTagItem { status = "Influencer ",statusColor="secondary-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/8.jpg", 
            ContactName = "Brenda Simpson", 
            Email="brendasimpson1993@gmail.com", 
            Phone = "1129-2302-1092",
            Status = "New",
            CompanyName="Massive Dynamic", 
            CompanyImg = "../assets/images/company-logos/6.png", 
            LeadsSource = "Organic search", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "Subscriber",statusColor="pink-transparent"},
                new LeadsTagItem { status = "Partner ",statusColor="success-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/9.jpg", 
            ContactName = "Json Taylor", 
            Email="jsontaylor345@gmail.com", 
            Phone = "9923-2344-2003",
            Status = "Follow-up",
            CompanyName="Globex Corporation", 
            CompanyImg = "../assets/images/company-logos/7.png", 
            LeadsSource = "Social media", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "Hot Lead",statusColor="danger-transparent"},
                new LeadsTagItem { status = "Referral ",statusColor="info-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/15.jpg", 
            ContactName = "Dwayne Jhonson", 
            Email="dwayenejhonson78@gmail.com", 
            Phone = "7891-2093-1994",
            Status = "Closed",
            CompanyName="Acme Corporation", 
            CompanyImg = "../assets/images/company-logos/8.png", 
            LeadsSource = "Blog Articles", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "Trial User",statusColor="warning-transparent"},
                new LeadsTagItem { status = "Cold Lead ",statusColor="purple-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/1.jpg", 
            ContactName = "Emiley Jackson", 
            Email="emileyjackson678@gmail.com", 
            Phone = "1899-2993-0923",
            Status = "Disqualified",
            CompanyName="Soylent Corp", 
            CompanyImg = "../assets/images/company-logos/9.png", 
            LeadsSource = "Organic search", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "Influencer",statusColor="success-transparent"},
                new LeadsTagItem { status = "Partner ",statusColor="info-transparent"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/3.jpg", 
            ContactName = "Jessica Morris", 
            Email="jessicamorris289@gmail.com", 
            Phone = "1768-2332-4934",
            Status = "Qualified",
            CompanyName="Umbrella Corporation", 
            CompanyImg = "../assets/images/company-logos/10.png", 
            LeadsSource = "Affiliates", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "New Lead",statusColor="primary-transparent"},
                new LeadsTagItem { status = "Lost Customer ",statusColor="light text-default"},
            }
        },
        new CrmLeads { 
            ContactImg = "../assets/images/faces/9.jpg", 
            ContactName = "Michael Jeremy", 
            Email="michaeljeremy186@gmail.com", 
            Phone = "4788-7822-4786",
            Status = "Contacted",
            CompanyName="Hooli Technologies", 
            CompanyImg = "../assets/images/company-logos/2.png", 
            LeadsSource = "	Direct mail", 
            LeadsTags = new List<LeadsTagItem>
            {
                new LeadsTagItem { status = "New Lead",statusColor="primary-transparent"},
                new LeadsTagItem { status = "Subscriber ",statusColor="pink-transparent"},
            }
        },
    };

    public List<CrmLeads> GetCrmLeads()
    {
        return CrmLeadsLists;
    }

    public async Task DeleteCrmLeads(string? ContactName)
    {
        var CrmLeadsToDelete = CrmLeadsLists.FirstOrDefault(i => i.ContactName == ContactName);
        if (CrmLeadsToDelete != null)
        {
            CrmLeadsLists.Remove(CrmLeadsToDelete);
            await Task.Delay(1000);
        }
    }
}

//  Crm Leads Data End 