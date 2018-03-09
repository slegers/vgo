using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase.Models
{
    public class MovieRepository {
        public MovieRepository() {
            using (var db = new MovieContext()) {
                if (!db.Movies.Any()) {
                    // if the repository is empty, add some movies
                    var omdb = new OmdbService();
                    db.Movies.AddRange(new Movie[] {
                        omdb.FindById("tt0107290"),
                        omdb.FindById("tt0111161"),
                        omdb.FindById("tt0120737"),
                        //omdb.FindById("tt0078748"),
                        //omdb.FindById("tt0110912"),
                        //omdb.FindById("tt0068646"),
                        //omdb.FindById("tt2832470"),
                        //omdb.FindById("tt4009460")
                    });
                    db.SaveChanges();
                }
            }
        }
        public IEnumerable<Movie> Entries {
            get {
                using (var db = new MovieContext()) {
                    return db.Movies.ToList();
                }
            }
        }

        public void Add(Movie movie) {
            using (var db = new MovieContext()) {
                if (!db.Movies.Any(c => c.ID == movie.ID)) {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                }
            }
            DataChanged?.Invoke();
        }

        public Movie FindById(string id) {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            using (var db = new MovieContext()) {
                return db.Movies.Where(c => c.ID == id).SingleOrDefault();
            }
        }

        public void LikeById(string id, bool like) {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            using (var db = new MovieContext()) {
                db.Movies.Where(c => c.ID == id).SingleOrDefault().Like = like;
                db.SaveChanges();
            }
            DataChanged?.Invoke();
        }
        public void SeeById(string id, bool seen) {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            using (var db = new MovieContext()) {
                db.Movies.Where(c => c.ID == id).SingleOrDefault().Seen = seen;
                db.SaveChanges();
            }
            DataChanged?.Invoke();
        }


        public Movie FindByTitle(string title) {
            if (title == null)
                throw new ArgumentNullException(nameof(title));
            using (var db = new MovieContext()) {
                return db.Movies.Where(c => c.Title == title).SingleOrDefault();
            }
        }

        public void Remove(string id) {
            if (id == null)
                throw new ArgumentNullException(nameof(id));
            using (var db = new MovieContext()) {
                var m = db.Movies.Where(c => c.ID == id).SingleOrDefault();
                if (m != null) {
                    db.Movies.Remove(m);
                    db.SaveChanges();
                }
            }
            DataChanged?.Invoke();
        }

        public static event Action DataChanged;

        private class MovieContext : DbContext {
            public DbSet<Movie> Movies { get; set; }
        }
    }
}
