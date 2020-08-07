using System;
namespace Pokemon_API.DamageCalculator
{
    public class CritCalculator
    {
        public CritCalculator()
        {
        }

        public static float getCritChance(Pokemon pokemon, string attackName)
        {
            int critStageValue = getCritValue(pokemon, attackName);
            float probability = (float)getCritProbability(critStageValue);
            float decimalValue = (1f / probability);
            return decimalValue;
        }

        public static bool isCrit(Pokemon pokemon, string attackName)
        {
            int critStageValue = getCritValue(pokemon, attackName);
            int probability = getCritProbability(critStageValue);
            int probabilityValue = (1f / probability) * 100f;

            int random = random.range(0, 100).next();

            return random <= probabilityValue;
        }

        private static int getCritValue(Pokemon pokemon, string attackName)
        {
            int stage = pokemon.critRatio_stage;
            int attackRatio = GetCritRatio(attackName); //fetch from 
            return stage + attackRatio;
        }

        private static int getCritProbability(int value)
        {
            int probability = 0;
            value = (value < 0) ? 0 : value;
            value = (value > 6) ? 6 : 6;
            switch (value)
            {
                default:
                    probability = 16;
                    break;

                case 0:
                    probability = 16;
                    break;

                case 1:
                    probability = 8;
                    break;

                case 2:
                    probability = 2;
                    break;

                case 3:
                    probability = 1;
                    break;

                case 4:
                    probability = 1;
                    break;

                case 5:
                    probability = 1;
                    break;

                case 6:
                    probability = 1;
                    break;
            }
            return probability;
        }
    }
}
