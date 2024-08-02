
namespace automation.sentinela_system
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.empresarial = new System.Windows.Forms.Button();
            this.residencial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(816, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Antes de começar, você nos contatou para um serviço empresarial ou residencial?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // empresarial
            // 
            this.empresarial.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresarial.Location = new System.Drawing.Point(114, 156);
            this.empresarial.Name = "empresarial";
            this.empresarial.Size = new System.Drawing.Size(206, 81);
            this.empresarial.TabIndex = 1;
            this.empresarial.Text = "Empresarial";
            this.empresarial.UseVisualStyleBackColor = true;
            this.empresarial.Click += new System.EventHandler(this.button1_Click);
            // 
            // residencial
            // 
            this.residencial.Font = new System.Drawing.Font("Bodoni MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.residencial.Location = new System.Drawing.Point(482, 156);
            this.residencial.Name = "residencial";
            this.residencial.Size = new System.Drawing.Size(206, 81);
            this.residencial.TabIndex = 2;
            this.residencial.Text = "Residencial";
            this.residencial.UseVisualStyleBackColor = true;
            this.residencial.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 329);
            this.Controls.Add(this.residencial);
            this.Controls.Add(this.empresarial);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button empresarial;
        private System.Windows.Forms.Button residencial;
    }
}