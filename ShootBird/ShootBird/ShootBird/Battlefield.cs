using ShootBird.Hero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootBird
{
    /// <summary>
    /// Поле сражения. Где герой и монтср просто стражаются.
    /// </summary>
    internal class Battlefield
    {
        private int heroHeals;
        private int enemyHeals;
        private int heroGunDamage;
        private int enemyDamage;
        private int heroExperience;
        private int enemyExperience;
        private int numberOfShot;
        private int numberOfRoundsInTheClip;

        public Battlefield(int initialHealthHero)
        {
            this.heroHeals = initialHealthHero;
            this.enemyHeals = 0;
            this.enemyDamage = 0;
            this.heroGunDamage = 0;
            this.enemyExperience = 0;
            this.heroExperience = 0;
            this.numberOfShot = 0;
            this.numberOfRoundsInTheClip = 0;
        }


        /// <summary>
        /// Начать битву героя и монстра
        /// </summary>
        public void StartTheBattle()
        {
            //Задаем колличество выстрелов
            int сartridge = HeroData.InputCartridge();
        }


        /// <summary>
        /// Результат сражения
        /// </summary>
        public void ResultOfTheBattle()
        {

        }

    }
}
