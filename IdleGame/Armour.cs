using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleGame
{
    public class Armour : Item
    {
        public enum Type { Heavy, Medium, Light };
        private enum Affix { Strength, Intelligence, Dexterity, Health, Mana, Armour, HealthRegen, ManaRegen, PhysicalResist, ElementalResist, FireResist, LightningResist, ColdResist, PoisonResist, PhysicalDamage, ElementalDamage, FireDamage, LightningDamage, ColdDamage, PoisonDamage };


        // Flat bonuses.
        public int healthBonus;
        public int manaBonus;
        public int armourBonus;

        public double healthRegenerationBonus;
        public double manaRegenerationBonus;

        // Percentual bonuses.
        public double physicalResistanceBonus;
        public double elementalResistance;
        public double fireResistance;
        public double lightningResistance;
        public double coldResistance;
        public double poisonResistance;

        public static Armour Generate(int itemLevelMin, int itemLevelMax)
        {
            #region Item prefixes.
            string[] prefix = new string[]
            {
            "Thorny",
            "Spiny",
            "Barbed",
            "Jagged",
            "Shining",
            "Incandescent",
            "Glimmering",
            "Glittering",
            "Glowing",
            "Radiating",
            "Pulsing",
            "Seething",
            "Blazing",
            "Scintillating",
            "Monk's",
            "Prior's",
            "Abbot's",
            "Exarch's",
            "Protective",
            "Strong-Willed",
            "Resolute",
            "Fearless",
            "Dauntless",
            "Indomitable",
            "Unassailable",
            "Unfaltering",
            "Pixie's",
            "Gremlin's",
            "Boggart's",
            "Naga's",
            "Djinn's",
            "Seraphim's",
            "Hale",
            "Healthy",
            "Vigorous",
            "Rapturous",
            "Prime",
            "Sanguine",
            "Stalwart",
            "Stout",
            "Robust",
            "Rotund",
            "Virile",
            "Athlete's",
            "Fecund",
            "Beryl",
            "Mazarine",
            "Blue",
            "Zaffre",
            "Cobalt",
            "Azure",
            "Sapphire",
            "Cerulean",
            "Aqua",
            "Opalescent",
            "Gentian",
            "Chalybeous",
            "Agile",
            "Dancer's",
            "Acrobat's",
            "Fleet",
            "Blurred",
            "Phased",
            "Flea's",
            "Fawn's",
            "Ram's",
            "Shade's",
            "Ghost's",
            "Spectre's",
            "Wraith's",
            "Phantasm's",
            "Nightmare's",
            "Mirage's",
            "Illusion's",
            "Musquito's",
            "Moth's",
            "Butterfly's",
            "Wasp's",
            "Dragonfly's",
            "Hummingbird's",
            "Lacqured",
            "Studded",
            "Ribbed",
            "Fortified",
            "Plated",
            "Carapaced",
            "Oyster's",
            "Urchin's",
            "Nautilus'",
            "Crocile's",
            "Reinforced",
            "Layered",
            "Lobstered",
            "Buttressed",
            "Thickened",
            "Girded",
            "Impregnable",
            "Impenetrable",
            "Beetle's",
            "Crab's",
            "Armadillo's",
            "Rhino's",
            "Elephant's",
            "Mammoth's"
            };
            #endregion
            #region Item suffixes.
            string[] suffix = new string[]
            {
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
            "of Vibrance",
            "of Exuberance",
            "of the Whelpling",
            "of the Salamander",
            "of the Drake",
            "of the Kiln",
            "of the Furnace",
            "of the Volcano",
            "of the Magma",
            "of the Pupil",
            "of the Student",
            "of the Prodigy",
            "of the Augur",
            "of the Philosopher",
            "of the Sage",
            "of the Savant",
            "of the Virtuoso",
            "of the Genius",
            "of the Newt",
            "of the Lizard",
            "of the Flatworm",
            "of the Starfish",
            "of the Hydra",
            "of the Troll",
            "of the Phoenix",
            "of the Cloud",
            "of the Squall",
            "of the Storm",
            "of the Thunderhead",
            "of the Tempest",
            "of the Maelstrom",
            "of the Lighting",
            "of the Worthy",
            "of the Apt",
            "of Thick Skin",
            "of Stone Skin",
            "of Iron Skin",
            "of Steel Skin",
            "of Adamantite Skin",
            "of Corundum Skin",
            "of the Mongoose",
            "of the Lynx",
            "of the Fox",
            "of the Falcon",
            "of the Panther",
            "of the Leopard",
            "of the Jaguar",
            "of the Phantom",
            "of the Wind",
            "of Dampening",
            "of Numbing",
            "of the Brute",
            "of the Wrestler",
            "of the Bear",
            "of the Lion",
            "of the Gorilla",
            "of the Goliath",
            "of the Leviathan",
            "of the Titan",
            "of the Gods"
            };
            #endregion

            #region Stats that need to be defined.
            string itemName;
            int strength = 0;
            int intelligence = 0;
            int dexterity = 0;
            int health = 0;
            int mana = 0;
            int armour = 0;
            double healthRegen = 0;
            double manaRegen = 0;
            double physicalResist = 0;
            double elementalResist = 0;
            double fireResist = 0;
            double lightningResist = 0;
            double coldResist = 0;
            double poisonResist = 0;
            double physicalDamage = 0;
            double elementalDamage = 0;
            double fireDamage = 0;
            double lightningDamage = 0;
            double coldDamage = 0;
            double poisonDamage = 0;
            Equip slot = 0;
            Type type = 0;
            int strengthReq = 1;
            int intelligenceReq = 1;
            int dexterityReq = 1;
            int price = 0;
            #endregion

            int itemLevel = random.Next(itemLevelMin, itemLevelMax + 1);

            int prefixChoice = random.Next(prefix.Length);
            int suffixChoice = random.Next(suffix.Length);

            slot = Equip.Chest;

            itemName = "";

            type = (Type)random.Next(3);

            #region Name generation.
            // Head names.
            if (slot.Equals(Equip.Head) && type.Equals(Type.Heavy))
                itemName = prefix[prefixChoice] + " Helmet " + suffix[suffixChoice];
            else if (slot.Equals(Equip.Head) && type.Equals(Type.Medium))
                itemName = prefix[prefixChoice] + " Cap " + suffix[suffixChoice];
            else if (slot.Equals(Equip.Head) && type.Equals(Type.Light))
                itemName = prefix[prefixChoice] + " Hood " + suffix[suffixChoice];
            // Chest names.
            if (slot.Equals(Equip.Chest) && type.Equals(Type.Heavy))
                itemName = prefix[prefixChoice] + " Chestplate " + suffix[suffixChoice];
            else if (slot.Equals(Equip.Chest) && type.Equals(Type.Medium))
                itemName = prefix[prefixChoice] + " Jacket " + suffix[suffixChoice];
            else if (slot.Equals(Equip.Chest) && type.Equals(Type.Light))
                itemName = prefix[prefixChoice] + " Robes " + suffix[suffixChoice];
            #endregion

            #region Affix minimum and maximum, affix cap and affix chooser.
            int affixMinimum = 0;
            int affixMaximum = 0;

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
                int affixChooser = random.Next(20);
                affixes.Add((Affix)affixChooser);
            }
            #endregion

            // Set base armour
            if (type.Equals(Type.Heavy))
                armour = random.Next((int)(7 * Math.Pow(1.024, itemLevel)), (int)(10 * Math.Pow(1.036, itemLevel)));
            else if (type.Equals(Type.Medium))
                armour = random.Next((int)(7 * Math.Pow(1.023, itemLevel)), (int)(10 * Math.Pow(1.035, itemLevel)));
            else if (type.Equals(Type.Light))
                armour = random.Next((int)(7 * Math.Pow(1.022, itemLevel)), (int)(10 * Math.Pow(1.034, itemLevel)));

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
                // Health
                if (affix.Equals(Affix.Health))
                    if (type.Equals(Type.Heavy))
                        health = random.Next((int)(5 * Math.Pow(1.043, itemLevel)));
                    else if (type.Equals(Type.Medium))
                        health = random.Next((int)(5 * Math.Pow(1.042, itemLevel)));
                    else if (type.Equals(Type.Light))
                        health = random.Next((int)(5 * Math.Pow(1.041, itemLevel)));
                // Mana
                if (affix.Equals(Affix.Mana))
                    if (type.Equals(Type.Heavy))
                        mana = random.Next((int)(5 * Math.Pow(1.039, itemLevel)));
                    else if (type.Equals(Type.Medium))
                        mana = random.Next((int)(5 * Math.Pow(1.040, itemLevel)));
                    else if (type.Equals(Type.Light))
                        mana = random.Next((int)(5 * Math.Pow(1.0441, itemLevel)));
                // Armour
                if (affix.Equals(Affix.Armour))
                    if (type.Equals(Type.Heavy))
                        armour += random.Next((int)(4 * Math.Pow(1.024, itemLevel)));
                    else if (type.Equals(Type.Medium))
                        armour += random.Next((int)(4 * Math.Pow(1.023, itemLevel)));
                    else if (type.Equals(Type.Light))
                        armour += random.Next((int)(4 * Math.Pow(1.021, itemLevel)));
                // Health Regeneration
                if (affix.Equals(Affix.HealthRegen))
                    healthRegen = random.Next((int)(5 * Math.Pow(1.02, itemLevel)));
                // Mana Regeneration
                if (affix.Equals(Affix.ManaRegen))
                    manaRegen = random.Next((int)(5 * Math.Pow(1.03, itemLevel)));
                // Physical Resistance
                if (affix.Equals(Affix.PhysicalResist))
                    physicalResist = random.Next(21) * 0.01;
                // Elemental Resistance
                if (affix.Equals(Affix.ElementalResist))
                    elementalResist = random.Next(21) * 0.01;
                // Fire Resistance
                if (affix.Equals(Affix.FireResist))
                    fireResist = random.Next(21) * 0.01;
                // Lightning Resistance
                if (affix.Equals(Affix.LightningResist))
                    lightningResist = random.Next(21) * 0.01;
                // Cold Resistance
                if (affix.Equals(Affix.ColdResist))
                    coldResist = random.Next(21) * 0.01;
                // Poison Resistance
                if (affix.Equals(Affix.PoisonResist))
                    poisonResist = random.Next(21) * 0.01;
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
            }
            #endregion

            // Strength requirement
            if (strength > 0 || type.Equals(Type.Heavy) || physicalDamage > 0 || physicalResist > 0 || healthRegen > 0 || health > 0)
                strengthReq = random.Next((int)(5 * Math.Pow(1.029, itemLevel)), (int)(5 * Math.Pow(1.036, itemLevel)));
            // Intelligence requirement
            if (intelligence > 0 || type.Equals(Type.Light) || elementalDamage > 0 || elementalResist > 0 || mana > 0)
                intelligenceReq = random.Next((int)(5 * Math.Pow(1.029, itemLevel)), (int)(5 * Math.Pow(1.036, itemLevel)));
            // Dexterity requirement
            if (dexterity > 0 || type.Equals(Type.Medium) || physicalDamage > 0)
                dexterityReq = random.Next((int)(5 * Math.Pow(1.029, itemLevel)), (int)(5 * Math.Pow(1.036, itemLevel)));

            // Buy and sell price
            price = (int)(20 * Math.Pow(1.024, itemLevel));

            return new Armour(itemName, slot, type, itemLevel, strengthReq, intelligenceReq, dexterityReq, strength, intelligence, dexterity, health, mana, armour, healthRegen, manaRegen, physicalResist, elementalResist, fireResist, lightningResist, coldResist, poisonResist, physicalDamage, elementalDamage, fireDamage, lightningDamage, coldDamage, poisonDamage, price);
        }

        public Armour(string _name, Equip slot, Enum armourType, int levelReq, int strReq, int intReq, int dexReq, int strBonus, int intBonus, int dexBonus, int health, int mana, int armour, double hpRegen, double mpRegen, double physRes, double eleRes, double fireRes, double lightningRes, double coldRes, double poisonRes, double physDmgBonus, double eleDmgBonus, double fireBonus, double lightningBonus, double coldBonus, double poisonBonus, int gold)
        {
            equipSlot = slot;
            type = armourType;
            name = _name;
            price = gold;

            levelRequirement = levelReq;
            strengthRequirement = strReq;
            intelligenceRequirement = intReq;
            dexterityRequirement = dexReq;

            strengthBonus = strBonus;
            intelligenceBonus = intBonus;
            dexterityBonus = dexBonus;

            healthBonus = health;
            manaBonus = mana;
            armourBonus = armour;
            healthRegenerationBonus = hpRegen;
            manaRegenerationBonus = mpRegen;
            physicalResistanceBonus = physRes;
            elementalResistance = eleRes;
            fireResistance = fireRes;
            lightningResistance = lightningRes;
            coldResistance = coldRes;
            poisonResistance = poisonRes;

            physicalDamageBonus = physDmgBonus;
            elementalDamageBonus = eleDmgBonus;
            fireDamageBonus = fireBonus;
            lightningDamageBonus = lightningBonus;
            coldDamageBonus = coldBonus;
            poisonDamageBonus = poisonBonus;

            tooltip = $"{name}\r\n---------------\r\n" +
                $"{Enum.GetName(typeof(Item.Equip), equipSlot)} ({Enum.GetName(typeof(Armour.Type), type)})\r\n" +
                $"{armourBonus} armour\r\n---------------\r\n" +
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
                ((healthBonus != 0) ? $"+{healthBonus} health\r\n" : "") +
                ((manaBonus != 0) ? $"+{manaBonus} mana\r\n" : "") +
                ((healthRegenerationBonus != 0) ? $"+{healthRegenerationBonus} health per second\r\n" : "") +
                ((manaRegenerationBonus != 0) ? $"+{manaRegenerationBonus} mana per second\r\n" : "") +
                ((physicalResistanceBonus != 0) ? $"+{physicalResistanceBonus * 100}% to physical damage reduction\r\n" : "") +
                ((elementalResistance != 0) ? $"+{elementalResistance * 100}% to elemental resistance" : "") +
                ((fireResistance != 0) ? $"+{fireResistance * 100}% to fire resistance\r\n" : "") +
                ((lightningResistance != 0) ? $"+{lightningResistance * 100}% to lightning resistance\r\n" : "") +
                ((coldResistance != 0) ? $"+{coldResistance * 100}% to cold resistance\r\n" : "") +
                ((poisonResistance != 0) ? $"+{poisonResistance * 100}% to poison resistance\r\n" : "");
        }
    }
}
