
public class TransactionService
{
    private List<Transaction> Transactions = new List<Transaction>()
    {
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/10.jpg",
            SenderName  ="Json Taylor",
            TransactionHash  ="1242232401",
            CoinImg  ="../assets/images/crypto-currencies/regular/Bitcoin.svg",
            Coin  ="Bitcoin",
            Date  ="24,Jul 2023 - 4:23PM",
            Amount  ="+0.041",
            AmountColor  ="success",
            Receiver  ="Texas Steel",
            Status  ="Success",
            StatusColor  ="success"
        }, 
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-down",
            TransactionLevelColor  ="danger",
            SenderImg  ="../assets/images/faces/5.jpg",
            SenderName  ="Samantha Taylor",
            TransactionHash  ="1242232402",
            CoinImg  ="../assets/images/crypto-currencies/regular/Dash.svg",
            Coin  ="Dashcoin",
            Date  ="20,Jul 2023 - 12:47PM",
            Amount  ="-0.284",
            AmountColor  ="danger",
            Receiver  ="Stuart Little",
            Status  ="Pending",
            StatusColor  ="warning"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/12.jpg",
            SenderName  ="Brian Jhonson",
            TransactionHash  ="1242232403",
            CoinImg  ="../assets/images/crypto-currencies/regular/Euro.svg",
            Coin  ="Euro",
            Date  ="14,Aug 2023 - 10:25AM",
            Amount  ="+0.943",
            AmountColor  ="success",
            Receiver  ="Melissa Smith",
            Status  ="Success",
            StatusColor  ="success"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/15.jpg",
            SenderName  ="Liam Anderson",
            TransactionHash  ="1242232404",
            CoinImg  ="../assets/images/crypto-currencies/regular/Ethereum.svg",
            Coin  ="Ethereum",
            Date  ="10,Jul 2023 - 4:14PM",
            Amount  ="+0.582",
            AmountColor  ="success",
            Receiver  ="Alexander Clark",
            Status  ="Failed",
            StatusColor  ="danger"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/4.jpg",
            SenderName  ="Isabella Brown",
            TransactionHash  ="1242232405",
            CoinImg  ="../assets/images/crypto-currencies/regular/Golem.svg",
            Coin  ="Golem",
            Date  ="19,Aug 2023 - 11:35AM",
            Amount  ="+0.290",
            AmountColor  ="success",
            Receiver  ="Elijah Davis",
            Status  ="Success",
            StatusColor  ="success"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-down",
            TransactionLevelColor  ="danger",
            SenderImg  ="../assets/images/faces/7.jpg",
            SenderName  ="Sophia Lee",
            TransactionHash  ="1242232406",
            CoinImg  ="../assets/images/crypto-currencies/regular/litecoin.svg",
            Coin  ="Litecoin",
            Date  ="12,Jun 2023 - 2:45PM",
            Amount  ="-0.147",
            AmountColor  ="danger",
            Receiver  ="Harper Taylor",
            Status  ="Success",
            StatusColor  ="success"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/6.jpg",
            SenderName  ="Evelyn Clark",
            TransactionHash  ="1242232407",
            CoinImg  ="../assets/images/crypto-currencies/regular/Ripple.svg",
            Coin  ="Ripple",
            Date  ="27,Jul 2023 - 10:18AM",
            Amount  ="+1.05",
            AmountColor  ="success",
            Receiver  ="William Brown",
            Status  ="Success",
            StatusColor  ="success"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/11.jpg",
            SenderName  ="Liam Anderson",
            TransactionHash  ="1242232408",
            CoinImg  ="../assets/images/crypto-currencies/regular/Monero.svg",
            Coin  ="Monero",
            Date  ="16,Aug 2023 - 9:25PM",
            Amount  ="+0.625",
            AmountColor  ="success",
            Receiver  ="Amelia Davis",
            Status  ="Inprogress",
            StatusColor  ="info"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-down",
            TransactionLevelColor  ="danger",
            SenderImg  ="../assets/images/faces/2.jpg",
            SenderName  ="Harper Taylor",
            TransactionHash  ="1242232409",
            CoinImg  ="../assets/images/crypto-currencies/regular/Zcash.svg",
            Coin  ="Zcash",
            Date  ="24,Jul 2023 - 12:47PM",
            Amount  ="-0.293",
            AmountColor  ="danger",
            Receiver  ="Benjamin Martinez",
            Status  ="Inprogress",
            StatusColor  ="info"
        },
        new Transaction { 
            TransactionLevel  ="ti-arrow-narrow-up",
            TransactionLevelColor  ="success",
            SenderImg  ="../assets/images/faces/16.jpg",
            SenderName  ="Lucas Taylor",
            TransactionHash  ="1242232410",
            CoinImg  ="../assets/images/crypto-currencies/regular/Decred.svg",
            Coin  ="Decred",
            Date  ="24,Jul 2023 - 12:47PM",
            Amount  ="+0.893",
            AmountColor  ="success",
            Receiver  ="Mia Wilson",
            Status  ="Success",
            StatusColor  ="success"
        },
    };

    public List<Transaction> GetTransactions()
    {
        return Transactions;
    }

    public async Task DeleteTransaction(string? TransactionHash)
    {
        var transactionToDelete = Transactions.FirstOrDefault(i => i.TransactionHash == TransactionHash);
        if (transactionToDelete != null)
        {
            Transactions.Remove(transactionToDelete);
            await Task.Delay(1000);
        }
    }
}
