# esplora.client
A .NET Standard/C# implementation of Blockstream/Esplora API.

| Name | Resources |
| ------ | ------ |
| APIs | https://github.com/Blockstream/esplora |

#### Getting Started:
```
using System;
using System.Threading.Tasks;
using Esplora.Client.Interfaces;
using RestEase;

namespace Esplora.App
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var client = RestClient.For<IEsploraClient>("https://blockstream.info/api/");

            var confirmedTransactions = await EsploraClient.GetAddressConfirmedTransactions("3D2oetdNuZUqQHPJmcMDDHYoqkyNVsFk9r");

            confirmedTransactions.ForEach(transaction => Console.WriteLine($"{transaction.Txid}. {transaction.Version}"));
            Console.Read();
        }
    }
}
```
