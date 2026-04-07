using product_manager_winforms.Application.Products;
using product_manager_winforms.Infrastructure.Products;
using product_manager_winforms.Presentation.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace product_manager_winforms
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            var service = new ProductService();

            // Crear form (constructor vacío)
            var form = new ProductForm();

            // Crear presenter pasando el form y el service
            var presenter = new ProductPresenter(form, service);

            // Asignar presenter al form
            form.SetPresenter(presenter);

            System.Windows.Forms.Application.Run(form);
        }
    }
}
