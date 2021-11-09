using System.Collections.Generic;
using System.Transactions;

namespace linq.data
{
    public class DataRepository {
        public static List<Dish> CreateDishes() {
            List<Dish> dishes = new List<Dish>() {
                new Dish("Tomatensuppe", 300, EDishType.VEGETARIAN,
                    new List<EIngredient>() {
                        EIngredient.TOMATOE, EIngredient.ONION, EIngredient.SALT, EIngredient.WATER, EIngredient.CREAM,
                        EIngredient.PEPPER
                    }),
                new Dish("Kürbiscremesuppe", 350, EDishType.VEGETARIAN,
                    new List<EIngredient>() {
                        EIngredient.SALT, EIngredient.BROTH, EIngredient.ONION, EIngredient.CREAM, EIngredient.CARROT,
                        EIngredient.GARLIC, EIngredient.PEPPER, EIngredient.PUMPKIN, EIngredient.CELERY
                    }),

                new Dish("Wiener Schnitzel", 400, EDishType.MEAT,
                    new List<EIngredient>() {
                        EIngredient.VEAL, EIngredient.BREAD_CRUMBS, EIngredient.FLOUR, EIngredient.EGG,
                        EIngredient.MILK, EIngredient.BUTTER, EIngredient.LEMON, EIngredient.SALT
                    }),
                new Dish("Risotto", 530, EDishType.VEGETARIAN,
                    new List<EIngredient>() {
                        EIngredient.OIL, EIngredient.MUSHROOM, EIngredient.SHALLOT, EIngredient.SALT,
                        EIngredient.PEPPER, EIngredient.WINE, EIngredient.BROTH, EIngredient.BUTTER, EIngredient.CHIVES,
                        EIngredient.CHEESE
                    }),
                new Dish("Carbonara", 650, EDishType.MEAT,
                    new List<EIngredient>() {
                        EIngredient.PASTA, EIngredient.SALT, EIngredient.BACON, EIngredient.BROTH, EIngredient.EGG_YOLK,
                        EIngredient.PEPPER, EIngredient.PARMESAN_CHEESE
                    }),
                new Dish("Mushroom Pasta", 400, EDishType.VEGETARIAN,
                    new List<EIngredient>() {
                        EIngredient.PASTA, EIngredient.PEPPER, EIngredient.SALT, EIngredient.BROTH, EIngredient.CREAM,
                        EIngredient.CREAM, EIngredient.GARLIC, EIngredient.PARMESAN_CHEESE, EIngredient.MUSHROOM
                    }),
                new Dish("Cordon Bleu", 550, EDishType.MEAT, new List<EIngredient>() {
                    EIngredient.VEAL, EIngredient.EGG, EIngredient.OIL, EIngredient.BREAD_CRUMBS, EIngredient.BUTTER, EIngredient.CHEESE, EIngredient.BACON, EIngredient.SALT, EIngredient.PEPPER
                }),
            };

            return dishes;
        }

        public static List<Trader> CreateTrader() {
            List<Trader> traders = new List<Trader>() {
                new Trader("Peppi",ECities.VIENNA),
                new Trader("Gustaf",ECities.VIENNA),
                new Trader("Abdul",ECities.VIENNA),
                new Trader("Luka",ECities.MILAN),
                new Trader("Enzo", ECities.MILAN),
                new Trader("Gianni", ECities.MILAN),
                new Trader("Romeo",ECities.MILAN),
                new Trader("Fabricio",ECities.MILAN),
                new Trader("Alan", ECities.LONDON),
                new Trader("Eric",ECities.LONDON),
            };

            return traders;
        }

        public static List<Transaction> CreateTransactions() {
            List<Trader> traders = CreateTrader();
            
            List<Transaction> transactions = new List<Transaction>() {
                new Transaction(traders[0], 2020, 50000),
                new Transaction(traders[0], 2020,340000),
                new Transaction(traders[0], 2020,210000),
                new Transaction(traders[0], 2019,20000),
                new Transaction(traders[0], 2019,10000),
                new Transaction(traders[1], 2019,450000),
                new Transaction(traders[2], 2019,100),
                new Transaction(traders[3], 2018,320000),
                new Transaction(traders[3], 2020,560000),
                new Transaction(traders[3], 2020,230000),
                new Transaction(traders[3], 2020,120000),
                new Transaction(traders[3], 2019,560000),
                new Transaction(traders[6], 2019,430000),
                new Transaction(traders[6], 2020,110000),
                new Transaction(traders[6], 2020,320000),
                new Transaction(traders[6], 2019,350000),
                new Transaction(traders[7], 2020,120000),
                new Transaction(traders[7], 2020,560000),
                new Transaction(traders[7], 2020,230000),
                new Transaction(traders[7], 2018,120000)
            };

            return transactions;
        }
    }
}