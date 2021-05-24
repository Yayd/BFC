using System;
using System.Collections.Generic;
using System.Text;

namespace BFC.Model
{
    public enum Activity
    {
        none,
        low,
        upperlow,
        medium,
        uppermedium,
        hight,
        extrahight
    }

    public static class PhysicalActivity
    {
        private readonly static Dictionary<Activity, double> coefficients = 
            new Dictionary<Activity, double>
        {
            [Activity.none] = 1.2,
            [Activity.low] = 1.38,
            [Activity.upperlow] = 1.46,
            [Activity.medium] = 1.55,
            [Activity.uppermedium] = 1.64,
            [Activity.hight] = 1.73,
            [Activity.extrahight] = 1.9
        };

        /// <summary>
        /// Получить коэффициент ежедневной активности
        /// </summary>
        /// <param name="activity"></param>
        /// <returns></returns>
        public static double GetCoefficient(Activity activity)
        {
            return coefficients[activity];
        }
    }
}
