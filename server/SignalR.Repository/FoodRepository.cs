using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SignalR.Entities;

namespace SignalR.Repository
{
    public class FoodRepository : IFoodRepository
    {

        public static List<Food> FoodArray = new List<Food>() {
                new Food()
                {
                    FoodName = "Bandeja Paisa",
                    FoodDescription = "Bandeja paisa, (Paisa refers to a person from the Paisa Region and bandeja is Spanish for platter) with variations known as bandeja de arriero, bandeja montañera, or bandeja antioqueña, is a typical meal popular in Colombian cuisine, especially of the Antioquia department and the Paisa Region, as well as with the Colombian Coffee-Growers Axis, (Caldas Department, Quindío, Risaralda) and part of Valle del Cauca.",
                    FoodImage = "http://s3-us-west-2.amazonaws.com/media.elpasajero.metro.net/wp-content/uploads/2011/12/10055650/img_94842.jpg",
                    FoodCountry = "Colombia",
                    FoodStar = 0,
                },
                new Food()
                {
                    FoodName = "Pizza Napoletana",
                    FoodDescription = "is a style of pizza made with tomatoes and mozzarella cheese. It must be made with San Marzano tomatoes, which grow on the volcanic plains to the south of Mount Vesuvius, and Mozzarella di Bufala Campana, a protected designation of origin cheese made with the milk from water buffalo raised in the marshlands of Campania and Lazio in a semi-wild state. Neapolitan pizza is a Traditional Speciality Guaranteed (TSG) product in Europe, and the art of its making is included on UNESCO's list of intangible cultural heritage. This style pizza gave rise to the New York-style pizza that was first made by Italian immigrants to the United States in the early 20th century.",
                    FoodImage = "https://eutourism.org/wp-content/uploads/2017/04/Pizza-Napoletana.jpg",
                    FoodCountry = "Italy",
                    FoodStar = 0,
                },
                new Food()
                {
                    FoodName = "Hot Dog",
                    FoodDescription = "A hot dog (also spelled hotdog), also known as a frankfurter (sometimes shortened to frank), dog, or wiener, is a cooked sausage, traditionally grilled or steamed and served in a partially sliced bun.[2][3][4][5] It is a type of sausage sandwich. Typical garnishes include mustard, ketchup, onions, mayonnaise, relish, coleslaw, cheese, chili, olives, and sauerkraut. Hot dog variants include the corn dog and pig in a blanket. The hot dog's cultural traditions include the Nathan's Hot Dog Eating Contest and the Oscar Mayer Wienermobile. This type of sausage was culturally imported from Germany and popularized in the United States, where it became a working-class street food sold at hot dog stands and carts. The hot dog became closely associated with baseball and American culture. Hot dog preparation and condiments vary regionally in the US. Although particularly connected with New York City and New York City cuisine, the hot dog eventually became ubiquitous throughout the US during the 20th century, and emerged as an important part of other regional cuisines (notably Chicago street cuisine).",
                    FoodImage = "https://media1.s-nbcnews.com/j/newscms/2017_41/1288823/giada-hot-dog-today-tease-171013_cc8ea08d065ebe92133af1c5cd1c868e.today-inline-large.jpg",
                    FoodCountry = "Germany",
                    FoodStar = 0,
                },
                new Food()
                {
                    FoodName = "Hamburger",
                    FoodDescription = "A hamburger, beefburger or burger is a sandwich consisting of one or more cooked patties of ground meat, usually beef, placed inside a sliced bread roll or bun. The patty may be pan fried, grilled, or flame broiled. Hamburgers are often served with cheese, lettuce, tomato, bacon, onion, pickles, or chiles; condiments such as mustard, mayonnaise, ketchup, relish, or 'special sauce'; and are frequently placed on sesame seed buns. A hamburger topped with cheese is called a cheeseburger. The term 'burger' can also be applied to the meat patty on its own, especially in the UK where the term 'patty' is rarely used, or the term can even refer simply to ground beef. The term may be prefixed with the type of meat or meat substitute used, as in 'turkey burger', 'bison burger', or 'veggie burger'.",
                    FoodImage = "https://media.istockphoto.com/photos/hamburger-with-fries-picture-id617364554?k=6&m=617364554&s=612x612&w=0&h=BifDNyNdMMMPvE3q9MX3PmBPmmIfG_9v5jbarS7vHLo=",
                    FoodCountry = "Germany",
                    FoodStar = 0,
                },
                new Food()
                {
                    FoodName = "Lasagne",
                    FoodDescription = "Lasagne originated in Italy during the Middle Ages and has traditionally been ascribed to the city of Naples. The first recorded recipe was set down in the early 14th century Liber de Coquina (The Book of Cookery).[3] It bore only a slight resemblance to the later traditional form of lasagne, featuring a fermented dough, flattened into a thin sheet, boiled, sprinkled with cheese and spices, and then eaten with the use of a small pointed stick.[4] Other recipes written in the century following the Liber de Coquina recommended boiling the pasta in a chicken broth and dressing it with cheese and chicken fat, or in one case walnuts, in a recipe adapted for the Lenten fast.[4]",
                    FoodImage = "https://images-gmi-pmc.edge-generalmills.com/9dd2e32b-613d-4515-9597-39ba6ad86b8b.jpg",
                    FoodCountry = "Italy",
                    FoodStar = 0,
                }
           };

        public async Task<List<Food>> FoodList()
            => await Task.Run(() => FoodArray );
    }
}

