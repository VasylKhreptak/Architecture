using Plugins.Banks.Data.Economy.Core;

namespace Plugins.Banks.Data.Economy
{
    public class Banks
    {
        public readonly BanksContainer<int> IntegerBanks;

        public Banks()
        {
            IntegerBanks = new BanksContainer<int>();

            IntegerBanks.Add(new IntegerBank(BankType.Coins, 0));
        }
    }
}
