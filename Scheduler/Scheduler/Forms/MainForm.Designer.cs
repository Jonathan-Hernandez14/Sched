namespace Scheduler.Forms
{
    partial class MainForm
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
            this.MainFormTLP = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.AddPersonButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainFormTLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTLP
            // 
            this.MainFormTLP.ColumnCount = 2;
            this.MainFormTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormTLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainFormTLP.Controls.Add(this.button3, 0, 2);
            this.MainFormTLP.Controls.Add(this.AddPersonButton, 0, 0);
            this.MainFormTLP.Controls.Add(this.button2, 0, 1);
            this.MainFormTLP.Controls.Add(this.label1, 1, 0);
            this.MainFormTLP.Controls.Add(this.label2, 1, 1);
            this.MainFormTLP.Controls.Add(this.label3, 1, 2);
            this.MainFormTLP.Location = new System.Drawing.Point(12, 12);
            this.MainFormTLP.Name = "MainFormTLP";
            this.MainFormTLP.RowCount = 3;
            this.MainFormTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.12281F));
            this.MainFormTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.87719F));
            this.MainFormTLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.MainFormTLP.Size = new System.Drawing.Size(377, 426);
            this.MainFormTLP.TabIndex = 0;
            this.MainFormTLP.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormTLP_Paint);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(19, 320);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 75);
            this.button3.TabIndex = 4;
            this.button3.Text = "Generar Asignaciones";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // AddPersonButton
            // 
            this.AddPersonButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddPersonButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddPersonButton.Location = new System.Drawing.Point(19, 33);
            this.AddPersonButton.Name = "AddPersonButton";
            this.AddPersonButton.Size = new System.Drawing.Size(150, 75);
            this.AddPersonButton.TabIndex = 0;
            this.AddPersonButton.Text = "Agregar Persona";
            this.AddPersonButton.UseVisualStyleBackColor = true;
            this.AddPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(19, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 75);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ver Lista";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(206, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 42);
            this.label1.TabIndex = 5;
            this.label1.Text = "Agregar personas al configurador";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(198, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ver lista de personas y editarla";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(191, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 42);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generar lista mensual de asignaciones";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 450);
            this.Controls.Add(this.MainFormTLP);
            this.Name = "MainForm";
            this.Text = "Configurador de Exhibidores";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainFormTLP.ResumeLayout(false);
            this.MainFormTLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainFormTLP;
        private Button AddPersonButton;
        private Button button3;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}