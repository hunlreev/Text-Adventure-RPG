﻿/* Author: Hunter Reeves
 * Date: 11/06/2019
 * File: Mage.cs
 * Description: Class for Mage
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Project_352
{
    public class Mage
    {
        // Create a Mage, weakest class
        public Mage(string name, string classification)
        {
            this.name = name;
            this.classification = classification;
            info.level = 1;
            info.gold = 0;
            info.exp = 0;
            info.totalExp = 50;
            stats.health = 100;
            stats.totalHealth = 100;
            stats.mana = 100;
            stats.totalMana = 100;
            stats.stamina = 100;
            stats.totalStamina = 100;
            attr.strength = 6;
            attr.endurance = 8;
            attr.intelligence = 14;
            attr.dexterity = 12;
        }
        // Base damage the player does, accounts for strength stat and weapon damage
        public double DoDamage()
        {
            return 0.5 * (attr.strength + (attr.intelligence * 0.25));
        }
        public double Flames()
        {
            return DoDamage() + 6;
        }

        public string name;
        public string classification;
        public Information info = new Information();
        public Stats stats = new Stats();
        public Attributes attr = new Attributes();
    }
}
