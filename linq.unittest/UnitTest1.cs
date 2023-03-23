using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using linq.data;

namespace linq.unittest
{
    public class Tests
    {
        [SetUp]
        public void Setup() {
            
        }

        /*
         * 1.1) Beispiel: Ermitteln Sie alle Gerichte die weniger
         *      als 400 Kalorien haben. Geben Sie die Namen der
         *      entsprechenden Gerichte aus.
         * 
         */
        [Test]
        public void getDishByCalories() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes where d.Calories < 400 select d;
            Assert.AreEqual(2, query.Count());
        }

        /*
         * 1.2) Beispiel: Ermitteln Sie die Fisch- und Fleischgerichte, die nicht
         *      mit einem A beginnen.
         *
         *      Geben Sie die Namen der entsprechenden Gerichte aus. Sortieren Sie
         *      das Ergebnis nach den Namen der Gerichte.
         */
        [Test]
        public void getDishByDishType() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes where d.Name[0].ToString().Equals("R") select d;

            Assert.AreEqual(2, query.Count());
        }

        /*
         * 1.3) Beispiel: Ermitteln Sie alle Gerichte die mehr als
         *      7 Zutaten haben. Geben Sie die Namen der Gerichte aus.
         */
        [Test]
        public void CalculateMaxCalorieLevel2() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes where d.Ingredients.Count() > 7 select d;

            Assert.AreEqual(5, query.Count());
        }

        /*
         * 1.4) Beispiel: Ermitteln Sie alle Gerichte die Pilze als Zutat beinhalten.
         */
        [Test]
        public void CalculateMaxCalorieLevel3() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes where d.Ingredients.Contains(EIngredient.MUSHROOM) select d;

            Assert.AreEqual(2, query.Count());
        }

        /*
         * 1.5) Beispiel: Berechnen Sie die Anzahl der Kalorien aller Fleischgerichte.
         */
        [Test]
        public void CalculateMaxCalorieLevel() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes where d.Type.Equals(EDishType.MEAT) select d;

            var calorieCount = 0;
            foreach (var dish in query)
            {
                calorieCount += dish.Calories;
            }
            Assert.AreEqual(1600, calorieCount);
        }

        /*
         * 1.6) Beispiel: Gruppieren Sie die Gerichte nach ihrem Typ. Geben
         *      Sie die gruppierten Gerichte zurück
         * 
         */
        [Test]
        public void GroupDishByType() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes group d by d.Type;

            foreach (var group in query) {
                Assert.IsTrue(Array.IndexOf(Enum.GetValues(typeof(EDishType)), group.Key) > -1);
            }
        }


        /*
         * 1.7) Beispiel: Berechnen Sie die Anzahl der Elemente für jede DishTyp Gruppe.
         *                
         */
        [Test]
        public void GroupDishByTypeCountingElements() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes group d by d.Type;

            foreach (var type in query)
            {
                Console.Write($"{type.Key}: {type.Count()} (");

                foreach (var dish in type)
                {
                    Console.Write($" {dish.Name},");
                }
                Console.WriteLine(" )");
            }
        }

        /*
         * 1.8) Beispiel: Welche Zutaten befinden sich in jedem Gericht?
         *      Geben Sie die Zutaten geordnet nach ihrem Namen aus.
         *                
         */
        [Test]
        public void CommonIngredient() {
            List<Dish> dishes = DataRepository.CreateDishes();

            var query = from d in dishes select d;
            foreach (var dish in query)
            {
                Console.Write($"{dish.Name}: ");
                var x = dish.Ingredients.OrderBy(x => x.ToString()).ToList();
                foreach (var ingredient in x)
                {
                    Console.Write($"{ingredient} ");
                }
                Console.WriteLine();
            }
        }
    }
}