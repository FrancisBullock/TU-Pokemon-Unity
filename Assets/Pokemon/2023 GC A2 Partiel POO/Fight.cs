
using System;

namespace _2023_GC_A2_Partiel_POO.Level_2
{
    public class Fight
    {
        public Fight(Character character1, Character character2)
        {
            Character1 = character1;
            Character2 = character2;
        }

        public Character Character1 { get; }
        public Character Character2 { get; }
        /// <summary>
        /// Est-ce la condition de victoire/défaite a été rencontré ?
        /// </summary>
        public bool IsFightFinished => Character1.CurrentHealth <= 0 || Character2.CurrentHealth <= 0; 
        //public bool IsFightFinished => throw new NotImplementedException();
        /*public bool IsFightFinished(Character character1,Character character2)
        {
            bool r = false;
            if(character1.CurrentHealth<=0||character2.CurrentHealth<=0)
            {
                r = true;
            }
            return true;
        }//*/
        /// <summary>
        /// Jouer l'enchainement des attaques. Attention à bien gérer l'ordre des attaques par apport à la speed des personnages
        /// </summary>
        /// <param name="skillFromCharacter1">L'attaque selectionné par le joueur 1</param>
        /// <param name="skillFromCharacter2">L'attaque selectionné par le joueur 2</param>
        /// <exception cref="ArgumentNullException">si une des deux attaques est null</exception>
        public void ExecuteTurn(Skill skillFromCharacter1, Skill skillFromCharacter2)
        {
            throw new NotImplementedException();
            Random aleatoire = new Random();
            int a=aleatoire.Next(2);
            bool alreadyattacked = false;
            if(Character1.Speed>Character2.Speed||(Character1.Speed >= Character2.Speed&&a==1))
            {
                Character2.ReceiveAttack(skillFromCharacter1);
                alreadyattacked = true;
            }
            if (Character2.CurrentHealth >= 0)
            {
                Character1.ReceiveAttack(skillFromCharacter2);
            }
            if(alreadyattacked==false&&Character1.CurrentHealth>=0)
            {
                Character2.ReceiveAttack(skillFromCharacter1);
            }
        }

    }
}
