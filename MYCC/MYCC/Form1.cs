using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYCC
{
    public partial class Form1 : Form
    {
        double sumV = 0;
        double avarageV;
        double maxSq = 0;
        double radius;

        CircleDB circle;
        CylinderDB cylinder;
        int currentNum = -1;

        public Form1()
        {
            InitializeComponent();
            circle = new CircleDB();
            cylinder = new CylinderDB();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }



        private void Result_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (circle.DCi.Count > 0)
            {
                currentNum--;
                if (currentNum < 0)
                    currentNum = circle.DCi.Count - 1;
                showInfo();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (circle.DCi.Count > 0)
            {
                currentNum++;
                if (currentNum == circle.DCi.Count)
                    currentNum = 0;
                showInfo();
            }

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                    radius = Convert.ToDouble(textBoxRadius.Text);
                
               
                    double height = Convert.ToDouble(textBoxCylinderH.Text);

                    Circle circ = new Circle(radius);
                    Cylinder cyl = new Cylinder(radius, height);//?????
                    circle.DCi.Add(circ);
                    cylinder.DCy.Add(cyl);
                
                currentNum++;
                if (circle.DCi.Count > cylinder.DCy.Count)
                    ActiveForm.Text = circle.DCi.Count.ToString();
                else
                    ActiveForm.Text = cylinder.DCy.Count.ToString();
                if (circle.DCi.ElementAt(currentNum).Sq > maxSq)
                    maxSq = circle.DCi.ElementAt(currentNum).Sq;
                sumV += cylinder.DCy.ElementAt(currentNum).Va;
                
            }
            catch
            {
                MessageBox.Show("Eror");
            }
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                if (circle.DCi.Count > 0|| cylinder.DCy.Count>0)
                {
                    showInfo();

                }
            }
        }
        private void showInfo()
        {
            try
            {
                if (currentNum > circle.DCi.Count)
                    currentNum = 0;
               
                    textBoxSCir.Text = Convert.ToString(circle.DCi.ElementAt(currentNum).Sq);
                    textBoxLenCir.Text = Convert.ToString(circle.DCi.ElementAt(currentNum).Len);
                
                if (cylinder.DCy.Count > 0 && cylinder.DCy.Count > currentNum)
                {
                    textBoxVCyl.Text = Convert.ToString(cylinder.DCy.ElementAt(currentNum).Va);
                    textBoxSqCyl.Text= Convert.ToString(cylinder.DCy.ElementAt(currentNum).SqC);
                    avarageV = sumV / cylinder.DCy.Count;
                    textBoxSVCyl.Text = Convert.ToString(avarageV);
                }
                textBoxMaxSqCir.Text = Convert.ToString(maxSq);
                textBoxNo.Text = Convert.ToString(currentNum + 1);
            }
            catch
            {
                currentNum = 0; ;
            }
        }

      
    }
}
