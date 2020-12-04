using System;

namespace MyDSLTestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cake AmericanCheesecake = new CakeBuilder()
                .Name("American Cheesecake")
                .AddIngredient("Unbehandelte Zitrone", 1, Unit.NumberOfPieces)
                .AddIngredient("Butterkekse", 100, Unit.Gram)
                .AddIngredient("Butter", 35, Unit.Gram)
                .AddIngredient("Frischkäse", 300, Unit.Gram)
                .AddIngredient("Sahnequark", 500, Unit.Gram)
                .AddIngredient("Bourbon-Vanillezucker", 1, Unit.NumberOfPieces)
                .AddIngredient("Bourbon-Zucker", 120, Unit.Gram)
                .AddIngredient("Mehl", 50, Unit.Gram)
                .AddCookingStep("Für den Boden Zitrone heiß abspülen, trocken reiben und die Schale fein abreiben. Butterkekse grob zerbröckeln und in einer Küchenmaschine oder einem Mixer fein zermahlen. Butter bei schwacher Hitze in einem Topf schmelzen lassen. Topf vom Herd ziehen, Keksbrösel sowie 1⁄2 TL Zitronen­schale zur Butter geben und gründlich ein­rühren. Alles mit den Händen oder den Knethaken des Handrührgeräts gleichmäßig krümelig durcharbeiten.")
                .AddCookingStep("Den Boden einer Springform (Ø 24–26 cm) mit Backpapier auslegen. Die Krümel­-Butter­-Mischung darin gleichmäßig verteilen und leicht andrücken. Ofen auf 180 Grad vorhei­zen (Umluft: 160).")
                .AddCookingStep("Für die Creme Zitrone halbieren und aus­pressen. Frischkäse, Sahnequark, 3 EL Zitro­nensaft, übrige Zitronenschale, Vanillezucker und Zucker in eine Rührschüssel geben. Mit einem Schneebesen oder Handrührgerät zu einer glatten Creme verquirlen. Mehl in ein feines Sieb geben, gleichmäßig über die Creme sieben und gründlich unterrühren.")
                .AddCookingStep("Cheesecake­-Creme auf den Boden füllen und glatt streichen.")
                .AddCookingStep("Kuchen aus dem Backofen nehmen und in der Form auf einem Kuchengitter vollständig auskühlen lassen. Dann den Cheesecake in der Form mindestens zwei Stunden im Kühl­schrank gut durchkühlen lassen.")
                .AddCookingStep("Zum Servieren den Cheesecake vorsichtig mit einem Messer vom Formrand lösen, auf eine Tortenplatte setzen und anrichten.")
                .Build();

            Console.WriteLine(AmericanCheesecake.GetFormatedRecipe());
        }
    }
}
