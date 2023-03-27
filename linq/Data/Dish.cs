using System.Collections.Generic;
using linq.data;

namespace linq.Data
{
    public class Dish {

        private readonly string _name;

        private readonly int _calories;

        private readonly EDishType _type;

        private readonly List<EIngredient> _ingredients;

        public Dish(string name, int calories, EDishType type, List<EIngredient> ingredients) {
            _name = name;
            _calories = calories;
            _type = type;
            _ingredients = ingredients;
        }

        public string Name => _name;

        public int Calories => _calories;

        public EDishType Type => _type;

        public List<EIngredient> Ingredients => _ingredients;
    }
}