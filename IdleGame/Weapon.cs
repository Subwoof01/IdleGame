using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Weapon : Item
    {
        public enum Type { Axe, Mace, Sword, Staff, Polearm, Bow, Crossbow, Dagger, Wand };
        private enum Affix { Strength, Intelligence, Dexterity, PhysicalDamage, ElementalDamage, FireDamage, LightningDamage, ColdDamage, PoisonDamage, CriticalChance, CriticalDamage };

        // true = Two-Handed, false = One-Handed.
        public bool twoHanded;

        // Weapon damage.
        public int damageMin;
        public int damageMax;
        public double speed;

        // Critical chance/damage.
        public double criticalChanceBonus;
        public double criticalDamageBonus;

        public static Weapon Generate(int itemLevelMin, int itemLevelMax)
        {
            #region Item prefixes.
            string[] prefix = new string[]
            {
                "Frosted",
                "Chilled",
                "Icy",
                "Frigid",
                "Freezing",
                "Frozen",
                "Glaciated",
                "Polar",
                "Entombing",
                "Heated",
                "Smouldering",
                "Smoking",
                "Burning",
                "Flaming",
                "Scorching",
                "Incinerating",
                "Blasting",
                "Cremating",
                "Catalysing",
                "Infusing",
                "Empowering",
                "Unleashed",
                "Overpowering",
                "Paragon's",
                "Weaponmaster's",
                "Combatant's",
                "Remora's",
                "Lamprey's",
                "Vampire's",
                "Humming",
                "Buzzing",
                "Snapping",
                "Crackling",
                "Sparking",
                "Arcing",
                "Shocking",
                "Discharging",
                "Electrocuting",
                "Malicious",
                "Squire's",
                "Journeyman's",
                "Reaver's",
                "Mercenary's",
                "Champion's",
                "Conqueror's",
                "Emperor's",
                "Dictator's",
                "Heavy",
                "Serrated",
                "Wicked",
                "Vicious",
                "Bloodthirsty",
                "Cruel",
                "Tyrannical",
                "Merciless",
                "Thirsty",
                "Glinting",
                "Burnished",
                "Polished",
                "Honed",
                "Gleaming",
                "Annealed",
                "Razer-sharp",
                "Tempered",
                "Flaring"
            };
            #endregion
            #region Item suffixes.
            string[] suffix = new string[]
            {
                "of Agony",
                "of Torment",
                "of Bloodletting",
                "of Haemophilia",
                "of Exsanguination",
                "of the Lost",
                "of Banishment",
                "of Eviction",
                "of Expulsion",
                "of Exile",
                "of Barneth",
                "of the Inuit",
                "of the Seal",
                "of the Yeti",
                "of the Penguin",
                "of the Walrus",
                "of the Polar Bear",
                "of the Ice",
                "of Haast",
                "of Needing",
                "of Stinging",
                "of Piercing",
                "of Puncturing",
                "of Penetrating",
                "of Incision",
                "of Ire",
                "of Anger",
                "of Rage",
                "of Fury",
                "of Ferocity",
                "of Destruction",
                "of the Mongoose",
                "of the Lynx",
                "of the Fox",
                "of the Falcon",
                "of the Panther",
                "of the Leopard",
                "of the Jaguar",
                "of the Phantom",
                "of the Wind",
                "of the Whelpling",
                "of the Salamander",
                "of the Drake",
                "of the Kiln",
                "of the Furnace",
                "of the Volcano",
                "of the Magma",
                "of the Ranger",
                "of Calm",
                "of Steadiness",
                "of Accuracy",
                "of Precision",
                "of the Sniper",
                "of the Marksman",
                "of the Deadeye",
                "of Skill",
                "of Ease",
                "of Mastery",
                "of Renown",
                "of Acclaim",
                "of Fame",
                "of Infamy",
                "of Celebration",
                "of Success",
                "of Victory",
                "of Triumph",
                "of Rejuvenation",
                "of Restoration",
                "of Regrowth",
                "of Nourishment",
                "of the Cloud",
                "of the Squall",
                "of the Storm",
                "of the Thunderhead",
                "of the Tempest",
                "of the Maelstrom",
                "of the Lighting",
                "of Shining",
                "of Light",
                "of Radiance",
                "of the Worthy",
                "of the Apt",
                "of Bleeding",
                "of Flaying",
                "of Hemorrhage",
                "of Absorption",
                "of Osmosis",
                "of Consumption",
                "of the Brute",
                "of the Wrestler",
                "of the Bear",
                "of the Lion",
                "of the Gorilla",
                "of the Goliath",
                "of the Leviathan",
                "of the Titan",
                "of the Gods",
                "of Impact",
                "of Dazing",
                "of Stunning",
                "of Slamming",
                "of Staggering",
                "of the Pugilist",
                "of the Brawler",
                "of the Boxer",
                "of the Combatant",
                "of the Gladiator"
            };
            #endregion

            #region Stats that need to be defined.
            string itemName;
            int strength = 0;
            int intelligence = 0;
            int dexterity = 0;
            int damageMin = 0;
            int damageMax = 0;
            double criticalChance = 0;
            double criticalDamage = 0;
            double speed = 0;
            double physicalDamage = 0;
            double elementalDamage = 0;
            double fireDamage = 0;
            double lightningDamage = 0;
            double coldDamage = 0;
            double poisonDamage = 0;
            Equip slot = 0;
            bool twoHanded;
            Type type = 0;
            int strengthReq = 1;
            int intelligenceReq = 1;
            int dexterityReq = 1;
            int price = 0;
            #endregion

            int itemLevel = random.Next(itemLevelMin, itemLevelMax + 1);

            int prefixChoice = random.Next(prefix.Length);
            int suffixChoice = random.Next(suffix.Length);

            slot = Equip.MainHand;

            itemName = "";

            type = (Type)random.Next(9);

            #region Two-handed decider.
            // Bow, staff and polearm are always two-handed.
            if (type.Equals(Type.Bow) || type.Equals(Type.Staff) || type.Equals(Type.Polearm))
                twoHanded = true;
            else if (type.Equals(Type.Dagger) || type.Equals(Type.Wand))
                twoHanded = false;
            else
            {
                // 50% chance for two-handed.
                int isOneHanded = random.Next(2);

                if (isOneHanded < 1)
                    twoHanded = false;
                else
                    twoHanded = true;
            }
            #endregion

            #region Name generation.
            // Weapon names.
            if (type.Equals(Type.Axe))
                itemName = prefix[prefixChoice] + " Axe " + suffix[suffixChoice];
            else if (type.Equals(Type.Mace))
                itemName = prefix[prefixChoice] + " Mace " + suffix[suffixChoice];
            else if (type.Equals(Type.Sword))
                itemName = prefix[prefixChoice] + " Sword " + suffix[suffixChoice];
            else if (type.Equals(Type.Staff))
                itemName = prefix[prefixChoice] + " Staff " + suffix[suffixChoice];
            else if (type.Equals(Type.Polearm))
                itemName = prefix[prefixChoice] + " Polearm " + suffix[suffixChoice];
            else if (type.Equals(Type.Bow))
                itemName = prefix[prefixChoice] + " Bow " + suffix[suffixChoice];
            else if (type.Equals(Type.Crossbow))
                itemName = prefix[prefixChoice] + " Crossbow " + suffix[suffixChoice];
            else if (type.Equals(Type.Dagger))
                itemName = prefix[prefixChoice] + " Dagger " + suffix[suffixChoice];
            else if (type.Equals(Type.Wand))
                itemName = prefix[prefixChoice] + " Wand " + suffix[suffixChoice];
            #endregion

            #region Affix minimum and maximum, affix cap and affix chooser.
            int affixMinimum = 0;
            int affixMaximum = 0;
            // Make formula
            if (itemLevel > 10)
                affixMinimum = 1;
            if (itemLevel > 25)
                affixMinimum = 2;
            if (itemLevel > 45)
                affixMinimum = 3;

            if (itemLevel > 5)
                affixMaximum = 1;
            if (itemLevel > 15)
                affixMaximum = 2;
            if (itemLevel > 30)
                affixMaximum = 3;
            if (itemLevel > 50)
                affixMaximum = 4;
            if (itemLevel > 70)
                affixMaximum = 5;


            int affixAmount = random.Next(affixMinimum, affixMaximum + 1);

            if (itemLevel > 80)
                affixAmount = 5;

            List<Affix> affixes = new List<Affix>();

            for (int i = 0; i < affixAmount; i++)
            {
                int affixChooser = random.Next(11);
                affixes.Add((Affix)affixChooser);
            }
            #endregion

            #region Generate damage values according to item level, two/one-handed and weapon type.
            if ((type.Equals(Type.Mace) && twoHanded) || (type.Equals(Type.Crossbow) && twoHanded))
            {
                damageMin = random.Next((1 * itemLevel) + 10, (int)(1.4 * itemLevel) + 13);
                damageMax = random.Next((int)(1.5 * itemLevel) + 15, (2 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Axe) && twoHanded)
            {
                damageMin = random.Next((int)(0.9 * itemLevel) + 10, (int)(1.3 * itemLevel) + 13);
                damageMax = random.Next((int)(1.4 * itemLevel) + 15, (int)(1.9 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Sword) && twoHanded)
            {
                damageMin = random.Next((int)(0.8 * itemLevel) + 10, (int)(1.2 * itemLevel) + 13);
                damageMax = random.Next((int)(1.3 * itemLevel) + 15, (int)(1.8 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Polearm) || type.Equals(Type.Bow))
            {
                damageMin = random.Next((int)(0.7 * itemLevel) + 10, (int)(1.1 * itemLevel) + 13);
                damageMax = random.Next((int)(1.2 * itemLevel) + 15, (int)(1.7 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Staff))
            {
                damageMin = random.Next((int)(0.6 * itemLevel) + 10, (int)(1 * itemLevel) + 13);
                damageMax = random.Next((int)(1.1 * itemLevel) + 15, (int)(1.6 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Mace) && !twoHanded)
            {
                damageMin = random.Next((int)(0.5 * itemLevel) + 10, (int)(0.9 * itemLevel) + 13);
                damageMax = random.Next((int)(1 * itemLevel) + 15, (int)(1.5 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Axe) && !twoHanded)
            {
                damageMin = random.Next((int)(0.4 * itemLevel) + 10, (int)(0.8 * itemLevel) + 13);
                damageMax = random.Next((int)(0.9 * itemLevel) + 15, (int)(1.4 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Sword) && !twoHanded)
            {
                damageMin = random.Next((int)(0.3 * itemLevel) + 10, (int)(0.7 * itemLevel) + 13);
                damageMax = random.Next((int)(0.8 * itemLevel) + 15, (int)(1.3 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Crossbow) && !twoHanded)
            {
                damageMin = random.Next((int)(0.2 * itemLevel) + 10, (int)(0.6 * itemLevel) + 13);
                damageMax = random.Next((int)(0.7 * itemLevel) + 15, (int)(1.2 * itemLevel) + 18);
            }
            else if (type.Equals(Type.Dagger) || type.Equals(Type.Wand))
            {
                damageMin = random.Next((int)(0.1 * itemLevel) + 10, (int)(0.5 * itemLevel) + 13);
                damageMax = random.Next((int)(0.6 * itemLevel) + 15, (int)(1.1 * itemLevel) + 18);
            }
            #endregion

            #region Set weapon speed according to two/one-handed and weapon type.
            if ((type.Equals(Type.Mace) && twoHanded) || (type.Equals(Type.Crossbow) && twoHanded))
                speed = random.NextDouble() * (2.3 - 1.8) + 1.8;
            else if (type.Equals(Type.Axe) && twoHanded)
                speed = random.NextDouble() * (2.2 - 1.7) + 1.7;
            else if (type.Equals(Type.Sword) && twoHanded)
                speed = random.NextDouble() * (2.1 - 1.6) + 1.6;
            else if (type.Equals(Type.Polearm))
                speed = random.NextDouble() * (2 - 1.5) + 1.5;
            else if (type.Equals(Type.Staff))
                speed = random.NextDouble() * (1.9 - 1.4) + 1.4;
            else if (type.Equals(Type.Mace) && !twoHanded)
                speed = random.NextDouble() * (1.8 - 1.3) + 1.3;
            else if (type.Equals(Type.Axe) && !twoHanded)
                speed = random.NextDouble() * (1.7 - 1.2) + 1.2;
            else if (type.Equals(Type.Bow))
                speed = random.NextDouble() * (1.6 - 1.1) + 1.1;
            else if (type.Equals(Type.Sword) && !twoHanded)
                speed = random.NextDouble() * (1.5 - 1) + 1;
            else if (type.Equals(Type.Crossbow) && !twoHanded)
                speed = random.NextDouble() * (1.4 - 0.9) + 0.9;
            else if (type.Equals(Type.Dagger) || type.Equals(Type.Wand))
                speed = random.NextDouble() * (1.3 - 0.8) + 0.8;
            #endregion

            #region Generate values for chosen affixes.
            foreach (Affix affix in affixes)
            {
                // Strength
                if (affix.Equals(Affix.Strength))
                    strength = random.Next((int)(5 * Math.Pow(1.038, itemLevel)));
                // Intelligence
                if (affix.Equals(Affix.Intelligence))
                    intelligence = random.Next((int)(5 * Math.Pow(1.038, itemLevel)));
                // Dexterity
                if (affix.Equals(Affix.Dexterity))
                    dexterity = random.Next((int)(5 * Math.Pow(1.038, itemLevel)));
                // Physical Damage 
                if (affix.Equals(Affix.PhysicalDamage))
                    physicalDamage = random.Next(21) * 0.01;
                // Elemental Damage
                if (affix.Equals(Affix.ElementalDamage))
                    elementalDamage = random.Next(21) * 0.01;
                // Fire Damage
                if (affix.Equals(Affix.FireDamage))
                    fireDamage = random.Next(21) * 0.01;
                // Lightning Damage
                if (affix.Equals(Affix.LightningDamage))
                    lightningDamage = random.Next(21) * 0.01;
                // Cold Damage
                if (affix.Equals(Affix.ColdDamage))
                    coldDamage = random.Next(21) * 0.01;
                // Poison Damage
                if (affix.Equals(Affix.PoisonDamage))
                    poisonDamage = random.Next(21) * 0.01;
                // Critical Chance
                if (affix.Equals(Affix.CriticalChance))
                    criticalChance = random.Next(21) * 0.01;
                // Critical Damage
                if (affix.Equals(Affix.CriticalDamage))
                    criticalDamage = random.Next(151) * 0.01;
            }
            #endregion

            // Strength requirement
            if (strength > 0 || type.Equals(Type.Axe) || (type.Equals(Type.Sword)) || type.Equals(Type.Mace) || type.Equals(Type.Polearm) || type.Equals(Type.Mace) || physicalDamage > 0)
                strengthReq = random.Next((int)(5 * Math.Pow(1.029, itemLevel)), (int)(5 * Math.Pow(1.036, itemLevel)));
            // Intelligence requirement
            if (intelligence > 0 || type.Equals(Type.Staff) || type.Equals(Type.Wand) || elementalDamage > 0)
                intelligenceReq = random.Next((int)(5 * Math.Pow(1.029, itemLevel)), (int)(5 * Math.Pow(1.036, itemLevel)));
            // Dexterity requirement
            if (dexterity > 0 || type.Equals(Type.Dagger) || (type.Equals(Type.Sword) && !twoHanded) || type.Equals(Type.Bow) || type.Equals(Type.Crossbow) || physicalDamage > 0)
                dexterityReq = random.Next((int)(5 * Math.Pow(1.029, itemLevel)), (int)(5 * Math.Pow(1.036, itemLevel)));

            // Buy and sell price
            price = (int)(20 * Math.Pow(1.024, itemLevel));

            return new Weapon(itemName, slot, type, twoHanded, itemLevel, strengthReq, intelligenceReq, dexterityReq, strength, intelligence, dexterity, physicalDamage, elementalDamage, fireDamage, lightningDamage, coldDamage, poisonDamage, damageMin, damageMax, speed, criticalChance, criticalDamage, price);
        }

        public Weapon(string _name, Equip slot, Enum weaponType, bool _twoHanded, int levelReq, int strReq, int intReq, int dexReq, int strBonus, int intBonus, int dexBonus, double physDmgBonus, double eleDmgBonus, double fireBonus, double lightningBonus, double coldBonus, double poisonBonus, int dmgMin, int dmgMax, double _speed, double critChc, double critDmg, int gold)
        {
            equipSlot = slot;
            type = weaponType;
            twoHanded = _twoHanded;
            name = _name;
            price = gold;

            levelRequirement = levelReq;
            strengthRequirement = strReq;
            intelligenceRequirement = intReq;
            dexterityRequirement = dexReq;

            strengthBonus = strBonus;
            intelligenceBonus = intBonus;
            dexterityBonus = dexBonus;
            physicalDamageBonus = physDmgBonus;
            elementalDamageBonus = eleDmgBonus;
            fireDamageBonus = fireBonus;
            lightningDamageBonus = lightningBonus;
            coldDamageBonus = coldBonus;
            poisonDamageBonus = poisonBonus;
            damageMin = dmgMin;
            damageMax = dmgMax;
            speed = _speed;
            criticalChanceBonus = critChc;
            criticalDamageBonus = critDmg;
            
            tooltip = $"{name}\r\n---------------\r\n" +
                ((twoHanded) ? "Two-Handed " : "One-Handed ") + $"{Enum.GetName(typeof(Weapon.Type), type)}\r\n" +
                $"{speed.ToString("#.#")} speed\r\n" +
                $"{damageMin} - {damageMax} damage\r\n---------------\r\n" +
                $"Lvl: {levelRequirement}, Str: {strengthRequirement}, Int: {intelligenceRequirement}, Dex: {dexterityRequirement}\r\n---------------\r\n" +
                ((strengthBonus != 0) ? $"+{strengthBonus} to strength\r\n" : "") +
                ((intelligenceBonus != 0) ? $"+{intelligenceBonus} to intelligence\r\n" : "") +
                ((dexterityBonus != 0) ? $"+{dexterityBonus} to dexterity\r\n" : "") +
                ((physicalDamageBonus != 0) ? $"+{physicalDamageBonus * 100}% to physical damage\r\n" : "") +
                ((elementalDamageBonus != 0) ? $"+{elementalDamageBonus * 100}% to elemental damage\r\n" : "") +
                ((fireDamageBonus != 0) ? $"+{fireDamageBonus * 100}% to fire damage\r\n" : "") +
                ((lightningDamageBonus != 0) ? $"+{lightningDamageBonus * 100}% to lightning damage\r\n" : "") +
                ((coldDamageBonus != 0) ? $"+{coldDamageBonus * 100}% to cold damage\r\n" : "") +
                ((poisonDamageBonus != 0) ? $"+{poisonDamageBonus * 100}% to poison damage\r\n" : "") +
                ((criticalChanceBonus != 0) ? $"+{criticalChanceBonus * 100}% to critical strike chance\r\n" : "") +
                ((criticalDamageBonus != 0) ? $"+{criticalDamageBonus * 100}% to critical strike damage" : "");
        }
    }
}
