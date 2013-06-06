using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LoL
{
    public class Champs
    {
        public string name;
        public string charType;
        public string health;
        public string adPercent;
        public string apPercent;
        public string difficulty;
        public string releaseDate;
        public string ipCost;
        public string rpCost;

        public string counterURL;
        public string buildsURL;
        public string skillsURL;

        private string[] counter;

        private Skills skills;
        private List<Builds> builds;

        
        

        public void setChampStats(string champ)
        {
            //String that passes through:
            //Champion&charType&Health&adPercent&apPercent&Difficulty&Date&IPCost&RPCost

            string[] splitChamp = Regex.Split(champ, "&");

            name = splitChamp[0];
            charType = splitChamp[1];
            health = splitChamp[2];
            adPercent = splitChamp[3];
            apPercent = splitChamp[4];
            difficulty = splitChamp[5];
            releaseDate = splitChamp[6];
            ipCost = splitChamp[7];
            rpCost = splitChamp[8];

            if (splitChamp.Length > 9)
            {
                counterURL = splitChamp[9];
                buildsURL = splitChamp[10];
                skillsURL = splitChamp[11];
            }
        }

        public void setCounters(string counter)
        {
            this.counter = Regex.Split(counter, "&");
        }

        public string[] getCounters()
        {
            return counter;
        }


        public Champs findChamp(string name)
        {
            if (this.name == name)return this;
            return null;
        }

        public string getName() { return name; }
    }
}
