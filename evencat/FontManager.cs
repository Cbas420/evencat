using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evencat
{
    public static class FontManager
    {
        public static PrivateFontCollection FontCollection { get; private set; }

        static FontManager()
        {
            FontCollection = new PrivateFontCollection();
            LoadCustomFonts();
            MessageBox.Show($"Número de fuentes cargadas: {FontCollection.Families.Length}");
        }

        private static void LoadCustomFonts()
        {
            // Rutas de los archivos de la fuente
            string[] fontFiles = new string[]
            {
                "Poppins-Black.ttf",
                "Poppins-Light.ttf",
                "Poppins-Regular.ttf"
            };

            // Cargar todas las fuentes
            foreach (string fontFile in fontFiles)
            {
                string fontPath = Path.Combine(Application.StartupPath, "fonts", fontFile);

                // Verificar si el archivo de la fuente existe
                if (File.Exists(fontPath))
                {
                    try
                    {
                        // Cargar la fuente desde el archivo
                        FontCollection.AddFontFile(fontPath);
                    }
                    catch (Exception ex)
                    {
                        // Si hay un error, mostrar el mensaje y qué archivo de fuente falló
                        MessageBox.Show($"Error al cargar la fuente {fontFile}: {ex.Message}");
                    }
                }
                else
                {
                    // Si no se encuentra el archivo de la fuente
                    MessageBox.Show($"No se encontró el archivo de la fuente: {fontPath}");
                }
            }
        }

    }
}
