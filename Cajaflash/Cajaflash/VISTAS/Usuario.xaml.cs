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
using System.Windows.Shapes;
using Cajaflash.CONTROLADOR;
using Cajaflash.MODELO;

namespace Cajaflash.VISTAS
{
    /// <summary>
    /// Lógica de interacción para Usuario.xaml
    /// </summary>
    public partial class Usuario : Window
    {
        DTOusuario dto_usuario = new DTOusuario();
        DTOtipocs dto_tipos = new DTOtipocs();
        

        
        public Usuario()
        {
            InitializeComponent();
           
            cbtipo.ItemsSource = dto_tipos.listadoTipo("");
            dataGrid_USA.ItemsSource = dto_usuario.listadoUsuario("");
            
        }

        private void Btagregar_Click(object sender, RoutedEventArgs e)
        {
            Tipo tip = (Tipo)cbtipo.SelectedItem;
            lbrespuesta.Content = dto_usuario.agregarUsuario(new Usuarios { Nombre = txtnombre.Text, Clave = txtclave.Text, tipo = tip });
            dataGrid_USA.ItemsSource = dto_usuario.listadoUsuario("");
        }

        private void Bteliminar_Click(object sender, RoutedEventArgs e)
        {
            
            lbrespuesta.Content = dto_usuario.eliminarUsuario(txtnombre.Text);
            dataGrid_USA.ItemsSource = dto_usuario.listadoUsuario("");
        }

        private void Bteditar_Click(object sender, RoutedEventArgs e)
        {
            Tipo tip = (Tipo)cbtipo.SelectedItem;
            lbrespuesta.Content = dto_usuario.editarUsuario(new Usuarios { Nombre = txtnombre.Text, Clave = txtclave.Text, tipo = tip });
            dataGrid_USA.ItemsSource = dto_usuario.listadoUsuario("");
        }
    }
}
