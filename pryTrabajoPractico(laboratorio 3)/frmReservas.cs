using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryTrabajoPractico_laboratorio_3_
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
        }

        int asientos(int cantidadAsientos, int asientosFila, Color color, GroupBox group, int xInicial, int yInicial)
        {
            PictureBox asiento;
            int x = xInicial;
            int y = yInicial;
            asiento = new PictureBox();
            asiento.Size = new Size(75,20);
            asiento.Location = new Point(25,10);
            asiento.BackColor = Color.Brown;
            group.Controls.Add(asiento);
            
            for (int i = 0; i < cantidadAsientos / asientosFila; i++)
            {
                for (int z = 0; z < asientosFila; z++)
                {
                    asiento = new PictureBox();
                    asiento.Size = new Size(10, 10);
                    asiento.Location = new Point(x, y);
                    asiento.BackColor = color;
                    group.Controls.Add(asiento);
                    x += 20;
                }
                x = 20;
                y += 20;
                group.Size = new Size(group.Size.Width, group.Size.Height + 10);
            }
            return y;
          
        }

        private void cboTeatros_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupBox group = new GroupBox();

            if (cboTeatros.SelectedIndex == 0)
            {
                this.Controls.Remove(group);
                group.Name = "Group";
                group.Location = new Point(160, 35);
                group.Size = new Size(130, 250);
                int y = asientos(20, 5, Color.Blue, group, 20, 80);
                asientos(20, 5, Color.Green, group, 20, y + 20);
                this.Controls.Add(group);
            }
            else if (cboTeatros.SelectedIndex == 1)
            {
                group = new GroupBox();
                group.Location = new Point(160, 35);
                group.Size = new Size(130, 250);
                int y = asientos(40, 4, Color.Blue, group, 20, 80);
                asientos(20, 5, Color.Green, group, 20, y + 20);
                this.Controls.Add(group);
            }
            else
            {
                group = new GroupBox();
                group.Location = new Point(160, 35);
                group.Size = new Size(130, 250);
                int y = asientos(10, 3, Color.Blue, group, 20, 80);
                asientos(15, 5, Color.Green, group, 20, y + 20);
                this.Controls.Add(group);
            }
        }
    }
}
