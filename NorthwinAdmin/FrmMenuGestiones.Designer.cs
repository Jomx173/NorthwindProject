namespace NorthwinAdmin
{
    partial class FrmMenuGestiones
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
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            label8 = new Label();
            btnEmpleados = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1083, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(30, 24);
            label1.Name = "label1";
            label1.Size = new Size(285, 46);
            label1.TabIndex = 1;
            label1.Text = "Panel de Control";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SteelBlue;
            label8.Location = new Point(30, 52);
            label8.Name = "label8";
            label8.Size = new Size(1020, 35);
            label8.TabIndex = 2;
            label8.Text = "___________________________________________________________________";
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = SystemColors.InactiveBorder;
            btnEmpleados.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.Location = new Point(42, 119);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(315, 207);
            btnEmpleados.TabIndex = 3;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveBorder;
            button2.Location = new Point(380, 119);
            button2.Name = "button2";
            button2.Size = new Size(315, 207);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InactiveBorder;
            button3.Location = new Point(719, 119);
            button3.Name = "button3";
            button3.Size = new Size(315, 207);
            button3.TabIndex = 5;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.InactiveBorder;
            button4.Location = new Point(42, 355);
            button4.Name = "button4";
            button4.Size = new Size(315, 207);
            button4.TabIndex = 6;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.InactiveBorder;
            button5.Location = new Point(380, 355);
            button5.Name = "button5";
            button5.Size = new Size(315, 207);
            button5.TabIndex = 7;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.InactiveBorder;
            button6.Location = new Point(719, 355);
            button6.Name = "button6";
            button6.Size = new Size(315, 207);
            button6.TabIndex = 8;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = false;
            // 
            // FrmMenuGestiones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 596);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnEmpleados);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(label8);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuGestiones";
            Text = "FrmMenuGestiones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label8;
        private Button btnEmpleados;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}