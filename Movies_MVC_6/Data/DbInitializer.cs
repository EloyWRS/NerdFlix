using Movies_MVC_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_MVC_6.Data
{
    public class DbInitializer
    {



        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();
            if (context.Movies.Any())
            {
                return; //bd has been seeded
            }
        }
    }
}



    //        var awardInception = new Award[]
    //        {
    //            new Award(){Type = "Best Cinematography", Movies = }
    //        //    Award a1 = new () {  Type = "Best Cinematography" }
    //        //context.Awards.Add(a1);
    //        //context.SaveChanges();
    //        //Award a2 = new() { Type = "Best Sound Editing" };
    //        //context.Awards.Add(a2);
    //        //context.SaveChanges();
    //        //Award a3 = new() { Type = "Best Sound Mixing" };
    //        //context.Awards.Add(a3);
    //        //context.SaveChanges();
    //        //Award a4 = new() { Type = "Best Visual Effects" };
    //        //context.Awards.Add(a4);
    //        //context.SaveChanges();
    //        };

    //        Movie m1 = new()
    //        {
    //            MovieID = 1,
    //            Name = "Inception",
    //            //Awards = new List<Award> { a1, a2, a3, a4 },
    //            BoxOffice = "$836.8 million USD",
    //            Cinematography = "Wally Pfister",
    //            FeaturedSong = "S.T.A.Y.",
    //            Director = "Christopher Nolan",
    //            Sinopse = "Dom Cobb is a thief with the rare ability to enter people's dreams and steal their secrets from their subconscious His skill has made him a hot commodity in the world of corporate espionage but has also cost him everything he loves. Cobb gets a chance at redemption when he is offered a seemingly impossible task: Plant an idea in someone's mind. If he succeeds, it will be the perfect crime, but a dangerous enemy anticipates Cobb's every move.",
    //            YoutubeLink = "https://www.youtube.com/embed/YoHD9XEInc0"
    //        };
    //        context.Movies.Add(m1);
    //        context.SaveChanges();
    //        Award a5 = new Award { AwardID = 5, Type = "Best Actor in Leading Role" };
    //        context.SaveChanges();
    //        Award a6 = new Award { AwardID = 6, Type = "Best Actor in Supporting Role" };
    //        context.SaveChanges();
    //        Award a7 = new Award { AwardID = 7, Type = "Best Actress in Leading Role" };
    //        context.SaveChanges();
    //        Award a8 = new Award { AwardID = 8, Type = "Best Actress in Supporting Role" };
    //        context.SaveChanges();
    //        Award a9 = new Award { AwardID = 9, Type = "Best Adapted Screenplay" };
    //        context.SaveChanges();
    //        Award a10 = new Award { AwardID = 10, Type = "Best Animated Feature" };
    //        context.SaveChanges();
    //        Award a11 = new Award { AwardID = 11, Type = "Best Animated Short Film" };
    //        context.SaveChanges();
    //        Award a12 = new Award { AwardID = 12, Type = "Best Art Direction" };
    //        context.SaveChanges();
    //        Award a13 = new Award { AwardID = 13, Type = "Best Costume Design" };
    //        context.SaveChanges();
    //        Award a14 = new Award { AwardID = 14, Type = "Best Director" };
    //        context.SaveChanges();
    //        Award a15 = new Award { AwardID = 15, Type = "Best Documentary Feature" };
    //        context.SaveChanges();
    //        Award a16 = new Award { AwardID = 16, Type = "Best Documentary Short Subject" };
    //        context.SaveChanges();
    //        Award a17 = new Award { AwardID = 17, Type = "Best Film Editing" };
    //        context.SaveChanges();
    //        Award a18 = new Award { AwardID = 18, Type = "Best Foreign Language Film" };
    //        context.SaveChanges();
    //        Award a19 = new Award { AwardID = 19, Type = "Best Makeup" };
    //        context.SaveChanges();
    //        Award a20 = new Award { AwardID = 20, Type = "Best Original Score" };
    //        context.SaveChanges();
    //        Award a21 = new Award { AwardID = 21, Type = "Best Original Screenplay" };
    //        context.SaveChanges();
    //        Award a22 = new Award { AwardID = 22, Type = "Best Original Song" };
    //        context.SaveChanges();
    //        Award a23 = new Award { AwardID = 23, Type = "Best Original Story" };
    //        context.SaveChanges();
    //        Award a24 = new Award { AwardID = 24, Type = "Best Picture" };
    //        context.SaveChanges();

    //    };

    //    var movies = new Movie[]
    //    {

    //    }
    //    }
    //    }
    //}


