using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using Fasetto.Word.Core;
using Fasetto.Word.Core.ViewModels;

namespace Fasetto.Word.Core
{
    /// <summary>
    /// The view model for a register screen
    /// </summary>
    public class RegisterViewModel : BaseViewModel
    {
        #region private members


        #endregion

        #region Public properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// The password of the user
        /// </summary>
        public SecureString Password { get; set; }
       
        /// <summary>
        /// A flag indicating if the register is running
        /// </summary>
        public bool RegisterIsRunning { get; set; }

        #endregion

        #region Commands

        /// <summary>
        /// The command to register
        /// </summary>
        public ICommand LoginCommand { get; set; }


        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public RegisterViewModel()
        {
            RegisterCommand = new RelayParameterizedCommand(async (parameter) => await Register(parameter));
            LoginCommand = new RelayCommand(async () => await Login());
        }

        #endregion

        /// <summary>
        /// Attemps to register a new user
        /// </summary>
        /// <param name="parameter">The <see cref="SecureString"/> passsed in from the view for the user password</param>
        /// <returns></returns>
        public async Task Register(object parameter)
        {
            await RunCommand(() => RegisterIsRunning, async () =>
            {
                await Task.Delay(5000);
            });
        }

        /// <summary>
        /// Take the user to the register page
        /// </summary>
        /// <returns></returns>
        public async Task Login()
        {

           // IoC.IoC.Get<ApplicationViewModel>().SideMenuVisible ^= true;

            //return;

            // Go to login page
            IoC.IoC.Get<ApplicationViewModel>().GoToPage(ApplicationPage.Login);

            await Task.Delay(1);
        }
    }
}
