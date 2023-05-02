using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TF2_Simulator
{
    internal class MeleeWeapons
    {
        public static int Attack(int ClassID, int WeaponID, int PlayerCooldown, bool SecondaryTrigger, int PlayerHP, int PlayerMAXHP)
        {
            var randomdamage = new Random();
            int Totaldamage = 0;
            int Special = 0;
            
            #region AllClass
            if (WeaponID == 999)
            {
                // Attacky Thingy - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 200)
            {
                // Saxxy - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 201)
            {
                // Frying Pan - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 202)
            {
                // Conscientious Objector - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 203)
            {
                // Freedom Staff - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 204)
            {
                // Bat Outta Hell - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 205)
            {
                // Memory Maker - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 206)
            {
                // Ham Shank - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 207)
            {
                // Necro Smasher - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 208)
            {
                // Crossing Guard - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 209)
            {
                // Prinny Machete - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (WeaponID == 210)
            {
                // Golden Frying Pan - a "little" bit of damage
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(999, 99999999);  // creates a number between  [Damage]
                return Totaldamage;
            }

            #endregion
            //Continue Here ↓
            #region Scout
            if (ClassID == 1 && WeaponID == 17)
            {
                // Bat - 12-35
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 18)
            {
                // Holy Mackeral - 12-35
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 19)
            {
                // Unarmed Combat - 12-35
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 20)
            {
                // Batsaber - 30-60
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(30, 60);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 21) //Special Weapon!!! [4. Hit a Baseball]
            {
                // Sandman - 12-35
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 22)
            {
                // Candy Cane - 12-35 // 50% of damage returned as HP.
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 23)
            {
                // Boston Basher - 60 50% to hit enemy / 50% chance to hit self.
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(1, 3);  // creates a number between 1-2 [Damage]
                return Totaldamage; //If 1, deal 60 damage to enemy, if 2, deal 60 damage to player [Same Regardless of holder]
            }
            if (ClassID == 1 && WeaponID == 24)
            {
                // Three Rune Blade - 150 [Boston Basher but so much more risky.]
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(1, 3);  // creates a number between 1-2 [Damage]
                return Totaldamage; //If 1, deal 60 damage to enemy, if 2, deal 60 damage to player [Same Regardless of holder]
            }
            if (ClassID == 1 && WeaponID == 25)
            {
                // Sun on a Stick - 8-26 //Inflicts Fire, Holder is Immune to Fire Damage
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(8, 27);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 26)
            {
                // Fan O'War - 9 //Marks Enemy for Death [Minicrits = Crits] [27]
                Totaldamage = 9;
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 27)
            {
                // Atomizer - 12-35
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 1 && WeaponID == 28)
            {
                // Wrap Assassin - 12-35 [4. Throw Ornament] [15-45]
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(12, 36);  // creates a number between  [Damage]
                return Totaldamage;
            }
            #endregion

            #region Soldier
            if (ClassID == 2 && WeaponID == 48)
            {
                // Shovel - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 49)
            {
                // Equalizer - Varies with HP.
                Totaldamage = 0;
                int Increaser = PlayerMAXHP - PlayerHP * 100;
                int FinisedTotal = 100 - Increaser;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                Totaldamage = Totaldamage * Increaser / 100;
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 50)
            {
                // Pain Train - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 51)
            {
                // Half-Zatochi - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 52)
            {
                // Disciplinary Action - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 53)
            {
                // Market Gardener - 32-64 [4. Perform a Market Garden] !!!Special Weapon!
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 2 && WeaponID == 54)
            {
                // Shovel - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            #endregion

            #region Pyro

            #endregion

            #region Demoman
            if (ClassID == 4 && WeaponID == 51)
            {
                // Half-Zatochi - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            #endregion

            #region Heavy

            #endregion

            #region Engineer

            #endregion

            #region Medic
            if (ClassID == 7 && WeaponID == 150)
            {
                // Bonesaw - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 151)
            {
                // Ubersaw - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 152)
            {
                // Vita-Saw - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 153)
            {
                // Amputator - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between  [Damage]
                return Totaldamage;
            }
            if (ClassID == 7 && WeaponID == 154)
            {
                // Solemn Vow - 40-70
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(40, 71);  // creates a number between  [Damage]
                return Totaldamage;
            }
            #endregion

            #region Sniper
            if (ClassID == 8 && WeaponID == 172)
            {
                // Kukri - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 173)
            {
                // Tribalman's Shiv - 16-32
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(16, 33);
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 174)
            {
                // Bushwacka - 32-64 // Take 20% more damage when equipped
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
            if (ClassID == 8 && WeaponID == 175)
            {
                // Shahanshah - 32-64
                Totaldamage = 0;
                Totaldamage = Totaldamage + randomdamage.Next(32, 65);  // creates a number between 32-64 [Damage]
                return Totaldamage;
            }
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
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 2)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 3)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 4)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 5)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 6)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 7)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 8)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
            }
            if (ClassID == 9)
            {
                return "  ID 200 == Saxxy\r\n  ID 201 == Frying Pan\r\n  ID 202 == Conscientious Objector\r\n  ID 203 == Freedom Staff\r\n  ID 204 == Bat Outta Hell\r\n  ID 205 == Memory Maker\r\n  ID 206 == Ham Shank\r\n  ID 207 == Necro Smasher\r\n  ID 208 == Crossing Guard\r\n  ID 209 == Prinny Machete\r\n  ID 210 == Golden Frying Pan\r\n  ID 999 == Attacky Thingy";
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
            if (WeaponID == 116) { return "Error: Duplicated Weapon [Panic Attack]"; }
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
            if (WeaponID == 999) { return "Attacky Thingy";  }
            return "error";
        }
    }
}
