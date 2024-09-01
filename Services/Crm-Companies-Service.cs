
//  Crm Companies Data Start 
public class CrmCompaniesService
{
    private List<CrmCompanies> CrmCompaniesLists = new List<CrmCompanies>()
    {
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/1.png", 
            CompaniesName = "Spruko Technologies", 
            Email="sprukotechnologies2981@gmail.com", 
            Phone = "1678-28993-223",
            Industry = "Information Technology",
            CompaniesSize="Corporate", 
            CompaniesSizeColor="primary-transparent", 
            Contact="Lisa Convay", 
            ContactImg = "../assets/images/faces/4.jpg", 
            DealsId = "258", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/3.png", 
            CompaniesName = "Spice Infotech", 
            Email="spiceinfotech289@gmail.com", 
            Phone = "8122-2342-4453",
            Industry = "Telecommunications",
            CompaniesSize="Small Business", 
            CompaniesSizeColor="danger-transparent", 
            Contact="Jacob Smith", 
            ContactImg = "../assets/images/faces/12.jpg", 
            DealsId = "335", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/4.png", 
            CompaniesName = "Logitech ecostics", 
            Email="logitecheco789@gmail.com", 
            Phone = "1902-2001-3023",
            Industry = "Logistics",
            CompaniesSize="Micro Business", 
            CompaniesSizeColor="success-transparent", 
            Contact="Jake Sully", 
            ContactImg = "../assets/images/faces/14.jpg", 
            DealsId = "685", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/5.png", 
            CompaniesName = "Initech Info", 
            Email="initechinfo290@gmail.com", 
            Phone = "1603-2032-1123",
            Industry = "Information Technology",
            CompaniesSize="Startup", 
            CompaniesSizeColor="light text-default", 
            Contact="Kiara Advain", 
            ContactImg = "../assets/images/faces/6.jpg", 
            DealsId = "425", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/6.png", 
            CompaniesName = "Massive Dynamic", 
            Email="massivedynamic1993@gmail.com", 
            Phone = "1129-2302-1092",
            Industry = "Professional Services",
            CompaniesSize="Large Enterprise", 
            CompaniesSizeColor="pink-transparent", 
            Contact="Brenda Simpson", 
            ContactImg = "../assets/images/faces/8.jpg", 
            DealsId = "516", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/7.png", 
            CompaniesName = "Globex Corporation", 
            Email="globexcorp345@gmail.com", 
            Phone = "9923-2344-2003",
            Industry = "Education",
            CompaniesSize="Small Business", 
            CompaniesSizeColor="danger-transparent", 
            Contact="Json Taylor", 
            ContactImg = "../assets/images/faces/9.jpg", 
            DealsId = "127", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/8.png", 
            CompaniesName = "Acme Corporation", 
            Email="acmecorporation78@gmail.com", 
            Phone = "7891-2093-1994",
            Industry = "Telecommunications",
            CompaniesSize="Corporate", 
            CompaniesSizeColor="primary-transparent", 
            Contact="Dwayne Jhonson", 
            ContactImg = "../assets/images/faces/15.jpg", 
            DealsId = "368", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/9.png", 
            CompaniesName = "Soylent Corp", 
            Email="soylentcorp678@gmail.com", 
            Phone = "1899-2993-0923",
            Industry = "Manufacturing",
            CompaniesSize="Medium Size", 
            CompaniesSizeColor="warning-transparent", 
            Contact="Emiley Jackson", 
            ContactImg = "../assets/images/faces/1.jpg", 
            DealsId = "563", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/10.png", 
            CompaniesName = "Umbrella Corporation", 
            Email="umbrellacorp289@gmail.com", 
            Phone = "1768-2332-4934",
            Industry = "Healthcare",
            CompaniesSize="Micro Business", 
            CompaniesSizeColor="success-transparent", 
            Contact="Jessica Morris", 
            ContactImg = "../assets/images/faces/3.jpg", 
            DealsId = "185", 
        },
        new CrmCompanies { 
            CompaniesImg = "../assets/images/company-logos/2.png", 
            CompaniesName = "Hooli Technologies", 
            Email="hoolitech186@gmail.com", 
            Phone = "4788-7822-4786",
            Industry = "Information Technology",
            CompaniesSize="Startup", 
            CompaniesSizeColor="light text-default", 
            Contact="Michael Jeremy", 
            ContactImg = "../assets/images/faces/9.jpg", 
            DealsId = "240", 
        },
    };

    public List<CrmCompanies> GetCrmCompanies()
    {
        return CrmCompaniesLists;
    }

    public async Task DeleteCrmCompanies(string? DealsId)
    {
        var CrmCompaniesToDelete = CrmCompaniesLists.FirstOrDefault(i => i.DealsId == DealsId);
        if (CrmCompaniesToDelete != null)
        {
            CrmCompaniesLists.Remove(CrmCompaniesToDelete);
            await Task.Delay(1000);
        }
    }
}

//  Crm Companies Data End 