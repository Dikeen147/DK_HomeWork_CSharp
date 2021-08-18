
namespace W7_T1_Doubler
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnMulti = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblMultiCmdCount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(240, 45);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 33);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(240, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 33);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+1";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnMulti
            // 
            this.btnMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMulti.Location = new System.Drawing.Point(240, 123);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(94, 33);
            this.btnMulti.TabIndex = 2;
            this.btnMulti.Text = "*2";
            this.btnMulti.UseVisualStyleBackColor = true;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(12, 51);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(51, 20);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "label1";
            // 
            // lblMultiCmdCount
            // 
            this.lblMultiCmdCount.AutoSize = true;
            this.lblMultiCmdCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMultiCmdCount.Location = new System.Drawing.Point(12, 177);
            this.lblMultiCmdCount.Name = "lblMultiCmdCount";
            this.lblMultiCmdCount.Size = new System.Drawing.Size(141, 20);
            this.lblMultiCmdCount.TabIndex = 4;
            this.lblMultiCmdCount.Text = "Кол-во удвоений:";
            // 
            // button1
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Location = new System.Drawing.Point(240, 162);
            this.btnCancel.Name = "button1";
            this.btnCancel.Size = new System.Drawing.Size(94, 33);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblMultiCmdCount);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblMultiCmdCount;
        private System.Windows.Forms.Button btnCancel;
    }
}

