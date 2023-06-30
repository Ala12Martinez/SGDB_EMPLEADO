using Empleados_23CV.Entities;
using Empleados_23CV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Empleados_23CV
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Empleado empl = new Empleado();
        Empleado_Services services = new Empleado_Services();

        private void Btn_Agrega_Click(object sender, RoutedEventArgs e)
        {
            
            empl.Nombre = txtNombre.Text;
            empl.Apellido = txtApedillo.Text;   
            empl.Correo= txtCorreo.Text;
            // VALIDADR QUE LOS CAMPOS NO ESTEN VACIOS

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre no puede estar vacío");
                return;
            }

            if (string.IsNullOrEmpty(txtApedillo.Text))
            {
                MessageBox.Show("El campo Apellido no puede estar vacío");
                return;
            }

            if (string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("El campo Correo no puede estar vacío");
                return;
            }

            services.Add(empl);
            
            txtNombre.Clear();
            txtApedillo.Clear();
            txtCorreo.Clear();
            MessageBox.Show("Los datos se guardaron correctamente");
              
           
        }

        private void Btn_Ver_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);

            Empleado empl = services.Read(id);

            txtNombre.Text = empl.Nombre;
            txtApedillo.Text = empl.Apellido;
            txtCorreo.Text = empl.Correo;
            txtFecha.Text = empl.FechaRegistro.ToString();
        }
    }
}
