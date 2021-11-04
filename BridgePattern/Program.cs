using BridgePattern.Enchantments;
using BridgePattern.Weapons;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var sword = new Sword(new LifeStealEnchantment());
            sword.Wield();
            sword.Attack();

            var bowAndArrow = new BowAndArrow(new FlyEnchantment());
            bowAndArrow.Wield();
            bowAndArrow.Attack();
        }
    }
}
