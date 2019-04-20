using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_FSI
{
    public partial class Form1 : Form
    {
        ListaNumeros objlista = new ListaNumeros();
        List<int> AUX = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(textBoxNumero.Text);
            if(objlista.VerificarInsertarNumero(aux)==true)
            {
                MessageBox.Show("El numero ya a sido ingresado");
            }
            else
            {
                objlista.InsetarNumeros(aux);
                listBox1.Items.Add(aux);
            }
            textBoxNumero.Clear();
        }

        private void buttonMayorMenor_Click(object sender, EventArgs e)
        {
            string aux1 = objlista.EncontrarMayor().ToString();
            MessageBox.Show("mayor: " + aux1);
            string aux2 = objlista.EncontrarMenor().ToString();
            MessageBox.Show("menor: " + aux2);
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            
            if(textBoxNumero.Text=="")
            {
                MessageBox.Show("Ingrese el numero a eliminar");
            }
            else
            {
                int aux = Convert.ToInt32(textBoxNumero.Text);
                if (objlista.VerificarInsertarNumero(aux) == false)
                {
                    MessageBox.Show("El numero no existe");
                }
                else
                {
                    objlista.EliminarNumero(aux);
                    //listBox1.Items.Remove(aux);
                   listBox1.Items.Clear();
                    AUX = objlista.Numeros;
                    for(int i=0;i<AUX.Count();i++)
                    {
                        listBox1.Items.Add(AUX.ElementAt(i));
                    }
                    
                }
            }
            textBoxNumero.Clear();
        }

        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(textBoxNumero.Text);
            if (objlista.VerificarInsertarNumero(aux) == true)
            {
                MessageBox.Show("El numero ya a sido ingresado");
            }
            else
            {
                if (textBoxNumero.Text == "")
                {
                    MessageBox.Show("Ingrese el numero a eliminar");
                }
                else
                {
                    int pos;
                    pos = Convert.ToInt32(listBox1.SelectedIndex);
                    objlista.InsertNumero(aux, pos);
                  //  listBox1.Items.Insert(pos, aux);
                    listBox1.Items.Clear();
                    AUX = objlista.Numeros;
                    for (int i = 0; i < AUX.Count(); i++)
                    {
                        listBox1.Items.Add(AUX.ElementAt(i));
                    }
                }
            }
            
            textBoxNumero.Clear();
        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            objlista.OrdenarNumeros();
          //  listBox1.Sorted = true;
            listBox1.Items.Clear();
            AUX = objlista.Numeros;
            for (int i = 0; i < AUX.Count(); i++)
            {
                listBox1.Items.Add(AUX.ElementAt(i));
            }
           
        }
    }
}
