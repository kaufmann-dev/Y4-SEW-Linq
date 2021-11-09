using NUnit.Framework;
using System;

namespace linq.unittest
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

        var query = from
        //Assert.AreEqual(2, query.Count());
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



        Assert.AreEqual(3, query.Count());
    }

    /*
     * 1.3) Beispiel: Ermitteln Sie alle Gerichte die mehr als
     *      7 Zutaten haben. Geben Sie die Namen der Gerichte aus.
     */
    [Test]
    public void CalculateMaxCalorieLevel2() {
        List<Dish> dishes = DataRepository.CreateDishes();


        Assert.AreEqual(5, query.Count());
    }

    /*
     * 1.4) Beispiel: Ermitteln Sie alle Gerichte die Pilze als Zutat beinhalten.
     */
    [Test]
    public void CalculateMaxCalorieLevel3() {
        List<Dish> dishes = DataRepository.CreateDishes();

  
        Assert.AreEqual(2, query.Count());
    }

    /*
     * 1.5) Beispiel: Berechnen Sie die Anzahl der Kalorien aller Fleischgerichte.
     */
    [Test]
    public void CalculateMaxCalorieLevel() {
        List<Dish> dishes = DataRepository.CreateDishes();

      
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



        foreach (var row in query) {
            Console.WriteLine($"{row.Key} {row.Count}");
        }
        
        Assert.AreEqual(2, query.Count());
    }

    /*
     * 1.8) Beispiel: Welche Zutaten befinden sich in jedem Gericht?
     *      Geben Sie die Zutaten geordnet nach ihrem Namen aus.
     *                
     */
    [Test]
    public void CommonIngredient() {
        List<Dish> dishes = DataRepository.CreateDishes();



        foreach (var ingredient in query) {
            Console.WriteLine(ingredient);
        }
        
        Assert.AreEqual(1, query.Count());
    }
}