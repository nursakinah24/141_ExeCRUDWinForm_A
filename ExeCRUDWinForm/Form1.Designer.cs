
namespace ExeCRUDWinForm
{
    partial class Form1
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pet Shop Database";
            // 
            // button5
            // 
            this.button5.Image = global::ExeCRUDWinForm.Properties.Resources.pay;
            this.button5.Location = new System.Drawing.Point(631, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 106);
            this.button5.TabIndex = 8;
            this.button5.Text = "Pembayaran";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::ExeCRUDWinForm.Properties.Resources.transaction;
            this.button4.Location = new System.Drawing.Point(477, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 106);
            this.button4.TabIndex = 7;
            this.button4.Text = "Transaksi";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::ExeCRUDWinForm.Properties.Resources.buyer;
            this.button3.Location = new System.Drawing.Point(330, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 106);
            this.button3.TabIndex = 6;
            this.button3.Text = "Pembeli";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::ExeCRUDWinForm.Properties.Resources.pet_food;
            this.button2.Location = new System.Drawing.Point(178, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 106);
            this.button2.TabIndex = 5;
            this.button2.Text = "Barang";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::ExeCRUDWinForm.Properties.Resources.inventory;
            this.button1.Location = new System.Drawing.Point(28, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 106);
            this.button1.TabIndex = 0;
            this.button1.Text = "Supplier";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(797, 328);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

