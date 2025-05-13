using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evencat
{
    public static class MakeRoundedMethods
    {

        public static void makeRoundedPanel(Panel panel, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius - 1, panel.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            panel.Region = new Region(path);
        }

        // Método para redondear un TextBox y añadir un hint
        public static void makeRoundedTextBox(TextBox textBox, int radius, string hint)
        {
            // Redondear bordes
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(textBox.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(textBox.Width - radius, textBox.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, textBox.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            textBox.Region = new Region(path);

            textBox.TextAlign = HorizontalAlignment.Center;

            // Añadir hint
            textBox.Text = hint;
            textBox.ForeColor = Color.Gray;
            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == hint)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };
            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = hint;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        // Método para redondear un Button
        public static void makeRoundedBigButton(Button button, int radius)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius - 1, button.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);

            // Ajustar apariencia
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; // Sin borde
            button.ForeColor = Color.White; // Texto blanco
            //button.Font = new Font("Arial", 12, FontStyle.Bold);
            button.Font = new Font(FontManager.FontCollection.Families[0], 15);
        }

        public static void makeRoundeSmallButton(Button button, int radius, Color foreColor, Color backColor)
        {
            var path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius - 1, button.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();
            button.Region = new Region(path);

            // Ajustar apariencia
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0; // Sin borde
            button.ForeColor = foreColor; // Texto blanco
            button.BackColor = backColor;

            if (backColor == AppColors.purpleButton || backColor == Color.Red)
            {
                button.Font = new Font(FontManager.FontCollection.Families[1], 10);
            }
            else {
                button.Font = new Font(FontManager.FontCollection.Families[0], 10, FontStyle.Bold);

            }

        }

        public static void MakeRoundedComboBox(ComboBox comboBox, int radius, String hint)
        {
            // Crear un GraphicsPath para redondear los bordes
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90); // Esquina superior izquierda
            path.AddArc(comboBox.Width - radius - 1, 0, radius, radius, 270, 90); // Esquina superior derecha
            path.AddArc(comboBox.Width - radius - 1, comboBox.Height - radius - 1, radius, radius, 0, 90); // Esquina inferior derecha
            path.AddArc(0, comboBox.Height - radius - 1, radius, radius, 90, 90); // Esquina inferior izquierda
            path.CloseFigure();

            // Aplicar la región redondeada al ComboBox
            comboBox.Region = new Region(path);

            // Ajustar la apariencia del ComboBox
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.BackColor = Color.White; // Color de fondo
            comboBox.ForeColor = Color.Black; // Color del texto
            comboBox.Font = new Font(FontManager.FontCollection.Families[0], 10, FontStyle.Bold);


            comboBox.Text = hint;
            comboBox.ForeColor = Color.Gray;

            // Manejar el evento Enter
            comboBox.Enter += (sender, e) =>
            {
                if (comboBox.Text == hint)
                {
                    comboBox.Text = ""; // Limpiar el hint
                    comboBox.ForeColor = Color.Black; // Cambiar el color del texto
                }
            };

            // Manejar el evento Leave
            comboBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrEmpty(comboBox.Text))
                {
                    comboBox.Text = hint; // Restaurar el hint
                    comboBox.ForeColor = Color.Gray; // Cambiar el color del texto
                }
            };

            // Manejar el evento TextChanged
            comboBox.TextChanged += (sender, e) =>
            {
                if (comboBox.Text != hint && comboBox.ForeColor != Color.Black)
                {
                    comboBox.ForeColor = Color.Black; // Asegurarse de que el texto no sea gris
                }
            };
        }
    }

    }

