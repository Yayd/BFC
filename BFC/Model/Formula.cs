using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model
{
    public enum EFormula
    {
        MifflinSanGeora,
        HarrisBenedict
    }

    static class Formula
    {
        /// <summary>
        /// Формула расчета Миффлина - Сан-Жеора
        /// </summary>
        /// <param name="sex">пол 0 - жен., 1 - муж.</param>
        /// <param name="weight">вес в килограммах</param>
        /// <param name="height">рост в сантиметрах</param>
        /// <param name="age">возраст в годах</param>
        /// <param name="coef">коэффициент физической активности</param>
        /// <returns>необходимое суточное количество калорий</returns>
        public static double MifflinSanGeora(bool sex, double weight, double height, double age, double coef)
        {
            var formula = (10.0 * weight) + (6.25 * height) - (5.0 * age);
            var result = sex ? formula + 5 : formula - 161;

            result = Min(result, sex);

            return result * coef;
        }

        /// <summary>
        /// Формула расчета Харриса-Бенедикта
        /// </summary>
        /// <param name="sex">пол 0 - жен., 1 - муж.</param>
        /// <param name="weight">вес в килограммах</param>
        /// <param name="height">рост в сантиметрах</param>
        /// <param name="age">возраст в годах</param>
        /// <param name="coef">коэффициент физической активности</param>
        /// <returns>необходимое суточное количество калорий</returns>
        public static double HarrisBenedict(bool sex, double weight, double height, double age, double coef)
        {
            double formula;
            if (sex)
            {   //для мужчин
                formula = 447.593 + (9.247 * weight) + (3.098 * height) - (4.330 * age);
            }
            else
            {   //для женщин
                formula = 88.362 + (13.397 * weight) + (4.799 * height) - (5.677 * age);
            }

            var result = Min(formula, sex);

            return result * coef;
        }

        /// <summary>
        /// Нельзя снижать количество потребляемых калорий ниже 1200 для женщин и 1400 для мужчин
        /// </summary>
        /// <param name="calories">суточная норма калорий</param>
        /// <param name="sex">пол 0 - жен., 1 - муж.</param>
        /// <returns></returns>
        private static double Min(double calories, bool sex)
        {
            //пороговое значение калорий в сутки
            var min = sex ? 1400.0 : 1200.0;
            //калибровка
            var result = Math.Max(calories, min);
            return result;
        }
    }
}
