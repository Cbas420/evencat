using System;
using System.Windows.Forms;

namespace evencat
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            // Mostrar pantalla de inicio/bienvenida
            using (FormStart startForm = new FormStart())
            {
                startForm.ShowDialog();

                if (startForm.DialogResult == DialogResult.Cancel) {

                    return; //no recordaba que se podia hacer esto xd

                }

            }

            // Bucle principal de la aplicación
            while (true) //Mantiene el programa ejecutandose hasta que ocurra un break, return o un Application.Exit()
            {


                // Paso 1: Mostrar login
                using (FormLogIn loginForm = new FormLogIn())
                {
                    if (loginForm.ShowDialog() != DialogResult.OK || !loginForm.LoginSuccess)
                        break; // Salir si el login falla
                }

                // Paso 2: Mostrar menú principal
                string selectedOption;
                using (FormSelectOption selectForm = new FormSelectOption())
                {
                    if (selectForm.ShowDialog() != DialogResult.OK)
                        break; // Salir si se cancela

                    selectedOption = selectForm.SelectedOption;
                }

                if (selectedOption == "Log Out") {
                    continue;
                }


               /* // Paso 3: Manejar la opción seleccionada
                switch (selectedOption)
                {
                    case "Manage Spaces":
                        using (var spacesForm = new FormSpacesManagement())
                        {
                            var result = spacesForm.ShowDialog();
                            if (result == DialogResult.Retry)
                            {
                                goToMenu = true;
                                continue; // Vuelve al inicio del bucle (pero saltará el login)
                            }
                        }
                        break;

                    case "Manage Users":
                        using (var usersForm = new FormUsersManagement())
                        {
                            var result = usersForm.ShowDialog();
                            if (result == DialogResult.Retry)
                            {
                                goToMenu = true;
                                continue;
                            }
                        }
                        break;

                    case "Log Out":
                        continue; // Vuelve al login
                }*/

                //break; // Sale si no se eligió "Volver al menú"
            }

        }
    }
}