﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private string flourType;
        private string bakingTechnique;
        private double weight;
        private double calories;

        private Dictionary<string, double> flourTypes = new Dictionary<string, double>()
        {
            ["white"] = 1.5,
            ["wholegrain"] = 1.0,         
        };

        private Dictionary<string, double> bakingTechniques = new Dictionary<string, double>()
        {
            ["crispy"] = 0.9,
            ["chewy"] = 1.1,
            ["homemade"] = 1.0
        };

        public Dough(string flourType, string bakingTechnique, double grams)
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = grams;
            Calories = grams * 2 * flourTypes[flourType.ToLower()] * bakingTechniques[bakingTechnique.ToLower()];
        }

        public string FlourType
        {
            get { return this.flourType; }
            private set
            {
                if (!flourTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }

        public string BakingTechnique
        {
            get { return bakingTechnique; }
            private set
            {
                if (!bakingTechniques.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if(value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                this.weight = value;
            }
        }

        public double Calories
        {
            get { return this.calories; }
            private set
            {
                this.calories = value;
            }
        }

    }
}
