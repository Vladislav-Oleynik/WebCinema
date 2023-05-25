using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCinema.Models;

namespace WebCinema.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "https://img.freepik.com/free-vector/theater-cinema-background_52683-1702.jpg?w=826&t=st=1685024689~exp=1685025289~hmac=4e265521070a393b91dea28dcd8f75f49b4777456fe6a361e30f9a672dbfc194",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "https://img.freepik.com/free-vector/super-cinema-background_52683-1698.jpg?w=826&t=st=1685024707~exp=1685025307~hmac=1704578a949a343239243649464caa241dbc5cfd3f79978ca17e47c90baacc48",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "https://img.freepik.com/free-vector/online-movies-entertainment-banner_1419-2246.jpg?w=1480&t=st=1685024730~exp=1685025330~hmac=a1aaf25ce513164398ed9feac54deee0f28869e7d872d1b03ca34ede2d186d1d",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "https://img.freepik.com/premium-vector/video-productions-logo_93835-49.jpg?w=826",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "https://img.freepik.com/free-vector/movie-time-neon-sign-sign_24908-55555.jpg?w=826&t=st=1685024762~exp=1685025362~hmac=fb3ad742d857cfd5f811db8d07651142530bda6eb7024281ca43efeaa1d6b411",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "MORGAN FREEMAN",
                            Bio = "Morgan Freeman (born June 1, 1937) is an American actor, producer, and narrator. He is known for his distinctive deep voice and various roles in a wide variety of film genres. Throughout his career spanning over five decades, he has received multiple accolades, including an Academy Award, a Screen Actors Guild Award, and a Golden Globe Award. He is the recipient of the Kennedy Center Honor in 2008, the AFI Life Achievement Award in 2011, the Cecil B. DeMille Award in 2012, and the Screen Actors Guild Life Achievement Award in 2018.",
                            ProfilePictureURL = "https://d3hjzzsa8cr26l.cloudfront.net/a9630480-6312-11e8-ba78-7d010a78ed44.jpg?zcw=619&zch=619&zct=0&zcl=251&pw=264"

                        },
                        new Actor()
                        {
                            FullName = "ROBIN WILLIAMS",
                            Bio = "Robin McLaurin Williams (July 21, 1951 – August 11, 2014) was an American actor and comedian. Known for his improvisational skills and the wide variety of characters he created on the spur of the moment and portrayed on film, in dramas and comedies alike, he is regarded as one of the greatest comedians of all time. He received numerous accolades including an Academy Award, two Primetime Emmy Awards, six Golden Globe Awards, two Screen Actors Guild Awards, and five Grammy Awards.",
                            ProfilePictureURL = "https://d3hjzzsa8cr26l.cloudfront.net/63554237-c682-11e8-8d12-4b6fc186e574.jpg?pw=264"
                        },
                        new Actor()
                        {
                            FullName = "BETTY WHITE",
                            Bio = "Betty Marion White (January 17, 1922 – December 31, 2021) was an American actress and comedian. A pioneer of early television with a career spanning almost seven decades, she was noted for her vast body of work in entertainment and for being one of the first women to work both in front of and behind the camera. She produced and starred in the sitcom Life with Elizabeth (1953–1955), making her the first woman to produce a sitcom.",
                            ProfilePictureURL = "https://d3hjzzsa8cr26l.cloudfront.net/b473a4bc-2b91-11e8-b1aa-c5c2b7095a19.jpg?pw=264"
                        },
                        new Actor()
                        {
                            FullName = "MICHAEL J. FOX",
                            Bio = "Michael Andrew Fox OC (born June 9, 1961), known professionally as Michael J. Fox, is a Canadian-American activist and retired actor. Beginning his career in the 1970s, he rose to prominence portraying Alex P. Keaton on the NBC sitcom Family Ties (1982–1989) and Marty McFly in the Back to the Future film trilogy (1985–1990). He went on to star in films such as Teen Wolf (1985), The Secret of My Success (1987), Casualties of War (1989), Doc Hollywood (1991), and The Frighteners (1996). Fox returned to television on the ABC sitcom Spin City in the lead role of Mike Flaherty (1996–2000).",
                            ProfilePictureURL = "https://d3hjzzsa8cr26l.cloudfront.net/5ff5aa67-2deb-11e8-b3cb-93bb6f97da1c.jpg?pw=264"
                        },
                        new Actor()
                        {
                            FullName = "DENZEL WASHINGTON",
                            Bio = "Denzel Hayes Washington Jr. (born December 28, 1954) is an American actor and filmmaker. In a career spanning over four decades, Washington has received numerous accolades, including a Tony Award, two Academy Awards, three Golden Globe Awards and two Silver Bears. In 2016, he received the Cecil B. DeMille Lifetime Achievement Award, and in 2020, The New York Times named him the greatest actor of the 21st century. In 2022, Washington received the Presidential Medal of Freedom bestowed upon him by President Joe Biden.",
                            ProfilePictureURL = "https://d3hjzzsa8cr26l.cloudfront.net/07afead8-2d03-11e6-8fa2-87887d182df9.jpg?pw=264"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Michael Mann",
                            Bio = "Mann was a student at London’s International Film School and began his career in the late 70s. Writing for TV shows such as Starsky and Hutch. He directed his first film in 1979, the award-winning prison drama The Jericho Mile. He is a great producer with his work on the U.S. 80s cop show Miami Vice. As well as producing/directing Heat starring Al Pacino and Robert De Niro.For his work, he has received nominations from international organizations and juries. Including the British Academy of Film and Television Arts, Cannes, and the Academy of Motion Picture Arts and Sciences.",
                            ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-52.jpg"

                        },
                        new Producer()
                        {
                            FullName = "Steven Spielberg",
                            Bio = "Spielberg is simply one of the most influential and famous movie producer in the history of cinema. Steven Spielberg is Hollywood’s best-known director, and one of the world’s wealthiest filmmakers. He has an extraordinary number of commercially and critically acclaimed credits to his name. Including his work on Schindler’s List which won Golden Globe, BAFTA, and Academy Award for best picture.",
                            ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-1-4.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Spike Lee",
                            Bio = "Spike Lee is one of the most famous black movie producers, he was born Shelton Jackson Lee on March 20, 1957, in Atlanta, Georgia but moved to New York at a young age. Lee came from an artistic, education-grounded background. His father was a jazz musician and his mother, was a schoolteacher. Lee has won lots of awards for his work which has focused on race relations, racism in the black community, and poverty. His work includes Do the Right Thing, Jungle Fever, Mo Better Blues, and Malcolm X.",
                            ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-2-4.jpg"
                        },
                        new Producer()
                        {
                            FullName = "Quentin Tarantino",
                            Bio = "Quentin Tarantino was born in Knoxville, Tennessee. To Tony Tarantino – an Italian-American actor and musician from New York, and Connie (McHugh), a nurse. Tarantino moved with his mother to Torrance, California, when he was four years old. He has produced and directed films such as Reservoir Dogs, Kill Bill, and Tony Jaa’s martial arts movie The Protector (aka U.K Warrior King).",
                            ProfilePictureURL = "https://deadline.com/wp-content/uploads/2021/07/AP21177230927087.jpg?w=681&h=383&crop=1"
                        },
                        new Producer()
                        {
                            FullName = "Irwin Winkler",
                            Bio = "American Producer Irwin Winkler is to thank for the production of Rocky and Goodfellas. He has created over 55 Hollywood productions including Creed, The Wolf of Wall Street, and The Gambler in his most recent work. For his contribution to the motion picture industry, Winkler has a star on the Hollywood Walk of Fame at 6801 Hollywood Boulevard. He was also the recipient of the 2017 Producers Guild of America’s David O. Selznick Achievement Award for his work in motion pictures.",
                            ProfilePictureURL = "https://support.musicgateway.com/wp-content/uploads/2020/12/Copy-of-800-x-500-Blog-Post-4-4.jpg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Ghostbusters",
                            Description = "Three parapsychologists forced out of their university funding set up shop as a unique ghost removal service in New York City, attracting frightened yet skeptical customers.",
                            Price = 39.50,
                            ImageURL = "https://cdn.mos.cms.futurecdn.net/7SfznToW65UX8QdS65Jn5d-970-80.jpg.webp",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Indiana Jones",
                            Description = "An archeology professor named Indiana Jones is venturing in the jungles of South America searching for a golden statue.",
                            Price = 29.50,
                            ImageURL = "https://cdn.mos.cms.futurecdn.net/DMJevRCSXLfKagz8XdWHTk-970-80.jpg.webp",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Silence of the Lambs",
                            Description = "A young F.B.I. cadet must receive the help of an incarcerated and manipulative cannibal killer to help catch another serial killer, a madman who skins his victims.",
                            Price = 39.50,
                            ImageURL = "https://cdn.mos.cms.futurecdn.net/yVDrRevZY8nJcivo4pxZMF-970-80.jpg.webp",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Jaws",
                            Description = "When a killer shark unleashes chaos on a beach community off Cape Cod, it's up to a local sheriff, a marine biologist, and an old seafarer to hunt the beast down.",
                            Price = 39.50,
                            ImageURL = "https://cdn.mos.cms.futurecdn.net/adSAZsEScZ7QqGnZtjScgJ-970-80.jpg.webp",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = 1,
                            ProducerId = 2,
                            MovieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "The Godfather",
                            Description = "Don Vito Corleone, head of a mafia family, decides to hand over his empire to his youngest son Michael. However, his decision unintentionally puts the lives of his loved ones in grave danger.",
                            Price = 39.50,
                            ImageURL = "https://cdn.mos.cms.futurecdn.net/26ofuZ9pvo3cNuytYjY6zN-970-80.jpg.webp",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = 1,
                            ProducerId = 3,
                            MovieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            Name = "Pulp Fiction",
                            Description = "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                            Price = 39.50,
                            ImageURL = "https://cdn.mos.cms.futurecdn.net/vgctzbBjL8S7GJr5s2JHMB-970-80.jpg.webp",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = 1,
                            ProducerId = 5,
                            MovieCategory = MovieCategory.Action
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new Actor_Movie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new Actor_Movie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new Actor_Movie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new Actor_Movie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
