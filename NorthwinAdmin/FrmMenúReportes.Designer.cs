namespace NorthwinAdmin
{
    partial class FrmMenúReportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenúReportes));
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            btnVolver = new Button();
            imageList1 = new ImageList(components);
            panel2 = new Panel();
            button3 = new Button();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            label6 = new Label();
            label3 = new Label();
            imageList2 = new ImageList(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 13);
            label1.Name = "label1";
            label1.Size = new Size(350, 49);
            label1.TabIndex = 0;
            label1.Text = "Menú  de Reportes";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 62);
            label2.Name = "label2";
            label2.Size = new Size(288, 20);
            label2.TabIndex = 1;
            label2.Text = "Seleccione el reporte que desea consultar.";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(btnVolver);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(926, 99);
            panel1.TabIndex = 2;
            // 
            // btnVolver
            // 
            btnVolver.Font = new Font("Segoe UI Emoji", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ImageAlign = ContentAlignment.MiddleRight;
            btnVolver.ImageIndex = 0;
            btnVolver.ImageList = imageList1;
            btnVolver.Location = new Point(785, 28);
            btnVolver.Name = "btnVolver";
            btnVolver.RightToLeft = RightToLeft.Yes;
            btnVolver.Size = new Size(109, 36);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.TextAlign = ContentAlignment.MiddleLeft;
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Volver.png");
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(520, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 209);
            panel2.TabIndex = 3;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(113, 151);
            button3.Name = "button3";
            button3.Size = new Size(159, 41);
            button3.TabIndex = 7;
            button3.Text = "Ver reporte";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(22, 118);
            label5.Name = "label5";
            label5.Size = new Size(335, 20);
            label5.TabIndex = 5;
            label5.Text = "Consulta el desempeño comercial por empleado.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(85, 95);
            label4.Name = "label4";
            label4.Size = new Size(203, 23);
            label4.TabIndex = 4;
            label4.Text = "VENTAS POR EMPLEADO";
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(75, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(364, 209);
            panel3.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(102, 151);
            button2.Name = "button2";
            button2.Size = new Size(159, 41);
            button2.TabIndex = 3;
            button2.Text = "Ver reporte";
            button2.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(52, 118);
            label6.Name = "label6";
            label6.Size = new Size(249, 20);
            label6.TabIndex = 6;
            label6.Text = "Consulta el total vendido por clente.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(82, 95);
            label3.Name = "label3";
            label3.Size = new Size(179, 23);
            label3.TabIndex = 3;
            label3.Text = "VENTAS POR CLIENTE\r\n";
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "Empleado.png");
            // 
            // FrmMenúReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 409);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmMenúReportes";
            Text = "FrmMenúReportes";
            Load += FrmMenúReportes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel panel1;
        private Button btnVolver;
        private Panel panel2;
        private Panel panel3;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button3;
        private Button button2;
        private Label label6;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}