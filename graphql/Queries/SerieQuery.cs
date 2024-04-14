namespace Queries

{
    public class SerieQuery()
  {
    public Models.Serie GetSerie(){
      return new Models.Serie
      {
        Title = "Breaking Bad",
        Platform =
        [
          new Models.Platform { Name = "Netflix", Followers = 1000000 },
          new Models.Platform { Name = "Amazon Prime", Followers = 500000 }
        ],
        ReleaseDate = new DateTime(2008, 1, 20)
      };
    }
    public List<Models.Serie> GetSeries() {
      return new List<Models.Serie>() {
        new Models.Serie {
          Title = "Breaking Bad",
          Platform = [
            new Models.Platform { Name = "Netflix", Followers = 1000000 },
            new Models.Platform { Name = "Amazon Prime", Followers = 500000 }
          ],
          ReleaseDate= new DateTime(2008, 1, 20)
        },
        new Models.Serie {
          Title = "Game of Thrones",
          Platform = [
            new Models.Platform { Name = "HBO", Followers = 2000000 },
            new Models.Platform { Name = "Amazon Prime", Followers = 500000 }
          ],
          ReleaseDate= new DateTime(2011, 4, 17)
        }
      };
  }
  public Models.Serie GetSerieById(int id) {
    var series = new List<Models.Serie>() {
      new Models.Serie {
        Title = "Breaking Bad",
        Platform = [
          new Models.Platform { Name = "Netflix", Followers = 1000000 },
          new Models.Platform { Name = "Amazon Prime", Followers = 500000 }
        ],
        ReleaseDate= new DateTime(2008, 1, 20)
      },
      new Models.Serie {
        Title = "Game of Thrones",
        Platform = [
          new Models.Platform { Name = "HBO", Followers = 2000000 },
          new Models.Platform { Name = "Amazon Prime", Followers = 500000 }
        ],
        ReleaseDate= new DateTime(2011, 4, 17)
      },
      new Models.Serie {
        Title = "The Witcher",
        Platform = [
          new Models.Platform { Name = "Netflix", Followers = 1000000 },
        ],
        ReleaseDate= new DateTime(2019, 12, 20)
      },
      new Models.Serie {
        Title = "The Mandalorian",
        Platform = [
          new Models.Platform { Name = "Disney+", Followers = 1000000 },
        ],
        ReleaseDate= new DateTime(2019, 11, 12)
      }
    };
    return series[id];
  }
  }
}