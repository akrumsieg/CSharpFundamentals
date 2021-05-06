using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
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
                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

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
                        Console.WriteLine("Please enter a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void CreateNewContent() //challenge = ask the user to confirm info before adding to directory
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //title
            Console.WriteLine("Enter the title for this content");
            newContent.Title = Console.ReadLine();

            //description
            Console.WriteLine("Enter the description for this content");
            newContent.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Enter the rating for this content (0.0 - 5.0)");
            newContent.StarRating = Convert.ToDouble(Console.ReadLine());

            //TypeOfGenre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            //string genreAsString = Console.ReadLine();
            //int genreAsInt = Convert.ToInt32(genreAsString);
            //newContent.TypeOfGenre = (GenreType)genreAsInt;
            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(Console.ReadLine());

            //MaturityRating
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly.");
            }
            else
            {
                Console.WriteLine("Could not add the content.");
            }

        }
        private void DisplayAllContent()
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach (StreamingContent content in allContent)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Genre: { content.TypeOfGenre}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                    $"===========================");
                Console.ResetColor();
            }
        }
        private void DisplayContentByTitle() //get a title from the user then display all properties of the content that has that title
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title for the content you would like to see.");
            StreamingContent matchedContent = _repo.GetContentByTitle(Console.ReadLine());
            Console.Clear();
            if (matchedContent != null)
            {
                Console.WriteLine($"Title: {matchedContent.Title}\n" +
                    $"Description: {matchedContent.Description}\n" +
                    $"Star Rating: {matchedContent.StarRating}\n" +
                    $"Genre: {matchedContent.TypeOfGenre}\n" +
                    $"Maturity Rating: {matchedContent.MaturityRating}\n" +
                    $"Is Family Friendly: {matchedContent.IsFamilyFriendly}"
                    );
            }
            else
            {
                Console.WriteLine("Please enter a title.");
            }
        }
        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update.");
            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //title
            Console.WriteLine("Enter the title for this content");
            newContent.Title = Console.ReadLine();

            //description
            Console.WriteLine("Enter the description for this content");
            newContent.Description = Console.ReadLine();

            //StarRating
            Console.WriteLine("Enter the rating for this content (0.0 - 5.0)");
            newContent.StarRating = Convert.ToDouble(Console.ReadLine());

            //TypeOfGenre
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime\n");

            newContent.TypeOfGenre = (GenreType)Convert.ToInt32(Console.ReadLine());

            //MaturityRating
            Console.WriteLine("Enter the genre number for this content:\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG 13\n" +
                "4. R\n" +
                "5. TV G\n" +
                "6. TV PG\n" +
                "7. TV 14\n" +
                "8. TV MA\n");

            newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully.");
            }
            else
            {
                Console.WriteLine("No content by that title exists.");
            }
        }
        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to delete.");
            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());
            if (wasDeleted)
            {
                Console.WriteLine("Content was successfully deleted.");
            }
            else
            {
                Console.WriteLine("No content by that title exists.");
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
