using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionApp
{
    public static class TrailRepository
    {
        private static List<Trail> _trails = new()
        {
            new Trail(3,
                "https://maps.app.goo.gl/s17U1PGLk7f1Jdpb6",
                "https://www.tripadvisor.com/UserReviewEdit-g188113-d18274593-Sato_Code_Treasure_Hunt_in_Zurich-Zurich.html",
                47.38618086259637d, 8.518162324619135d,
                "https://www.sato-code.com/images/trails/zurich/2/Escape-Room-Zurich-Icon-2.jpg","Zurich", "https://www.sato-code.com/it/escape-games/escape-room-zurich"),
           new Trail(6,
                "https://maps.app.goo.gl/TLq8o6iphcQVFHBf6",
                "https://www.tripadvisor.it/Attraction_Review-g188094-d23451336-Reviews-Sato_Code-Locarno_Lake_Maggiore_Canton_of_Ticino_Swiss_Alps.html",
                46.16932319839621d, 8.794786676467893d,
                "https://www.sato-code.com/images/trails/locarno/Escape-Room-Locarno-Icon.jpg","Locarno","https://www.sato-code.com/it/escape-games/escape-room-locarno"),
           new Trail(7,
                "https://maps.app.goo.gl/s17U1PGLk7f1Jdpb6",
                "https://www.tripadvisor.com/UserReviewEdit-g188113-d18274593-Sato_Code_Treasure_Hunt_in_Zurich-Zurich.html",
                47.38606175684952d, 8.517344162144575d,
                "https://www.sato-code.com/_next/image?url=%2Fimages%2Ftrails%2Fzurich%2F1%2FEscape-Room-Zurich-Icon-1.jpg&w=640&q=75","Zurich", "https://www.sato-code.com/it/escape-games/escape-room-zurich-2"),
           new Trail(8,
                "https://maps.app.goo.gl/QE8pWy1cWaGeXHZFA",
                "https://www.tripadvisor.it/Attraction_Review-g188095-d23099485-Reviews-Sato_Code-Lugano_Canton_of_Ticino_Swiss_Alps.html",
                46.0036090962525d, 8.95107207818188d,
                "https://www.sato-code.com/_next/image?url=%2Fimages%2Ftrails%2Flugano%2FEscape-Room-Lugano-Icon.jpg&w=640&q=75","Lugano", "https://www.sato-code.com/it/escape-games/escape-room-lugano"),
           new Trail(9,
                "https://maps.app.goo.gl/RNtUm3fXxc1YFVEe8",
                "https://www.tripadvisor.it/Attraction_Review-g188093-d21110069-Reviews-Sato_Code-Bellinzona_Canton_of_Ticino_Swiss_Alps.html",
                46.1930466145061d, 9.022030697795095d,
                "https://www.sato-code.com/images/trails/bellinzona/Escape-Room-Bellinzona-Icon.jpg","Bellinzona", "https://www.sato-code.com/it/escape-games/escape-room-bellinzona"),
           new Trail(10,
                "https://www.google.com/maps/place/Sato+Code/@47.1700539,8.5160808,17z/data=!4m8!3m7!1s0x479aabffa7371e29:0x1dc00007e32f8477!8m2!3d47.1700539!4d8.5160808!9m1!1b1!16s%2Fg%2F11s3qhyhrj?entry=ttu",
                "https://www.tripadvisor.com/UserReviewEdit-g188110-d25450750-Sato_Code_Treasure_Hunt_in_Zug-Zug.html",
                47.17005296148371d, 8.516083399139708d,
                "https://www.sato-code.com/_next/image?url=%2Fimages%2Ftrails%2Fzug%2FEscape-Room-Zug-Icon.jpg&w=640&q=75","Zug", "https://www.sato-code.com/it/escape-games/escape-room-zug"),
           new Trail(12,
                "https://maps.app.goo.gl/S8i8CwACBHMUcb8M8",
                "https://www.tripadvisor.it/AttractionProductReview-g187835-d25387740-Sato_Code_Escape_Room_across_Como-Como_Lake_Como_Lombardy.html",
                45.81247480679865d, 9.081614440344048d,
                "https://www.sato-code.com/images/trails/como/Escape-Room-Como-Icon.jpg","Como", "https://www.sato-code.com/it/escape-games/escape-room-como"),
          new Trail(13,
                "https://g.page/r/CYQJsKNF9zEhEAg/review",
                "https://www.tripadvisor.com/UserReviewEdit-g194942-d25466414-Sato_Code_Treasure_Hunt_in_Varese-Varese_Province_of_Varese_Lombardy.html",
                45.816747174142684d, 8.827224113590113d,
                "https://www.sato-code.com/images/trails/varese/Escape-Room-Varese-Icon.jpg","Varese", "https://www.sato-code.com/it/escape-games/escape-room-varese"),
           new Trail(14,
                "https://www.google.com/maps/place/Sato+Code+Bremgarten/@47.3506063,8.340507,17z/data=!3m1!4b1!4m6!3m5!1s0x479011cf2c603025:0x3b9770d59a9c367a!8m2!3d47.3506063!4d8.340507!16s%2Fg%2F11sshft41p?entry=ttu",
                "https://www.tripadvisor.com/UserReviewEdit-g1929705-d25132984-Sato_Code-Bremgarten_Canton_of_Aargau.html",
                47.3506044307323d, 8.340504396336925d,
                "https://www.sato-code.com/images/trails/bremgarten/Bremgarten-Escape-Room-Icon.jpg","Bremgarten", "https://www.sato-code.com/it/escape-games/escape-room-bremgarten"),
           new Trail(15,
                "https://maps.app.goo.gl/U1Jd5SS5x83ced636",
                "https://www.tripadvisor.com/UserReviewEdit-g187836-d25387739-Sato_Code_Treasure_Hunt_in_Lecco-Lecco_Province_of_Lecco_Lombardy.html",
               45.85573179637612d, 9.389641361423772d,
                "https://www.sato-code.com/images/trails/lecco/Escape-Room-Lecco-Icon.png","Lecco", "https://www.sato-code.com/it/escape-games/escape-room-lecco"),
           new Trail(16,
                "https://g.page/r/CQ_sXOKKKJ-HEAI/review",
                "https://www.tripadvisor.it/AttractionProductReview-g187830-d25387757-Sato_Code_Escape_Room_across_Bergamo_Alta-Bergamo_Province_of_Bergamo_Lombardy.html",
               45.697579984716754d, 9.665804591431577d,
                "https://www.sato-code.com/_next/image?url=%2Fimages%2Ftrails%2Fbergamo%2FEscape-Room-Bergamo-Icon.jpg&w=640&q=75","Bergamo", "https://www.sato-code.com/it/escape-games/escape-room-bergamo"),
           new Trail(17,
                "https://www.google.com/maps/place/Sato+Code+Brescia/@45.5377832,10.215888,17z/data=!4m8!3m7!1s0x4781776824ed8fdd:0x9ef030f235650f6b!8m2!3d45.5377832!4d10.2184629!9m1!1b1!16s%2Fg%2F11txrq6xfj?entry=ttu",
                "https://www.tripadvisor.com/UserReviewEdit-g194702-d25178700-Sato_Code-Brescia_Province_of_Brescia_Lombardy.html",
               45.53777845171689d, 10.218462503985705d,
                "https://www.sato-code.com/images/trails/brescia/Escape-Room-Brescia-Icon.jpg","Brescia", "https://www.sato-code.com/it/escape-games/escape-room-brescia"),
           new Trail(18,
                "https://g.page/r/Cf4cvgWmpUuqEBM/review",
                "https://www.tripadvisor.com/UserReviewEdit-g187850-d25564223-Private_Treasure_Hunt_in_Pavia-Pavia_Province_of_Pavia_Lombardy.html",
                45.18474357540363d, 9.154418006142398d,
                "https://www.sato-code.com/images/trails/pavia/Escape-Room-Pavia-Icon.jpg","Pavia", "https://www.sato-code.com/it/escape-games/escape-room-pavia"),
           new Trail(19,
                "https://g.page/r/CVD-UAq6IP3FEBM/review",
                //missTrip
                "https://www.tripadvisor.com/UserReviewEdit-g188113-d18274593-Sato_Code_Treasure_Hunt_in_Zurich-Zurich.html",
               45.409117782504765d, 11.88184585689627d,
                "https://www.sato-code.com/_next/image?url=%2Fimages%2Ftrails%2Fpadova%2F1%2FEscape-Room-Padova-DeepDesire-Icon.jpg&w=640&q=75","Padova", "https://www.sato-code.com/it/escape-games/escape-room-padova"),
           new Trail(20,
                "https://www.google.com/maps/place/Sato+Code+Padova/@45.3995126,11.8775316,17z/data=!4m8!3m7!1s0x477edb8bca2ebdbd:0x2e6001515ad64c60!8m2!3d45.3995126!4d11.8775316!9m1!1b1!16s%2Fg%2F11ss7yytdt?entry=ttu",
                "https://www.tripadvisor.it/Attraction_Review-g187867-d25428037-Reviews-Sato_Code_the_coolest_Escape_Room_across_Padua_self_guided-Padua_Province_of_Pad.html",
                45.39950814074322d, 11.877531734816625d,
                "https://www.sato-code.com/images/trails/padova/2/Escape-Room-Padova-Memmo-Icon.jpg","Padova", "https://www.sato-code.com/it/escape-games/escape-room-padova-2"),
           new Trail(21,
                "https://maps.app.goo.gl/2mhbCcVR1ojjcd426",
                "",//TODO: Missing Tripadvisor
                47.22547349369888d, 8.816589469549598d,
                "https://www.sato-code.com/images/trails/rapperswil/Escape-Room-Rapperswil-Icon.jpg","Rapperswill", "https://www.sato-code.com/it/escape-games/escape-room-rapperswil"),
            new Trail(22,
                "https://g.page/r/CRW00UAYs2jAEBM/review",
                "https://www.tripadvisor.it/UserReviewEdit-g187849-d25770859-Sato_Code_Treasure_Hunt_in_Milan-Milan_Lombardy.html",
               45.4512671618701d, 9.169265085618648d,
                "https://www.sato-code.com/images/trails/milano/1/Escape-Room-Milano-Navigli-Icon.jpg","Milano", "https://www.sato-code.com/it/escape-games/escape-room-milano"),
            new Trail(23,
                "https://maps.app.goo.gl/aqb6v6TmoXvZMpgQ6",
                "https://www.tripadvisor.it/Attraction_Review-g194783-d26251343-Reviews-Sato_Code-Iseo_Province_of_Brescia_Lombardy.html",
                45.66116205848963d, 10.049618955993932d,
                "https://www.sato-code.com/images/trails/iseo/Escape-Room-Iseo-Icon.jpg","Iseo", "https://www.sato-code.com/it/escape-games/escape-room-iseo"),
                
            new Trail(24,
                "https://maps.app.goo.gl/ynPdGbhx4EnSuJiv5",
                "https://www.tripadvisor.com/AttractionProductReview-g198865-d26455795-Sato_Code_Escape_Room_across_Ascona-Ascona_Lake_Maggiore_Canton_of_Ticino_Swiss_Al.html",
                46.15637412734469d, 8.770329279021174d,
                "https://www.sato-code.com/images/trails/ascona/Escape-Room-Ascona-Icon.jpg","Ascona", "https://www.sato-code.com/it/escape-games/escape-room-ascona"), 
              
            //new Trail(25,
            //    "",
            //    "",
            //    45.58699809823858d, 9.276053785413549d,
            //    "","Monza", ""),
         };


        public static Trail GetTrail(int id)
        {
            var trail = _trails.FirstOrDefault(t => t.Id == id);
            
            if(trail == null)
            {
                throw new Exception($"Trail with Id {id} is not in TrailRepository");
            }

            return trail;
        }


        public static List<Trail> GetTwoClosestGames(Trail trail)
        {
            Trail closest;
            Trail secondClosest;

            Trail[] trails = new Trail[_trails.Count];
            _trails.CopyTo(trails, 0);
            List<Trail> trailsByClosest = trails.Where((t) => t.Id != trail.Id).ToList();

            Dictionary<int, double> distCache = new Dictionary<int, double>();
            trailsByClosest.Sort((a, b) => {
                
                if(!distCache.TryGetValue(a.Id, out double da))
                {
                    da = Distance(a, trail);
                    distCache[a.Id] = da;
                }
                if (!distCache.TryGetValue(b.Id, out double db))
                {
                    db = Distance(b, trail);
                    distCache[b.Id] = db;
                }

                if (da < db) return -1; // a < b
                if (da > db) return 1; // a > b
                return 0; // a == b
            });

            closest = trailsByClosest[0];
            secondClosest = trailsByClosest.First(trail=> trail.City != closest.City);

           return new List<Trail> { closest, secondClosest };
        }

        public static double Distance(Trail trail1, Trail trail2)
        {
            var dLong = Math.Abs(trail1.Longitude - trail2.Longitude);
            var dLat = Math.Abs(trail1.Latitude - trail2.Latitude);

            return Math.Sqrt(Math.Pow(dLong, 2) + Math.Pow(dLat, 2));
        }

    }
}
