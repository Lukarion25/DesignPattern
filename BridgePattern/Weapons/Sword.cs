using BridgePattern.Enchantments;
using System;

namespace BridgePattern.Weapons
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public Sword(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public void Attack()
        {
            Console.WriteLine("The holder cuts through the enemies.");
            _enchantment.CastEnchantment();
        }

        public void Wield()
        {
            Console.WriteLine("The sword is wielded.");
        }

        public IEnchantment GetEnchantment()
        {
            return _enchantment;
        }
    }
}
