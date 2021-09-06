using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        private IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                _console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = _console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //Exit()
                        keepRunning = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number");
                        break;
                }
                _console.WriteLine("Please press any key to continue");
                _console.ReadKey();
                _console.Clear();
            }
        }
        private void CreateNewContent() //challenge = ask the user to confirm info before adding to directory
        {
            _console.Clear();
            StreamingContent newContent = new StreamingContent();

            //title
            _console.WriteLine("Enter the title for this content");
            newContent.Title = _console.ReadLine();

            //description
            _console.WriteLine("Enter the description for this content");
            newContent.Description = _console.ReadLine();

            //StarRating
            _console.WriteLine("Enter the rating for this content (0.0 - 5.0)");
            newContent.StarRating = Convert.ToDouble(_console.ReadLine());

            //TypeOfGenre
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            //string genreAsString = _console.ReadLine();
            //int genreAsInt = Convert.ToInt32(genreAsString);
            //newContent.TypeOfGenre = (GenreType)genreAsInt;
            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(_console.ReadLine());

            //MaturityRating
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                _console.WriteLine("The content was added correctly.");
            }
            else
            {
                _console.WriteLine("Could not add the content.");
            }

        }
        private void DisplayAllContent()
        {
            _console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                //Console.ForegroundColor = ConsoleColor.Cyan;
                _console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: { content.TypeOfGenre}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"===========================");
                //Console.ResetColor();
            }
        }
        private void DisplayContentByTitle() //get a title from the user then display all properties of the content that has that title
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title for the content you would like to see.");
            StreamingContent matchedContent = _repo.GetContentByTitle(_console.ReadLine());
            _console.Clear();
            if (matchedContent != null)
            {
                _console.WriteLine($"Title: {matchedContent.Title}\n" +
                    $"Description: {matchedContent.Description}\n" +
                    $"Star Rating: {matchedContent.StarRating}\n" +
                    $"Genre: {matchedContent.TypeOfGenre}\n" +
                    $"Maturity Rating: {matchedContent.MaturityRating}\n" +
                    $"Is Family Friendly: {matchedContent.IsFamilyFriendly}"
                    );
            }
            else
            {
                _console.WriteLine("Please enter a title.");
            }
        }
        private void UpdateContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title of the content you would like to update.");
            string oldTitle = _console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //title
            _console.WriteLine("Enter the title for this content");
            newContent.Title = _console.ReadLine();

            //description
            _console.WriteLine("Enter the description for this content");
            newContent.Description = _console.ReadLine();

            //StarRating
            _console.WriteLine("Enter the rating for this content (0.0 - 5.0)");
            newContent.StarRating = Convert.ToDouble(_console.ReadLine());

            //TypeOfGenre
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(_console.ReadLine());

            //MaturityRating
            _console.WriteLine("Enter the genre number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(_console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                _console.WriteLine("The content was updated successfully.");
            }
            else
            {
                _console.WriteLine("No content by that title exists.");
            }
        }
        private void DeleteContent()
        {
            _console.Clear();
            DisplayAllContent();
            _console.WriteLine("Enter the title of the content you would like to delete.");
            bool wasDeleted = _repo.DeleteExistingContent(_console.ReadLine());
            if (wasDeleted)
            {
                _console.WriteLine("Content was successfully deleted.");
            }
            else
            {
                _console.WriteLine("No content by that title exists.");
            }
        }
        private void SeedContentList()
        {
            _repo.AddContentToDirectory(new StreamingContent("A New Hope", "A long time ago, in a galaxy far, far away...", 4.3, GenreType.SciFi, MaturityRating.PG));
            _repo.AddContentToDirectory(new StreamingContent("Saving Private Ryan", "In WWII, a company of American soldiers...", 4.2, GenreType.Action, MaturityRating.R));
            _repo.AddContentToDirectory(new StreamingContent("Up", "A grumpy old man and a boy go on an adventure...", 4.7, GenreType.Comedy, MaturityRating.G));
        }
    }
}
