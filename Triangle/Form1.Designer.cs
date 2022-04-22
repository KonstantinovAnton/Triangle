
namespace Triangle
{
    partial class MainWindow
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelForDoing = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelZ = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panelResult = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelResult.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(527, 67);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "Программа, определяющая тип треугольника по сторонам";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.textBoxX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxX.Location = new System.Drawing.Point(38, 69);
            this.textBoxX.Multiline = true;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(87, 20);
            this.textBoxX.TabIndex = 1;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.textBoxY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxY.Location = new System.Drawing.Point(37, 69);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(87, 20);
            this.textBoxY.TabIndex = 2;
            // 
            // textBoxZ
            // 
            this.textBoxZ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.textBoxZ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxZ.Location = new System.Drawing.Point(41, 69);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(87, 20);
            this.textBoxZ.TabIndex = 3;
            // 
            // labelForDoing
            // 
            this.labelForDoing.AutoSize = true;
            this.labelForDoing.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForDoing.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForDoing.Location = new System.Drawing.Point(144, 48);
            this.labelForDoing.Name = "labelForDoing";
            this.labelForDoing.Size = new System.Drawing.Size(245, 19);
            this.labelForDoing.TabIndex = 4;
            this.labelForDoing.Text = "Введите длины сторон треугольника";
            // 
            // labelX
            // 
            this.labelX.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelX.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelX.Location = new System.Drawing.Point(0, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(161, 58);
            this.labelX.TabIndex = 5;
            this.labelX.Text = "Первая сторона";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelY.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelY.Location = new System.Drawing.Point(0, 0);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(161, 58);
            this.labelY.TabIndex = 6;
            this.labelY.Text = "Вторая сторона";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelZ
            // 
            this.labelZ.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelZ.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelZ.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelZ.Location = new System.Drawing.Point(0, 0);
            this.labelZ.Name = "labelZ";
            this.labelZ.Size = new System.Drawing.Size(161, 58);
            this.labelZ.TabIndex = 7;
            this.labelZ.Text = "Третья сторона";
            this.labelZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            this.buttonEnter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEnter.Location = new System.Drawing.Point(215, 245);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(130, 23);
            this.buttonEnter.TabIndex = 8;
            this.buttonEnter.Text = "Определить!";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelResult
            // 
            this.labelResult.AllowDrop = true;
            this.labelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelResult.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelResult.Location = new System.Drawing.Point(0, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(448, 100);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "Введите длины сторон";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClear
            // 
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(215, 413);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(130, 23);
            this.buttonClear.TabIndex = 10;
            this.buttonClear.Text = "Очистить поля";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(70)))), ((int)(((byte)(45)))));
            this.panelResult.Controls.Add(this.labelResult);
            this.panelResult.Location = new System.Drawing.Point(56, 288);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(448, 100);
            this.panelResult.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Controls.Add(this.labelForDoing);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 76);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelX);
            this.panel2.Controls.Add(this.textBoxX);
            this.panel2.Location = new System.Drawing.Point(32, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(161, 100);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelY);
            this.panel3.Controls.Add(this.textBoxY);
            this.panel3.Location = new System.Drawing.Point(199, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(161, 100);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelZ);
            this.panel4.Controls.Add(this.textBoxZ);
            this.panel4.Location = new System.Drawing.Point(366, 124);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(161, 100);
            this.panel4.TabIndex = 15;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(86)))), ((int)(((byte)(61)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(558, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "MainWindow";
            this.Text = "Тип треугольника";
            this.panelResult.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.Label labelForDoing;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelZ;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

