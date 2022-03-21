using StudentProject.BL;

namespace StudentProject.ConsoleApp.Helpers
{
    class RepositoryToConsole<T> : GenericRepository<T> where T : class, IRepositoryModel
    {
        /// <summary>
        /// Check for empty repository and list out repository items
        /// </summary>
        /// <param name="repo"></param>
        /// <returns>String of items in list or warning of empty repository</returns>
        public static string Listing(GenericRepository<T> repo)
        {
            var returnString = "";
            
            if (repo.IsEmpty())
            {
                returnString = "Repository is empty!";
            }
            else
            {
                foreach (var item in repo.ItemsList)
                {
                    returnString += $"--- id:{item.Id} ---\n{item}\n";
                }
            }
            return returnString;
        }
    }
}
