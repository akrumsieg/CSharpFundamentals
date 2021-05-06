using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository //our pseudo-database
    {
        //FIELDS (a variable which exists at the class level)
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD methods - create, read, update, delete

        //CREATE
        //create StreamingContent
        public bool AddContentToDirectory(StreamingContent newContent) //C - create
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded; //double checking the content object was added correctly to the directory
        }
        //create Movie
        public bool AddContentToDirectory(Movie newContent) //C - create
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded; //double checking the content object was added correctly to the directory
        }

        //create Show

        //create Episode

        //READ
        //read all StreamingContent
        public List<StreamingContent> GetContents() //R - read
        {
            return _contentDirectory;
        }
        //read all Movie
        public List<Movie> GetMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie) { allMovies.Add(content as Movie); }
            }
            return allMovies;
        }
        //read all Show
        public List<Show> GetShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show) { allShows.Add(content as Show); }
            }
            return allShows;
        }

        //read all Episode

        //read content StreamingContent
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }
        //read content Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content; // same: return movie as Movie
                }
            }
            return null;
        }

        //read content Show

        //read content Episode
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show)) //last part shorthand: show is Show
                {
                    return (Show)content;
                }
            }
            return null;
        }


        //UPDATE
        //update StreamingContent
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues) //U - update
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            //check for null
            if (oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete) //D - delete
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete.ToLower());
            if (contentToDelete != null)
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
