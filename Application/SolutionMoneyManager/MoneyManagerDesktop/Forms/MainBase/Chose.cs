///////////////////////////////////////////////
//-------------------------------------------//
//                                           //
// <git hub="https://github.com/edleyrocha"> //
//      GitHub Repositories                  //
// </git>                                    //
//                                           //
// <mail address="edleyrocha@hotmail.com">   //
//       Developer Email                     //
// </mail>                                   //
//                                           //
//-------------------------------------------//
///////////////////////////////////////////////
namespace MoneyManagerDesktop
{
    public class Chose
    {
        /// Options to open form - Pass1
        /// <summary>
        /// # Enum ActionForm ( ActionSelect = 0 , ActionInsert = 1 , ActionUpdate = 2 , ActionDelete = 3 , ActionRestore = 4 )
        /// </summary>
        public enum ActionForm
        {
            ActionSelect = (0),
            ActionInsert = (1),
            ActionUpdate = (2),
            ActionDelete = (3),
            ActionRestore = (4)
        }
       
        /// <summary>
        /// # Enum SQLConnectionString ( GetDataSource = 0 , GetDataProvider = 1 , GetConnectionString = 2 )
        /// </summary>
        public enum SQLConnectionString
        {
            GetDataSource = (0),
            GetDataProvider = (1),
            GetConnectionString = (2)
        }
       
        /// <summary>
        /// # Set AcessLoginStatus to ( AllowedDenied = 1 - AllowedAccess = 2 )
        /// </summary>
        public enum AcessLoginStatus
        {
            AllowedDenied = 1,
            AllowedAccess = 2
        }

    }
}