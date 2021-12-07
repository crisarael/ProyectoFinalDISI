﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalDISI.Confirmacion
{
    public partial class ConfirmacionEliminar : Form
    {
        string gAccion, gId, gNombre;
        public ConfirmacionEliminar(string accion, string id, string nombre)
        {
            InitializeComponent();
            gAccion = accion;
            gId = id;
            gNombre = nombre;

            switch (accion)
            {
                case "Especialidad":
                    label4.Text = "¿Deseas eliminar la especialidad " + nombre + "?";
                    break;
                default:
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            switch (gAccion)
            {
                case "Especialidad":
                    SQLCommands.DeleteEspecialidades(gId);
                    MessageBox.Show("Se ha eliminado " + gNombre + " correctamente", "Eliminacion completa");
                    break;
                default:
                    break;
            }
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
