
namespace W7_T2_GuessTheNumber
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
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbEnteredNumberField = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTryCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(118, 41);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(90, 26);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // tbEnteredNumberField
            // 
            this.tbEnteredNumberField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbEnteredNumberField.Location = new System.Drawing.Point(12, 41);
            this.tbEnteredNumberField.Name = "tbEnteredNumberField";
            this.tbEnteredNumberField.Size = new System.Drawing.Size(100, 26);
            this.tbEnteredNumberField.TabIndex = 1;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(12, 111);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(51, 20);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblTryCount
            // 
            this.lblTryCount.AutoSize = true;
            this.lblTryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTryCount.Location = new System.Drawing.Point(12, 140);
            this.lblTryCount.Name = "lblTryCount";
            this.lblTryCount.Size = new System.Drawing.Size(51, 20);
            this.lblTryCount.TabIndex = 5;
            this.lblTryCount.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 166);
            this.Controls.Add(this.lblTryCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.tbEnteredNumberField);
            this.Controls.Add(this.btnEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox tbEnteredNumberField;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTryCount;
    }
}

