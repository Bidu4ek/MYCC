namespace MYCC
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSCir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLenCir = new System.Windows.Forms.TextBox();
            this.textBoxVCyl = new System.Windows.Forms.TextBox();
            this.textBoxSqCyl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxMaxSqCir = new System.Windows.Forms.TextBox();
            this.textBoxSVCyl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Circle = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Radius = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCylinderH = new System.Windows.Forms.TextBox();
            this.textBoxRadius = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNo = new System.Windows.Forms.TextBox();
            this.Result.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.Circle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Controls.Add(this.textBoxNo);
            this.Result.Controls.Add(this.tableLayoutPanel2);
            this.Result.Controls.Add(this.button2);
            this.Result.Controls.Add(this.label2);
            this.Result.Controls.Add(this.button1);
            this.Result.Controls.Add(this.textBoxMaxSqCir);
            this.Result.Controls.Add(this.textBoxSVCyl);
            this.Result.Controls.Add(this.label7);
            this.Result.Controls.Add(this.label6);
            this.Result.Location = new System.Drawing.Point(4, 25);
            this.Result.Name = "Result";
            this.Result.Padding = new System.Windows.Forms.Padding(3);
            this.Result.Size = new System.Drawing.Size(793, 437);
            this.Result.TabIndex = 2;
            this.Result.Text = "Результат";
            this.Result.UseVisualStyleBackColor = true;
            this.Result.Click += new System.EventHandler(this.Result_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.49263F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.50737F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSCir, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxLenCir, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxVCyl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxSqCyl, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 162);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Площадь окружности";
            // 
            // textBoxSCir
            // 
            this.textBoxSCir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSCir.Location = new System.Drawing.Point(164, 11);
            this.textBoxSCir.Name = "textBoxSCir";
            this.textBoxSCir.ReadOnly = true;
            this.textBoxSCir.Size = new System.Drawing.Size(170, 22);
            this.textBoxSCir.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Длина окружности";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Объем цилиндра";
            // 
            // textBoxLenCir
            // 
            this.textBoxLenCir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLenCir.Location = new System.Drawing.Point(164, 55);
            this.textBoxLenCir.Name = "textBoxLenCir";
            this.textBoxLenCir.ReadOnly = true;
            this.textBoxLenCir.Size = new System.Drawing.Size(170, 22);
            this.textBoxLenCir.TabIndex = 10;
            // 
            // textBoxVCyl
            // 
            this.textBoxVCyl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxVCyl.Location = new System.Drawing.Point(164, 96);
            this.textBoxVCyl.Name = "textBoxVCyl";
            this.textBoxVCyl.ReadOnly = true;
            this.textBoxVCyl.Size = new System.Drawing.Size(170, 22);
            this.textBoxVCyl.TabIndex = 6;
            // 
            // textBoxSqCyl
            // 
            this.textBoxSqCyl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxSqCyl.Location = new System.Drawing.Point(164, 133);
            this.textBoxSqCyl.Name = "textBoxSqCyl";
            this.textBoxSqCyl.ReadOnly = true;
            this.textBoxSqCyl.Size = new System.Drawing.Size(170, 22);
            this.textBoxSqCyl.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Площадь цилиндра";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(479, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 59);
            this.button2.TabIndex = 11;
            this.button2.Text = "⇨";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Vineta BT", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(258, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 59);
            this.button1.TabIndex = 10;
            this.button1.Text = "⇦";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMaxSqCir
            // 
            this.textBoxMaxSqCir.Location = new System.Drawing.Point(664, 76);
            this.textBoxMaxSqCir.Name = "textBoxMaxSqCir";
            this.textBoxMaxSqCir.ReadOnly = true;
            this.textBoxMaxSqCir.Size = new System.Drawing.Size(123, 22);
            this.textBoxMaxSqCir.TabIndex = 9;
            // 
            // textBoxSVCyl
            // 
            this.textBoxSVCyl.Location = new System.Drawing.Point(664, 32);
            this.textBoxSVCyl.Name = "textBoxSVCyl";
            this.textBoxSVCyl.ReadOnly = true;
            this.textBoxSVCyl.Size = new System.Drawing.Size(123, 22);
            this.textBoxSVCyl.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Средний объем цилиндров";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(248, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Максимальная площадь окружности";
            // 
            // Circle
            // 
            this.Circle.Controls.Add(this.tableLayoutPanel1);
            this.Circle.Controls.Add(this.buttonAdd);
            this.Circle.Location = new System.Drawing.Point(4, 25);
            this.Circle.Name = "Circle";
            this.Circle.Padding = new System.Windows.Forms.Padding(3);
            this.Circle.Size = new System.Drawing.Size(793, 437);
            this.Circle.TabIndex = 0;
            this.Circle.Text = "Задать";
            this.Circle.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.53782F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.46218F));
            this.tableLayoutPanel1.Controls.Add(this.Radius, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCylinderH, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxRadius, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 15);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 100);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // Radius
            // 
            this.Radius.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Radius.AutoSize = true;
            this.Radius.Location = new System.Drawing.Point(3, 16);
            this.Radius.Name = "Radius";
            this.Radius.Size = new System.Drawing.Size(136, 17);
            this.Radius.TabIndex = 0;
            this.Radius.Text = "Радиус окружности";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Высота цилиндра";
            // 
            // textBoxCylinderH
            // 
            this.textBoxCylinderH.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCylinderH.Location = new System.Drawing.Point(162, 64);
            this.textBoxCylinderH.Name = "textBoxCylinderH";
            this.textBoxCylinderH.Size = new System.Drawing.Size(175, 22);
            this.textBoxCylinderH.TabIndex = 9;
            // 
            // textBoxRadius
            // 
            this.textBoxRadius.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxRadius.Location = new System.Drawing.Point(162, 14);
            this.textBoxRadius.Name = "textBoxRadius";
            this.textBoxRadius.Size = new System.Drawing.Size(175, 22);
            this.textBoxRadius.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(374, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 59);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Circle);
            this.tabControl1.Controls.Add(this.Result);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "№";
            // 
            // textBoxNo
            // 
            this.textBoxNo.Location = new System.Drawing.Point(383, 267);
            this.textBoxNo.Name = "textBoxNo";
            this.textBoxNo.ReadOnly = true;
            this.textBoxNo.Size = new System.Drawing.Size(56, 22);
            this.textBoxNo.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 338);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Result.ResumeLayout(false);
            this.Result.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.Circle.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLenCir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSCir;
        private System.Windows.Forms.TextBox textBoxVCyl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxMaxSqCir;
        private System.Windows.Forms.TextBox textBoxSVCyl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Circle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Radius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCylinderH;
        private System.Windows.Forms.TextBox textBoxRadius;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textBoxSqCyl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNo;
        private System.Windows.Forms.Label label2;
    }
}

