using iCantina.views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using iCantina;
using iCanteen.views;

namespace iCantina
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            using (var context = new iCanteenContext()) // Substitua YourDbContext pelo nome do seu contexto do Entity Framework
            {
                // Verifica se existem dados na tabela Employee
                bool hasEmployees = context.Users.Any();

                if (hasEmployees)
                {
                    // Se existem dados, abre o formulário de login
                    Application.Run(new Login()); // Substitua LoginForm pelo nome do seu formulário de login
                }
                else
                {
                    // Se não existem dados, abre o formulário de detalhes do funcionário
                    Application.Run(new EmployeesDetails()); // Substitua EmployeeDetailsForm pelo nome do seu formulário de detalhes do funcionário
                    Application.Run(new Login()); // Substitua LoginForm pelo nome do seu formulário de login
                }
            }
        }
    }
}
