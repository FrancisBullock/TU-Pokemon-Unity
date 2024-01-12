
using System;

namespace _2023_GC_A2_Partiel_POO.Level_2
{
    /// <summary>
    /// Définition des types dans le jeu
    /// </summary>
    public enum TYPE { NORMAL, WATER, FIRE, GRASS,NONE }

    public class TypeResolver
    {

        /// <summary>
        /// Récupère le facteur multiplicateur pour la résolution des résistances/faiblesses
        /// WATER faible contre GRASS, resiste contre FIRE
        /// FIRE faible contre WATER, resiste contre GRASS
        /// GRASS faible contre FIRE, resiste contre WATER
        /// </summary>
        /// <param name="attacker">Type de l'attaque (le skill)</param>
        /// <param name="receiver">Type de la cible</param>
        /// <returns>
        /// Normal returns 1 if attacker or receiver
        /// 0.8 if resist
        /// 1.0 if same type
        /// 1.2 if vulnerable
        /// </returns>
        ///  J'ai décidé d'appliquer les vrai facteurs de la série
        public static float GetFactor(TYPE attacker, TYPE receiver , TYPE receiver2)//Prise en compte des doubles types
        {
            float r = 1;
            TYPE[] typeR = new TYPE[2];
            typeR[0] = receiver;
            typeR[1] = receiver;
            for (int t = 0; t < 2; t++)
            {
                if (attacker == TYPE.WATER)
                {
                    if (typeR[t] == TYPE.FIRE)
                    {
                        r *= 2.0f;
                    }
                    else if (typeR[t] == TYPE.WATER || typeR[t] == TYPE.GRASS)
                    {
                        r *= 0.5f;
                    }

                }
                if (attacker == TYPE.FIRE)
                {
                    if (typeR[t] == TYPE.GRASS)
                    {
                        r *= 2.0f;
                    }
                    else if (typeR[t] == TYPE.WATER || typeR[t] == TYPE.FIRE)
                    {
                        r *= 0.5f;
                    }

                }
                if (attacker == TYPE.GRASS)
                {
                    if (typeR[t] == TYPE.WATER)
                    {
                        r *= 2.0f;
                    }
                    else if (typeR[t] == TYPE.FIRE || typeR[t] == TYPE.GRASS)
                    {
                        r *= 0.5f;
                    }

                }
            }
            return r;
        }

    }
}
