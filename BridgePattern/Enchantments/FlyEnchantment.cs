using System;

namespace BridgePattern.Enchantments
{
    public class FlyEnchantment : IEnchantment
    {
        public void CastEnchantment()
        {
            Console.WriteLine("The caster flies.");
        }
    }
}
