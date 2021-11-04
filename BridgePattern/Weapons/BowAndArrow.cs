using BridgePattern.Enchantments;
using System;

namespace BridgePattern.Weapons
{
    public class BowAndArrow : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public BowAndArrow(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public void Attack()
        {
            Console.WriteLine("The holder aims and strikes the arrow to the enemies.");
            _enchantment.CastEnchantment();
        }

        public void Wield()
        {
            Console.WriteLine("The bow and arrow are wielded.");
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}
