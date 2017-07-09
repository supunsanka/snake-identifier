using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeIdApp
{
    public class PredictSnake
    {
        List<SnakeBite> bites = new List<SnakeBite>();
        private static PredictSnake instance;

        private PredictSnake()
        {
            bites.Add(new SnakeBite("Cobra", Color.Empty, Color.Empty, Color.Red,
                ParamsToList("swelling and redness around the wounds", "Tissue necrosis"),
                ParamsToList("pain at the bite site", "difficulty breathing", "vomiting and nausea", "blurred vision", "sweating and salivating", "numbness in the face and limbs")));
            bites.Add(new SnakeBite("Russell's Viper", Color.Empty, Color.Empty, Color.Red, 
                ParamsToList("swelling and redness around the wounds"),
                ParamsToList("pain at the bite site", "Local Swelling", "vomiting and nausea", "Dizziness", "Acute renal failure", "dark urine", "incoagulable blood")));
            bites.Add(new SnakeBite("Krait", Color.Empty, Color.Empty, Color.Red,
                ParamsToList("swelling and redness around the wounds"),
                ParamsToList("pain at the bite site", "Local Swelling", "vomiting and nausea", "Dizziness", "Acute renal failure", "dark urine", "incoagulable blood")));
            bites.Add(new SnakeBite("Sea Snake", Color.Empty, Color.Empty, Color.Red,
                ParamsToList("swelling"),
                ParamsToList("Painful muscles", "Unable to move legs","Blurry Vision", "Vomitting", "Difficulaty Swallowing or Speaking", "Excessive saliva production")));
            bites.Add(new SnakeBite("Hump Nosed viper", Color.Empty, Color.Empty, Color.Red,
                ParamsToList("swelling", "bleeding", "pain", "skin grafting"),
                ParamsToList("Painful muscles", "Local hemorrhagic blister formation", "Induration", "Red urine", "spontaneous bleeding")));
            bites.Add(new SnakeBite("Saw Scaled viper", Color.Empty, Color.Empty, Color.Red,
                ParamsToList("swelling", "bleeding", "pain", "skin grafting"),
                ParamsToList("Vomiting", "Cogulopathy", "Induration", "spontaneous bleeding")));
        }

        public static PredictSnake GetInstance()
        {
            //Singleton
            if (instance == null)
            {
                instance = new PredictSnake();
            }

            return instance;
        }

        private static List<string> ParamsToList(params string[] items)
        {
            List<string> list = new List<string>();
            list.AddRange(items);
            return list;
        }



        public List<string> GetSnake(Color eye, Color tounge, Color wound, List<string> nature_of_swell, List<string> user_symptom)
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();

            foreach(SnakeBite bite in bites)
            {
                scores.Add(bite.GetSnake(), bite.GetScore(eye, tounge, wound, nature_of_swell, user_symptom));
            }
            var sortedScore = scores.ToList();
            sortedScore.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            List<string> mostProbable = new List<string>();

            int current_max = -1;

            foreach (var score in sortedScore)
            {
                if (current_max > score.Value)
                {
                    break;
                }
                else
                {
                    current_max = score.Value;
                    mostProbable.Add(score.Key);
                }
            }

            return mostProbable;
        }


        class SnakeBite
        {
            Color EyeColor;
            Color ToungeColor;
            Color Wound;
            string Snake;
            List<string> Symptoms;
            List<string> NatureOfSwell;

            public SnakeBite(string snake, Color eye, Color tounge, Color wound, List<string> nature_of_swell, List<string> symptoms)
            {
                this.Snake = snake;
                this.EyeColor = eye;
                this.ToungeColor = tounge;
                this.Wound = wound;
                this.Symptoms = symptoms;
                this.NatureOfSwell = nature_of_swell;
            }

            public int GetScore(Color eye, Color tounge, Color wound, List<string> nature_of_swell, List<string> symptoms)
            {
                int points = 0;
                if (this.EyeColor == eye && eye != Color.Empty)
                {
                    points += 10;
                }

                if (this.ToungeColor == tounge && tounge != Color.Empty)
                {
                    points += 10;
                }

                if (this.Wound == wound && wound != Color.Empty)
                {
                    points += 10;
                }

                foreach (string swell in nature_of_swell)
                {
                    foreach (string bite_swell in NatureOfSwell)
                    {
                        if (bite_swell.IndexOf(swell, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            points += 10;
                        }
                    }
                }

                foreach (string symptom in symptoms)
                {
                    foreach (string bite_symptom in Symptoms)
                    {
                        if (bite_symptom.IndexOf(symptom, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            points += 10;
                        }
                    }
                }
                return points;
            }

            public string GetSnake()
            {
                return Snake;
            }
        }
    }
}
