using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjto.Character
{
    class Character
    {
        private String name             = "";
        private String description      = "";
        int level                       = 0;
        int attributePoints             = 3;
        int exp                         = 0;
        int expMax                      = 100;

        int strength                    = 1;
        int vitality                    = 1;
        int dexterity                   = 1;
        int agility                     = 1;
        int intelligence                = 1;

        int hp                          = 0;         
        int hpMax                       = 0;
        int damage                      = 0;
        int damageMax                   = 0;
        int accuracy                    = 0;
        int defence                     = 0;

        int gold                        = 100;
        
        private void CalculateExp()
        {
            this.expMax = this.level * 100;
        }

        private void CalculateStates()
        {
            this.hp = this.vitality * 10;
            this.damageMax = this.strength * 2;
            this.damage = this.strength;
            this.accuracy = this.dexterity * 2;
            this.defence = this.agility * 2;
        }

        public Character(String name, String description)
        {
            this.CalculateStates();

            this.name = name;
            this.description = description;
        }

        public override String ToString()
        {
            return this.name;
        }
    }
}
