using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class PrimaryWeapons
    {
        public static int Attack(int ClassID, int WeaponID, int PlayerCooldown, bool SecondaryTrigger)
        {
            var randomdamage = new Random();
            int Totaldamage = 0;
            int BabyFaceBuildup = 5;
            int Special = 0;
            int RocketsLoaded = 0;
            int PhlogRage = 0;
            int PhlogCrits = 0;

            #region Scout
            if (ClassID == 1 && WeaponID == 1)
            {
                // Scattergun - 6-12 x 1-5 [6-60]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 2)
            {
                // Force-A-Nature - 4-9 x 3-7 [12-63]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(3, 8); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(4, 10); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 3)
            {
                // Shortstop - 12-18 x 1-4 [12-72]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 5); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(12, 19); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 4)
            {
                // Soda Popper - 5-10 x 3-6 [15-60] //Slightly Less Max damage than the FaN, but with more min damage.
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(2, 7); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(5, 11); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 5)
            {
                // Baby Face's Blaster - 4-8 x 1-effectively ∞ [4-effectively ∞]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, BabyFaceBuildup); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(0, 0); } // creates a number between   [Damage]
                BabyFaceBuildup =+ randomdamage.Next(0, 5); //This is going to be very weird and can probably be abused by ALL Scouts holding this weapon at once.
                //May add a Max cap for pellets later. Nerfing Damage for now.
                return Totaldamage;
            }

            if (ClassID == 1 && WeaponID == 6)
            {
                // Back Scatter - 6-12 x 1-5 [6-60] + 20% Chance for a Mini-crit "Boomerang" --> (8-16) x 1-5 [8-80]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                Special = randomdamage.Next(1, 11); // 1-10, Trips weapon Special if RareUse == 1 or 2,
                if (Special <= 2) { Totaldamage = Totaldamage + (35 * Totaldamage / 100); } // 20% Chance for Mini-Crits
                return Totaldamage;
            }
            #endregion

            #region Soldier
            if (ClassID == 2 && WeaponID == 29)
            {
                // Rocket Launcher - 36-52 -- Rocket Launchers are SIMPLE, wow.
                Totaldamage = randomdamage.Next(36, 53);
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 30)
            {
                // The Original - 38-54 -- Functions Exactly like the Rocket Launcher other than the Positioning, that doesn't matter in this game, so it has a slight damage boost.
                Totaldamage = randomdamage.Next(38, 55);
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 31)
            {
                // Direct Hit - 43-76 [0-43-76] 40% chance to hit
                Totaldamage = 0;
                Special = randomdamage.Next(1, 11); //Rolls a 1-10, if the number is 4 or lower, the shot lands.
                if (Special <= 4) { Totaldamage = randomdamage.Next(43, 77); } //Damage is rolled only if the Special rolls a 4 or lower.
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 32)
            {
                // Black Box - 36-52 -- Functions Exactly like the Rocket Launcher, but will grant the wielder 1/4th of the damage dealt as HP.
                Totaldamage = randomdamage.Next(36, 53);
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 33)
            {
                // Rocket Jumper - 0 -- Deals 0 damage, no need for a randomizer here!
                Totaldamage = 0;
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 34)
            {
                // Liberty Launcher - 30-46 -- 40-62 [Mini] -- 90-138 [Crit]
                Totaldamage = randomdamage.Next(30, 47);
                Special = randomdamage.Next(1, 101); 
                if (Special <= 10) { Totaldamage = Totaldamage + (35 * Totaldamage / 100); }
                if (Special == 1) { Totaldamage = Totaldamage * 3; }
                // 10% chance of a Mini-Crit
                // 1% chance of a Crit
                return Totaldamage;
            }

            if (ClassID == 2 && WeaponID == 35)
            {
                // Cow Mangler 5000 - 36-52 -- Functions as Rocket Launcher, add Mini-Crit + Cooldown Later.
                Totaldamage = randomdamage.Next(36, 53);
                if (PlayerCooldown == 0 & SecondaryTrigger == true)
                {
                    SecondaryTrigger = false;
                    Totaldamage = Totaldamage + (35 * Totaldamage / 100);
                    //PlayerCooldown = 4;
                }
                return Totaldamage; //return PlayerCooldown;
            }

            if (ClassID == 2 && WeaponID == 36)
            {
                // Beggar's Bazooka - 42-58 x 1-10
                Totaldamage = 0;
                if (SecondaryTrigger == true)
                {
                    SecondaryTrigger = false;
                    RocketsLoaded++;
                }
                for (int i = 0; i < RocketsLoaded; i++)
                {
                    Totaldamage = Totaldamage + randomdamage.Next(42, 59);
                }
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 37)
            {
                // Air Strike - 12-21 -- Damage Greatly Reduced, but an extra rocket is fired each time.
                Special++;
                for (int i = 0; i < Special; i++)
                {
                    Totaldamage = Totaldamage + randomdamage.Next(12, 22);
                }
                return Totaldamage;
            }
            #endregion
           
            #region Pyro
            if (ClassID == 3 && WeaponID == 55)
            {
                // Flame Thrower - 6-12 x 1-5 [6-60]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                return Totaldamage;
            }
            
            if (ClassID == 3 && WeaponID == 56)
            {
                // Rainblower - 6-12 x 1-5 [6-60] //Flame Thrower Pyroland Reskin, no changes possible.
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 3 && WeaponID == 57)
            {
                // Nostromo Napalmer - 6-12 x 1-5 [6-60]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 3 && WeaponID == 58)
            {
                // Backburner - 6-12 x 1-5 [6-60] +20% chance for Mini-Crits
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                Special = randomdamage.Next(1, 11); // 1-10, Trips weapon Special if RareUse == 1 or 2,
                if (Special <= 2) { Totaldamage = Totaldamage + (35 * Totaldamage / 100); } // 20% Chance for Mini-Crits
                return Totaldamage;
            }

            if (ClassID == 3 && WeaponID == 59)
            {
                // Degreaser - 6-12 x 1-7 [6-84] //Increased Max Flames by 2,
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 8); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                return Totaldamage;
            }

            if (ClassID == 3 && WeaponID == 60)
            {
                // Phlogistinator - 6-12 x 1-5 [6-60] //Auto-Special: Phlog-Rage  --  If PhlogRage reaches 200 total damage, next 3 uses will be 100% crits.
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(6, 13); } // creates a number between   [Damage]
                PhlogRage = +Totaldamage;
                if (PhlogRage >= 200 && PhlogCrits == 0)
                {
                    PhlogRage = 0;
                    PhlogCrits = 3;
                }
                if (PhlogCrits > 0)
                {
                    Totaldamage = Totaldamage * 3;
                    PhlogCrits--;
                }
                return Totaldamage;
            }

            if (ClassID == 3 && WeaponID == 61)
            {
                // Dragon's Fury - 8-18 x 1-5 [8-90]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 6); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(8, 19); } // creates a number between   [Damage]
                return Totaldamage;
            }
            #endregion

            #region Demoman
            if (ClassID == 4 && WeaponID == 80)
            {
                // Grenade Launcher - 18-81 x 1-3 [6-60]
                Totaldamage = 0;
                int BulletsFired = randomdamage.Next(1, 4); // Creates a Randomizer to determine how many pellets/projectiles/bullets hit. Each bullet/pellet has a randomized damage within the range
                for (int i = 0; i < BulletsFired; i++)
                { Totaldamage = Totaldamage + randomdamage.Next(18, 27); } // creates a number between   [Damage]
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 81)
            {
                // Loch-n-Load - 24-104 [6-60] 40% chance to hit
                Totaldamage = 0;
                Special = randomdamage.Next(1, 11); //Rolls a 1-10, if the number is 4 or lower, the shot lands.
                if (Special <= 4) { Totaldamage = randomdamage.Next(24, 104); } //Damage is rolled only if the Special rolls a 4 or lower.
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 82)
            {
                // Ali Baba's Wee Booties - 0

                // First Non-Weapon! this will be "fun" to deal with...
                // Add Specialcheck in-game for this combo [Class + Weapon], if its true, add +25 HP to Player HP
               
                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 83)
            {
                // Bootlegger - 0

                // Second Non-Weapon! this will also be "fun" to deal with... luckily this functions exactly like the above weapon.
                // Add Specialcheck in-game for this combo [Class + Weapon], if its true, add +25 HP to Player HP

                Totaldamage = 0;
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 84)
            {
                // Loose Cannon - 26-46
                Totaldamage = randomdamage.Next(26, 47);
                Special = randomdamage.Next(1, 101);
                if (Special <= 10) { Totaldamage = Totaldamage + (35 * Totaldamage / 100); Console.WriteLine("  !!! -- DOUBLE DONK"); }
                // 10% chance of a Mini-Crit [Double-Donk]
                return Totaldamage;
            }
            if (ClassID == 4 && WeaponID == 85)
            {
                // Iron Bomber - 20-89 80% chance to hit
                Totaldamage = 0;
                Special = randomdamage.Next(1, 11); //Rolls a 1-10, if the number is 8 or lower, the shot lands.
                if (Special <= 8) { Totaldamage = randomdamage.Next(20, 90); } //Damage is rolled only if the Special rolls a 8 or lower.
                return Totaldamage;
            }
            #endregion
            //Continue Here ↓
            #region Heavy

            #endregion

            #region Engineer

            #endregion

            #region Medic

            #endregion

            #region Sniper

            #endregion

            #region Spy
            //Spy has no Primary Weapons.
            #endregion

            return 0;
        }
        public static string Names(int ClassID)
        {
            if (ClassID == 1)
            {
                return "  ID 1 == Scattergun\r\n  ID 2 == Force-A-Nature\r\n  ID 3 == Shortstop\r\n  ID 4 == Soda Popper\r\n  ID 5 == Baby Face's Blaster\r\n  ID 6 == Back Scatter";
            }
            if (ClassID == 2)
            {
                return "  ID 29 == Rocket Launcher\r\n  ID 30 == Original\r\n  ID 31 == Direct Hit\r\n  ID 32 == Black Box\r\n  ID 33 == Rocket Jumper\r\n  ID 34 == Liberty Launcher\r\n  ID 35 == Cow Mangler 5000\r\n  ID 36 == Beggar's Bazooka\r\n  ID 37 == Air Strike";
            }
            if (ClassID == 3)
            {
                return "  ID 55 == Flame Thrower\r\n  ID 56 == Rainblower\r\n  ID 57 == Nostromo Napalmer\r\n  ID 58 == Backburner\r\n  ID 59 == Degreaser\r\n  ID 60 == Phlogistinator\r\n  ID 61 == Dragon's Fury";
            }
            if (ClassID == 4)
            {
                return "  ID 80 == Grenade Launcher\r\n  ID 81 == Loch-n-Load\r\n  ID 82 == Ali Baba's Wee Booties\r\n  ID 83 == Bootlegger\r\n  ID 84 == Loose Cannon\r\n  ID 85 == Iron Bomber";
            }
            if (ClassID == 5)
            {
                return "  ID 104 == Minigun\r\n  ID 105 == Iron Curtain\r\n  ID 106 == Natascha\r\n  ID 107 == Brass Beast\r\n  ID 108 == Tomislav\r\n  ID 109 == Huo-Long Heater";
            }
            if (ClassID == 6)
            {
                return "  ID 127 == Frontier Justice\r\n  ID 128 == Widowmaker\r\n  ID 129 == Pomson 6000\r\n  ID 130 == Rescue Ranger";
            }
            if (ClassID == 7)
            {
                return "  ID 142 == Syringe Gun\r\n  ID 143 == Blutsauger\r\n  ID 144 == Crusader's Crossbow\r\n  ID 145 == Overdose";
            }
            if (ClassID == 8)
            {
                return "  ID 155 == Sniper Rifle\r\n  ID 156 == AWPer Hand\r\n  ID 157 == Huntsman\r\n  ID 158 == Fortified Compound\r\n  ID 159 == Sydney Sleeper\r\n  ID 160 == Bazaar Bargain\r\n  ID 161 == Machina\r\n  ID 162 == Shooting Star\r\n  ID 163 == Hitman's Heatmaker\r\n  ID 164 == Classic";
            }
            if (ClassID == 9)
            {
                return "Spy doesn't have Primary Weapons";
            }
            return "Error";
        }
        public static string SpecificWeaponName(int WeaponID)
        {
            if (WeaponID == 0) { return "No Weapon"; }
            if (WeaponID == 1) { return "Scattergun"; }
            if (WeaponID == 2) { return "Force-A-Nature"; }
            if (WeaponID == 3) { return "Shortstop"; }
            if (WeaponID == 4) { return "Soda Popper"; }
            if (WeaponID == 5) { return "Baby Face's Blaster"; }
            if (WeaponID == 6) { return "Back Scatter"; }
            if (WeaponID == 7) { return "Pistol"; }
            if (WeaponID == 8) { return "Lugermorph"; }
            if (WeaponID == 9) { return "C.A.P.P.E.R"; }
            if (WeaponID == 10) { return "Winger"; }
            if (WeaponID == 11) { return "Pretty Boy's Pocket Pistol"; }
            if (WeaponID == 12) { return "Flying Guillotine"; }
            if (WeaponID == 13) { return "Bonk! Atomic Punch"; }
            if (WeaponID == 14) { return "Crit-a-Cola"; }
            if (WeaponID == 15) { return "Mad Milk"; }
            if (WeaponID == 16) { return "Mutated Milk"; }
            if (WeaponID == 17) { return "Bat"; }
            if (WeaponID == 18) { return "Holy Mackerel"; }
            if (WeaponID == 19) { return "Unarmed Combat"; }
            if (WeaponID == 20) { return "Batsaber"; }
            if (WeaponID == 21) { return "Sandman"; }
            if (WeaponID == 22) { return "Candy Cane"; }
            if (WeaponID == 23) { return "Boston Basher"; }
            if (WeaponID == 24) { return "Three-Rune Blade"; }
            if (WeaponID == 25) { return "Sun-on-a-Stick"; }
            if (WeaponID == 26) { return "Fan O'War"; }
            if (WeaponID == 27) { return "Atomizer"; }
            if (WeaponID == 28) { return "Wrap Assassin"; }
            if (WeaponID == 29) { return "Rocket Launcher"; }
            if (WeaponID == 30) { return "Original"; }
            if (WeaponID == 31) { return "Direct Hit"; }
            if (WeaponID == 32) { return "Black Box"; }
            if (WeaponID == 33) { return "Rocket Jumper"; }
            if (WeaponID == 34) { return "Liberty Launcher"; }
            if (WeaponID == 35) { return "Cow Mangler 5000"; }
            if (WeaponID == 36) { return "Beggar's Bazooka"; }
            if (WeaponID == 37) { return "Air Strike"; }
            if (WeaponID == 38) { return "Shotgun"; }
            if (WeaponID == 39) { return "Reserve Shooter"; }
            if (WeaponID == 40) { return "Buff Banner"; }
            if (WeaponID == 41) { return "Gunboats"; }
            if (WeaponID == 42) { return "Battalion's Backup"; }
            if (WeaponID == 43) { return "Concheror"; }
            if (WeaponID == 44) { return "Mantreads"; }
            if (WeaponID == 45) { return "Righteous Bison"; }
            if (WeaponID == 46) { return "B.A.S.E. Jumper"; }
            if (WeaponID == 47) { return "Panic Attack"; }
            if (WeaponID == 48) { return "Shovel"; }
            if (WeaponID == 49) { return "Equalizer"; }
            if (WeaponID == 50) { return "Pain Train"; }
            if (WeaponID == 51) { return "Half-Zatoichi"; }
            if (WeaponID == 52) { return "Disciplinary Action"; }
            if (WeaponID == 53) { return "Market Gardener"; }
            if (WeaponID == 54) { return "Escape Plan"; }
            if (WeaponID == 55) { return "Flame Thrower"; }
            if (WeaponID == 56) { return "Rainblower"; }
            if (WeaponID == 57) { return "Nostromo Napalmer"; }
            if (WeaponID == 58) { return "Backburner"; }
            if (WeaponID == 59) { return "Degreaser"; }
            if (WeaponID == 60) { return "Phlogistinator"; }
            if (WeaponID == 61) { return "Dragon's Fury"; }
            if (WeaponID == 62) { return "Flare Gun"; }
            if (WeaponID == 63) { return "Detonator"; }
            if (WeaponID == 64) { return "Manmelter"; }
            if (WeaponID == 65) { return "Scorch Shot"; }
            if (WeaponID == 66) { return "Thermal Thruster"; }
            if (WeaponID == 67) { return "Gas Passer"; }
            if (WeaponID == 68) { return "Fire Axe"; }
            if (WeaponID == 69) { return "Lollichop"; }
            if (WeaponID == 70) { return "Axtinguisher"; }
            if (WeaponID == 71) { return "Postal Pummeler"; }
            if (WeaponID == 72) { return "Homewrecker"; }
            if (WeaponID == 73) { return "Maul"; }
            if (WeaponID == 74) { return "Powerjack"; }
            if (WeaponID == 75) { return "Back Scratcher"; }
            if (WeaponID == 76) { return "Sharpened Volcano Fragment"; }
            if (WeaponID == 77) { return "Third Degree"; }
            if (WeaponID == 78) { return "Neon Annihilator"; }
            if (WeaponID == 79) { return "Hot Hand"; }
            if (WeaponID == 80) { return "Grenade Launcher"; }
            if (WeaponID == 81) { return "Loch-n-Load"; }
            if (WeaponID == 82) { return "Ali Baba's Wee Booties"; }
            if (WeaponID == 83) { return "Bootlegger"; }
            if (WeaponID == 84) { return "Loose Cannon"; }
            if (WeaponID == 85) { return "Iron Bomber"; }
            if (WeaponID == 86) { return "Stickybomb Launcher"; }
            if (WeaponID == 87) { return "Scottish Resistance"; }
            if (WeaponID == 88) { return "Chargin' Targe"; }
            if (WeaponID == 89) { return "Sticky Jumper"; }
            if (WeaponID == 90) { return "Splendid Screen"; }
            if (WeaponID == 91) { return "Tide Turner"; }
            if (WeaponID == 92) { return "Quickiebomb Launcher"; }
            if (WeaponID == 93) { return "Bottle"; }
            if (WeaponID == 94) { return "Scottish Handshake"; }
            if (WeaponID == 95) { return "Eyelander"; }
            if (WeaponID == 96) { return "Horseless Headless Horsemann's Headtaker"; }
            if (WeaponID == 97) { return "Nessie's Nine Iron"; }
            if (WeaponID == 98) { return "Scotsman's Skullcutter"; }
            if (WeaponID == 99) { return "Pain Train"; }
            if (WeaponID == 100) { return "Ullapool Caber"; }
            if (WeaponID == 101) { return "Claidheamh Mòr"; }
            if (WeaponID == 102) { return "Half-Zatoichi"; }
            if (WeaponID == 103) { return "Persian Persuader"; }
            if (WeaponID == 104) { return "Minigun"; }
            if (WeaponID == 105) { return "Iron Curtain"; }
            if (WeaponID == 106) { return "Natascha"; }
            if (WeaponID == 107) { return "Brass Beast"; }
            if (WeaponID == 108) { return "Tomislav"; }
            if (WeaponID == 109) { return "Huo-Long Heater"; }
            if (WeaponID == 110) { return "Family Business"; }
            if (WeaponID == 111) { return "Sandvich"; }
            if (WeaponID == 112) { return "Robo-Sandvich"; }
            if (WeaponID == 113) { return "Dalokohs Bar"; }
            if (WeaponID == 114) { return "Fishcake"; }
            if (WeaponID == 115) { return "Buffalo Steak Sandvich"; }
            if (WeaponID == 116) { return "Panic Attack"; }
            if (WeaponID == 117) { return "Second Banana"; }
            if (WeaponID == 118) { return "Fists"; }
            if (WeaponID == 119) { return "Apoco-Fists"; }
            if (WeaponID == 120) { return "Killing Gloves of Boxing"; }
            if (WeaponID == 121) { return "Gloves of Running Urgently"; }
            if (WeaponID == 122) { return "Bread Bite"; }
            if (WeaponID == 123) { return "Warrior's Spirit"; }
            if (WeaponID == 124) { return "Fists of Steel"; }
            if (WeaponID == 125) { return "Eviction Notice"; }
            if (WeaponID == 126) { return "Holiday Punch"; }
            if (WeaponID == 127) { return "Frontier Justice"; }
            if (WeaponID == 128) { return "Widowmaker"; }
            if (WeaponID == 129) { return "Pomson 6000"; }
            if (WeaponID == 130) { return "Rescue Ranger"; }
            if (WeaponID == 131) { return "Wrangler"; }
            if (WeaponID == 132) { return "Giger Counter"; }
            if (WeaponID == 133) { return "Short Circuit"; }
            if (WeaponID == 134) { return "Wrench"; }
            if (WeaponID == 135) { return "Golden Wrench"; }
            if (WeaponID == 136) { return "Gunslinger"; }
            if (WeaponID == 137) { return "Southern Hospitality"; }
            if (WeaponID == 138) { return "Jag"; }
            if (WeaponID == 139) { return "Eureka Effect"; }
            if (WeaponID == 140) { return "Consturction PDA"; }
            if (WeaponID == 141) { return "Destruction PDA"; }
            if (WeaponID == 142) { return "Syringe Gun"; }
            if (WeaponID == 143) { return "Blutsauger"; }
            if (WeaponID == 144) { return "Crusader's Crossbow"; }
            if (WeaponID == 145) { return "Overdose"; }
            if (WeaponID == 146) { return "Medi Gun"; }
            if (WeaponID == 147) { return "Kritzkrieg"; }
            if (WeaponID == 148) { return "Quick-Fix"; }
            if (WeaponID == 149) { return "Vaccinator"; }
            if (WeaponID == 150) { return "Bonesaw"; }
            if (WeaponID == 151) { return "Übersaw"; }
            if (WeaponID == 152) { return "Vita-Saw"; }
            if (WeaponID == 153) { return "Amputator"; }
            if (WeaponID == 154) { return "Solemn Vow"; }
            if (WeaponID == 155) { return "Sniper Rifle"; }
            if (WeaponID == 156) { return "AWPer Hand"; }
            if (WeaponID == 157) { return "Huntsman"; }
            if (WeaponID == 158) { return "Fortified Compound"; }
            if (WeaponID == 159) { return "Sydney Sleeper"; }
            if (WeaponID == 160) { return "Bazaar Bargain"; }
            if (WeaponID == 161) { return "Machina"; }
            if (WeaponID == 162) { return "Shooting Star"; }
            if (WeaponID == 163) { return "Hitman's Heatmaker"; }
            if (WeaponID == 164) { return "Classic"; }
            if (WeaponID == 165) { return "SMG"; }
            if (WeaponID == 166) { return "Cleaner's Carbine"; }
            if (WeaponID == 167) { return "Jarate"; }
            if (WeaponID == 168) { return "Self-Aware Beauty Mark"; }
            if (WeaponID == 169) { return "Razorback"; }
            if (WeaponID == 170) { return "Darwin's Danger Shield"; }
            if (WeaponID == 171) { return "Cozy Camper"; }
            if (WeaponID == 172) { return "Kukri"; }
            if (WeaponID == 173) { return "Tribalman's Shiv"; }
            if (WeaponID == 174) { return "Bushwacka"; }
            if (WeaponID == 175) { return "Shahanshah"; }
            if (WeaponID == 176) { return "Revolver"; }
            if (WeaponID == 177) { return "Big Kill"; }
            if (WeaponID == 178) { return "Ambassador"; }
            if (WeaponID == 179) { return "L'Etranger"; }
            if (WeaponID == 180) { return "Enforcer"; }
            if (WeaponID == 181) { return "Diamondback"; }
            if (WeaponID == 182) { return "Knife"; }
            if (WeaponID == 183) { return "Sharp Dresser"; }
            if (WeaponID == 184) { return "Black Rose"; }
            if (WeaponID == 185) { return "Your Eternal Reward"; }
            if (WeaponID == 186) { return "Wanga Prick"; }
            if (WeaponID == 187) { return "Conniver's Kunai"; }
            if (WeaponID == 188) { return "Big Earner"; }
            if (WeaponID == 189) { return "Spy-cicle"; }
            if (WeaponID == 190) { return "Disguise Kit"; }
            if (WeaponID == 191) { return "Invis Watch"; }
            if (WeaponID == 192) { return "Enthusiast's Timepiece"; }
            if (WeaponID == 193) { return "Quäckenbirdt"; }
            if (WeaponID == 194) { return "Cloak and Dagger"; }
            if (WeaponID == 195) { return "Dead Ringer"; }
            if (WeaponID == 196) { return "Sapper"; }
            if (WeaponID == 197) { return "Ap-Sap"; }
            if (WeaponID == 198) { return "Snack Attack"; }
            if (WeaponID == 199) { return "Red-Tape Recorder"; }
            if (WeaponID == 200) { return "Saxxy"; }
            if (WeaponID == 201) { return "Frying Pan"; }
            if (WeaponID == 202) { return "Conscientious Objector"; }
            if (WeaponID == 203) { return "Freedom Staff"; }
            if (WeaponID == 204) { return "Bat Outta Hell"; }
            if (WeaponID == 205) { return "Memory Maker"; }
            if (WeaponID == 206) { return "Ham Shank"; }
            if (WeaponID == 207) { return "Necro Smasher"; }
            if (WeaponID == 208) { return "Crossing Guard"; }
            if (WeaponID == 209) { return "Prinny Machete"; }
            if (WeaponID == 210) { return "Golden Frying Pan"; }
            if (WeaponID == 211) { return "Legendary Ticket"; }
            if (WeaponID == 212) { return "Backpack Expander"; }
            return "error";
        }
             



















        public PrimaryWeapons() 
        {
            int PrimaryWeaponID;
            string PrimaryWeaponName;
        }
        public static int PrimaryWeaponCompatable(int ClassID)
        {
            //Scout
            if (ClassID == 0) return 0;
            if (ClassID == 1) return 1;
            if (ClassID == 2) return 2;
            if (ClassID == 3) return 3;
            if (ClassID == 4) return 4;
            if (ClassID == 5) return 5;
            if (ClassID == 6) return 6;
            if (ClassID == 7) return 7;
            if (ClassID == 8) return 8;
            if (ClassID == 9) return 9;
            if (ClassID == 10) return 0;
            return 0;
        }
    }
}
