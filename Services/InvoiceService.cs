
public class InvoiceService
{
    private List<Invoice> Invoices = new List<Invoice>()
    {
        new Invoice { ClientName = "Json Taylor",ClientEmail="jsontaylor2416@gmail.com", ClientImg = "../assets/images/faces/11.jpg", InvoiceId = "#SPK12032901", IssuedDate = "25,Nov 2022", Amount = "$212.45", Status = "Paid",StatusColor="success", DueDate = "25,Dec 2022" },
        new Invoice { ClientName = "Suzika Stallone",ClientEmail="suzikastallone3214@gmail.com", ClientImg = "../assets/images/faces/7.jpg", InvoiceId = "#SPK12032912", IssuedDate = "	13,Nov 2022", Amount = "$512.99", Status = "Pending",StatusColor="warning", DueDate = "13,Dec 2022" },
        new Invoice { ClientName = "Roman Killon",ClientEmail="romankillon143@gmail.com", ClientImg = "../assets/images/faces/15.jpg", InvoiceId = "#SPK12032945", IssuedDate = "30,Nov 2022", Amount = "$2199.49", Status = "Overdue",StatusColor="danger", DueDate = "30,Dec 2022" },
        new Invoice { ClientName = "Charlie Davieson",ClientEmail="charliedavieson@gmail.com", ClientImg = "../assets/images/faces/12.jpg", InvoiceId = "#SPK12032922", IssuedDate = "18,Nov 2022", Amount = "$1569.99", Status = "Paid",StatusColor="success", DueDate = "18,Dec 2022" },
        new Invoice { ClientName = "Selena Deoyl",ClientEmail="selenadeoyl114@gmail.com", ClientImg = "../assets/images/faces/4.jpg", InvoiceId = "#SPK12032932", IssuedDate = "18,Nov 2022", Amount = "$4,873.99", Status = "Due By 1 Day",StatusColor="primary", DueDate = "18,Dec 2022" },
        new Invoice { ClientName = "Kiara Advensh",ClientEmail="kiaraadvensh87@gmail.com", ClientImg = "../assets/images/faces/7.jpg", InvoiceId = "#SPK12032978", IssuedDate = "02,Nov 2022", Amount = "$1923.99", Status = "Paid",StatusColor="success", DueDate = "18,Dec 2022" },
        new Invoice { ClientName = "Joseph Samurai",ClientEmail="josephsamurai@gmail.com", ClientImg = "../assets/images/faces/9.jpg", InvoiceId = "#SPK12032919", IssuedDate = "15,Nov 2022", Amount = "$1,623.99", Status = "Paid",StatusColor="success", DueDate = "15,Dec 2022" },
        new Invoice { ClientName = "Kevin Powell",ClientEmail="kevinpowell@gmail.com", ClientImg = "../assets/images/faces/13.jpg", InvoiceId = "#SPK12032931", IssuedDate = "21,Nov 2022", Amount = "$3,423.99", Status = "Pending",StatusColor="warning", DueDate = "21,Dec 2022" },
        new Invoice { ClientName = "Darla Jung",ClientEmail="darlajung555@gmail.com", ClientImg = "../assets/images/faces/8.jpg", InvoiceId = "#SPK12032958", IssuedDate = "15,Oct 2022", Amount = "$2,982.99", Status = "Paid",StatusColor="success", DueDate = "15,Dec 2022" },
        
    };

    public List<Invoice> GetInvoices()
    {
        return Invoices;
    }

    public async Task DeleteInvoice(string? invoiceId)
    {
        var invoiceToDelete = Invoices.FirstOrDefault(i => i.InvoiceId == invoiceId);
        if (invoiceToDelete != null)
        {
            Invoices.Remove(invoiceToDelete);
            await Task.Delay(1000);
        }
    }
}
