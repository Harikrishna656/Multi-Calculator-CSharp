
namespace prac
{
    partial class Multi_Calc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multi_Calc));
            this.btn_binary = new System.Windows.Forms.Button();
            this.btn_simple_calc = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_binary
            // 
            this.btn_binary.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_binary.Location = new System.Drawing.Point(30, 125);
            this.btn_binary.Name = "btn_binary";
            this.btn_binary.Size = new System.Drawing.Size(218, 34);
            this.btn_binary.TabIndex = 0;
            this.btn_binary.Text = "Binary Convertions";
            this.btn_binary.UseVisualStyleBackColor = true;
            this.btn_binary.Click += new System.EventHandler(this.btn_binary_Click);
            // 
            // btn_simple_calc
            // 
            this.btn_simple_calc.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_simple_calc.Location = new System.Drawing.Point(39, 37);
            this.btn_simple_calc.Name = "btn_simple_calc";
            this.btn_simple_calc.Size = new System.Drawing.Size(188, 36);
            this.btn_simple_calc.TabIndex = 1;
            this.btn_simple_calc.Text = "Simple Calculator";
            this.btn_simple_calc.UseVisualStyleBackColor = true;
            this.btn_simple_calc.Click += new System.EventHandler(this.btn_simple_calc_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Location = new System.Drawing.Point(95, 206);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(78, 39);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Multi_Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(272, 302);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_simple_calc);
            this.Controls.Add(this.btn_binary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "Multi_Calc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Calc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_binary;
        private System.Windows.Forms.Button btn_simple_calc;
        private System.Windows.Forms.Button btn_close;
    }
}