using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningWPF
{
    class Weapons
    {
        public static List <Weapon> GetWeapons()
        {
            return new List<Weapon>()
            {
                new Weapon(){WeaponName="Nurgle's Putrid Bone-Club", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Slaanesh's Lustful barbed-whip", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Tzeentch's Staff of all knowing", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Knorne's Great Axe - Eviscerator of countless souls", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Sword of God", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Golden Spoon", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Lord of Lords Bloody Bible", Type=Rarity.Souverain},
                new Weapon(){WeaponName="Leonidas's spear of undisputed resolve", Type=Rarity.Celestial},
                new Weapon(){WeaponName="Crowleys Grimoire of illumination", Type=Rarity.Celestial},
                new Weapon(){WeaponName="Sword of Demi-Gods", Type=Rarity.Celestial},
                new Weapon(){WeaponName="Watt's spellbook of infinite insight", Type=Rarity.Celestial},
                new Weapon(){WeaponName="Clintons Silenced 9mm", Type=Rarity.Legendary},
                new Weapon(){WeaponName="Sword of Kings", Type=Rarity.Legendary},
                new Weapon(){WeaponName="Keysword of pure hearts", Type=Rarity.Legendary},
                new Weapon(){WeaponName="Spacey's Grimoire of Sacrifice", Type=Rarity.Rare},
                new Weapon(){WeaponName="Sword of Lords", Type=Rarity.Rare},
                new Weapon(){WeaponName="Double-bladed Axe", Type=Rarity.Uncommon},
                new Weapon(){WeaponName="Sword of Knights", Type=Rarity.Uncommon},
                new Weapon(){WeaponName="Silver Mace", Type=Rarity.Uncommon},
                new Weapon(){WeaponName="Wooden Spoon", Type=Rarity.Common},
                new Weapon(){WeaponName="Sword of Common-folk", Type=Rarity.Common},
                new Weapon(){WeaponName="Rusty Sword", Type=Rarity.Common},
                new Weapon(){WeaponName="Wooden 2-handed Sword", Type=Rarity.Common},
                new Weapon(){WeaponName="Long Bow", Type=Rarity.Common},
            }.ToList();
        }
    }
}
