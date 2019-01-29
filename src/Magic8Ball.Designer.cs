namespace Magic8Ball
{
    partial class Magic8Ball
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
            this.viewport = new System.Windows.Forms.Panel();
            this.answerPicker = new System.Windows.Forms.Panel();
            this.answerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Label();
            this.answerPicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewport
            // 
            this.viewport.BackColor = System.Drawing.Color.Black;
            this.viewport.Location = new System.Drawing.Point(85, 85);
            this.viewport.Margin = new System.Windows.Forms.Padding(0);
            this.viewport.Name = "viewport";
            this.viewport.Size = new System.Drawing.Size(180, 180);
            this.viewport.TabIndex = 0;
            this.viewport.Paint += new System.Windows.Forms.PaintEventHandler(this.Viewport_Paint);
            this.viewport.MouseDown += new System.Windows.Forms.MouseEventHandler(this.General_MouseDown);
            this.viewport.MouseUp += new System.Windows.Forms.MouseEventHandler(this.General_MouseUp);
            // 
            // answerPicker
            // 
            this.answerPicker.BackColor = System.Drawing.Color.Blue;
            this.answerPicker.Controls.Add(this.answerLabel);
            this.answerPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.answerPicker.Location = new System.Drawing.Point(85, 85);
            this.answerPicker.Margin = new System.Windows.Forms.Padding(0);
            this.answerPicker.Name = "answerPicker";
            this.answerPicker.Size = new System.Drawing.Size(180, 180);
            this.answerPicker.TabIndex = 1;
            this.answerPicker.Visible = false;
            this.answerPicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.General_MouseDown);
            this.answerPicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.General_MouseUp);
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.BackColor = System.Drawing.Color.Transparent;
            this.answerLabel.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.White;
            this.answerLabel.Location = new System.Drawing.Point(0, 0);
            this.answerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(0, 16);
            this.answerLabel.TabIndex = 2;
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.General_MouseDown);
            this.answerLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.General_MouseUp);
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.White;
            this.exitButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(0, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(0, 16);
            this.exitButton.TabIndex = 3;
            this.exitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitButton.Paint += new System.Windows.Forms.PaintEventHandler(this.ExitButton_Paint);
            this.exitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            this.exitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.exitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // Magic8Ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.answerPicker);
            this.Controls.Add(this.viewport);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Magic8Ball";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magic8Ball";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.General_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.General_MouseUp);
            this.answerPicker.ResumeLayout(false);
            this.answerPicker.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel viewport;
        private System.Windows.Forms.Panel answerPicker;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label exitButton;
    }
}

