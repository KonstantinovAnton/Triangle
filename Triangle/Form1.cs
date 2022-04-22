using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            checkNumbers();
            if (checkNumbers())
            {
                defineType();
            }

        }

        private bool checkNumbers()
        {
            if (textBoxX.Text == "")
            {
                labelResult.Text = "Введите длину первой стороны";
                return false;
            }
            else if (textBoxY.Text == "")
            {
                labelResult.Text = "Введите длину второй стороны";
                return false;
            }
            else if (textBoxZ.Text == "")
            {
                labelResult.Text = "Введите длину третьей стороны";
                return false;
            }

           

            try
            {
                double checkNumber = Convert.ToDouble(textBoxX.Text);
            }
            catch
            {
                labelResult.Text = "Некорректные данные о первой стороне";
                return false;
            }
            try
            {
                double checkNumber = Convert.ToDouble(textBoxY.Text);
            }
            catch
            {
                labelResult.Text = "Некорректные данные о второй стороне";
                return false;
            }
            try
            {
                double checkNumber = Convert.ToDouble(textBoxZ.Text);
            }
            catch
            {
                labelResult.Text = "Некорректные данные о третьей стороне";
                return false;
            }

            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            double z = Convert.ToDouble(textBoxZ.Text);

            if (x == 0 || y == 0 || z == 0)
            {
                labelResult.Text = "Длина строки не может равняться нулю";
                return false;
            }


            if (x < 0 || y < 0 || z < 0)
            {
                labelResult.Text = "Длина строки не может быть отрицательным числом";
                return false;
            }

            if (x + y <= z || y+z <= x || x + z <= y)
            {
                labelResult.Text = "Треугольника с такими сторонами не существует!";
                return false;
            }

            return true;


        }

        private void defineType()
        {
            double x, y, z;
            x = Convert.ToDouble(textBoxX.Text);
            y = Convert.ToDouble(textBoxY.Text);
            z = Convert.ToDouble(textBoxZ.Text);

            if (x == y && y == z)
            {
                labelResult.Text = "Данный треугольник равносторонний";
            }
            else if (x == y || y == z || x == z)
            {
                labelResult.Text = "Данный треугольник равнобедренный";
            }
            else
            {
                labelResult.Text = "Данный треугольник разносторонний";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Введите длины сторон";
            textBoxX.Text = "";
            textBoxY.Text = "";
            textBoxZ.Text = "";
        }

     
    }
}
