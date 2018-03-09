using OMDbSharp;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Models {
    public class OmdbService {
        public Movie FindById(string id) {
            var client = new OMDbClient(false);
            var omdbResult = client.GetItemByID(id).Result;
            if (omdbResult.imdbID == null) // not found
                return null;
            float rating;
            if (!float.TryParse(omdbResult.imdbRating, NumberStyles.None, new CultureInfo("en-US"), out rating )) {
                rating = -1;
            }
            int year;
            if (!int.TryParse(omdbResult.Year, out year)) {
                year = 0;
            }
            DateTimeOffset released;
            if (!DateTimeOffset.TryParse(omdbResult.Released, new CultureInfo("en-US"), DateTimeStyles.None, out released)) {
                released = DateTimeOffset.MinValue;
            }
            var movie = new Movie {
                ID = omdbResult.imdbID,
                Title = omdbResult.Title,
                Plot = omdbResult.Plot,
                Director = omdbResult.Director,
                Actors = omdbResult.Actors,
                Genre = omdbResult.Genre,
                PosterUrl = omdbResult.Poster,
                Year = year == 0 ? (int?)null : year
                 
            };
            return movie;
        }

        public IEnumerable<MovieSearchResult> Search(string query) {
            var client = new OMDbClient(false);
            var omdbResult = client.GetItemList(query).Result;
            var result = new List<MovieSearchResult>();
            foreach (var si in omdbResult.Search) {
                result.Add(new MovieSearchResult { ID = si.imdbID, Title = si.Title, Year = int.Parse(si.Year) });
            }
            return result;
        }
    }
}
