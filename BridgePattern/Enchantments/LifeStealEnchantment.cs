using System;

namespace BridgePattern.Enchantments
{
    public class LifeStealEnchantment : IEnchantment
    {
        public void CastEnchantment()
        {
            Console.WriteLine("The caster steals life from the enemies.");
        }
    }
}
