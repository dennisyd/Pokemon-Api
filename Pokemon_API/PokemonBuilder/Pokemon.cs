using System;
namespace Pokemon_API.PokemonBuilder
{
    public class Pokemon
    {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Level { get; private set; }

        public DamageMultiplier damageMultiplier { get; set; }

        public int Attack { get; private set; }
        public int Defense { get; private set; }
        public int Special_Attack { get; private set; }
        public int Special_Defense { get; private set; }
        public int Speed { get; private set; }

        private int baseHP { get; set; }
        private int baseAttack { get; set; }
        private int baseDefense { get; set; }
        private int baseSpecial_Attack { get; set; }
        private int baseSpecial_Defense { get; set; }
        private int baseSpeed { get; set; }
        private int levelBonus { get; set; }

        public int attack_Stage { get; set; }
        public int defense_Stage { get; set; }
        public int spAttack_Stage { get; set; }
        public int spDefense_stage { get; set; }
        public int speed_stage { get; set; }
        public int acc_stage { get; set; }
        public int evasive_stage { get; set; }

        public int critRatio_stage { get; set; }

        public List<string> atkMoves = new List<string>();
        public List<int> maxPP = new List<int>();
        public List<int> curPP = new List<int>();

        public Pokemon()
        {
        }
    }
}
