using BFC.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Controller
{
    public static class Calculate
    {
        /// <summary>
        /// Определяет все принятные параметры и вычисляет конечные значения суточного потребления калорий
        /// </summary>
        /// <returns>суточное потребление</returns>
        public static string GetCalculateCalories(bool sex, double age, double weight, double height, Activity activity, Plan plan, EFormula formula)
        {
            var coef = PhysicalActivity.GetCoefficient(activity);
            int preplanResult = formula switch
            {
                EFormula.HarrisBenedict => (int)Formula.HarrisBenedict(sex, weight, height, age, coef),
                EFormula.MifflinSanGeora => (int)Formula.MifflinSanGeora(sex, weight, height, age, coef),
                _ => throw new Exception("Formula wasn't chosen"),
            };

            var result = plan switch
            {
                Plan.loss => $"{(int)(preplanResult * 0.85)}-{preplanResult}",
                Plan.maintaining => $"{preplanResult}",
                Plan.gain => $"{preplanResult}-{(int)(preplanResult * 1.15)}",
                _ => throw new Exception("Plan wasn't chosen"),
            };

            return result;
        }

        /// <summary>
        /// Расчитывает количество калорий по продукту
        /// </summary>
        /// <param name="weight">вес в граммах</param>
        /// <param name="calories">калорийность на 100 гр.</param>
        /// <returns></returns>
        public static string GetProductCalories(double weight, double calories)
        {
            return (weight * calories / 100.0).ToString();
        }
    }
}
