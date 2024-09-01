//  Crm Contacts Data Start 
public class CrmContactsService
{
    private List<CrmContacts> CrmContactsLists = new List<CrmContacts>()
    {
        new CrmContacts { 
            ContactImg = "../assets/images/faces/4.jpg", 
            ContactName = "Lisa Convay", 
            ContactDetails = "24, Jul 2023 - 4:45PM", 
            ContactId = "258",       
            Email="lisaconvay2981@gmail.com", 
            Phone = "1678-28993-223",
            Company="Spruko Technologies", 
            CompanyImg = "../assets/images/company-logos/1.png", 
            LeadSource = "Social Media", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "New Lead",statusColor="primary-transparent"},
                new TagItem { status = "Prospect",statusColor="primary-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/12.jpg", 
            ContactName = "Jacob Smith", 
            ContactDetails = "15, Jul 2023 - 11:45AM", 
            ContactId = "335",       
            Email="jacobsmith289@gmail.com", 
            Phone = "8122-2342-4453",
            Company="Spice Infotech", 
            CompanyImg = "../assets/images/company-logos/3.png", 
            LeadSource = "Direct mail", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Customer",statusColor="primary-transparent"},
                new TagItem { status = "Hot Lead",statusColor="danger-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/14.jpg", 
            ContactName = "Jake Sully", 
            ContactDetails = "10, Aug 2023 - 3:25PM", 
            ContactId = "685",       
            Email="jakesully789@gmail.com", 
            Phone = "1902-2001-3023",
            Company="Logitech ecostics", 
            CompanyImg = "../assets/images/company-logos/4.png", 
            LeadSource = "Blog Articles", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Partner",statusColor="success-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/6.jpg", 
            ContactName = "Kiara Advain", 
            ContactDetails = "18, Aug 2023 - 10:10AM", 
            ContactId = "425",       
            Email="kiaraadvain290@gmail.com", 
            Phone = "1603-2032-1123",
            Company="Initech Info", 
            CompanyImg = "../assets/images/company-logos/5.png", 
            LeadSource = "Affiliates", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "LostCustomer",statusColor="light text-default"},
                new TagItem { status = "Influencer ",statusColor="secondary-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/8.jpg", 
            ContactName = "Brenda Simpson", 
            ContactDetails = "19, Jul 2023 - 12:41PM", 
            ContactId = "516",       
            Email="brendasimpson1993@gmail.com", 
            Phone = "1129-2302-1092",
            Company="Massive Dynamic", 
            CompanyImg = "../assets/images/company-logos/6.png", 
            LeadSource = "Organic search", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Subscriber",statusColor="pink-transparent"},
                new TagItem { status = "Partner ",statusColor="success-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/9.jpg", 
            ContactName = "Json Taylor", 
            ContactDetails = "14, Aug 2023 - 5:18PM", 
            ContactId = "127",       
            Email="jsontaylor345@gmail.com", 
            Phone = "9923-2344-2003",
            Company="Globex Corporation", 
            CompanyImg = "../assets/images/company-logos/7.png", 
            LeadSource = "Social media", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Hot Lead",statusColor="danger-transparent"},
                new TagItem { status = "Referral ",statusColor="info-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/15.jpg", 
            ContactName = "Dwayne Jhonson", 
            ContactDetails = "12, Jun 2023 - 11:38AM", 
            ContactId = "368",       
            Email="dwayenejhonson78@gmail.com", 
            Phone = "7891-2093-1994",
            Company="Acme Corporation", 
            CompanyImg = "../assets/images/company-logos/8.png", 
            LeadSource = "Blog Articles", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Trial User",statusColor="warning-transparent"},
                new TagItem { status = "Cold Lead ",statusColor="purple-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/1.jpg", 
            ContactName = "Emiley Jackson", 
            ContactDetails = "19, May 2023 - 1:57PM", 
            ContactId = "563",       
            Email="emileyjackson678@gmail.com", 
            Phone = "1899-2993-0923",
            Company="Soylent Corp", 
            CompanyImg = "../assets/images/company-logos/9.png", 
            LeadSource = "Organic search", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "Influencer",statusColor="success-transparent"},
                new TagItem { status = "Partner ",statusColor="info-transparent"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/3.jpg", 
            ContactName = "Jessica Morris", 
            ContactDetails = "28, Jul 2023 - 9:31AM", 
            ContactId = "185",       
            Email="jessicamorris289@gmail.com", 
            Phone = "1768-2332-4934",
            Company="Umbrella Corporation", 
            CompanyImg = "../assets/images/company-logos/10.png", 
            LeadSource = "Affiliates", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "New Lead",statusColor="primary-transparent"},
                new TagItem { status = "Lost Customer ",statusColor="light text-default"},
            }
        },
        new CrmContacts { 
            ContactImg = "../assets/images/faces/9.jpg", 
            ContactName = "Michael Jeremy", 
            ContactDetails = "28, Jul 2023 - 9:31AM", 
            ContactId = "240",       
            Email="michaeljeremy186@gmail.com", 
            Phone = "4788-7822-4786",
            Company="Hooli Technologies", 
            CompanyImg = "../assets/images/company-logos/2.png", 
            LeadSource = "	Direct mail", 
            Tags = new List<TagItem>
            {
                new TagItem { status = "New Lead",statusColor="primary-transparent"},
                new TagItem { status = "Subscriber ",statusColor="pink-transparent"},
            }
        },
    };

    public List<CrmContacts> GetCrmContacts()
    {
        return CrmContactsLists;
    }


    public async Task DeleteCrmContacts(string? ContactId)
    {
        var CrmContactsToDelete = CrmContactsLists.FirstOrDefault(i => i.ContactId == ContactId);
        if (CrmContactsToDelete != null)
        {
            CrmContactsLists.Remove(CrmContactsToDelete);
            await Task.Delay(1000);
        }
    }
}
//  Crm Contacts Data End 
