namespace Teacher_program
{
    partial class exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(exit));
            this.B_Exit = new System.Windows.Forms.Button();
            this.B_No_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // B_Exit
            // 
            resources.ApplyResources(this.B_Exit, "B_Exit");
            this.B_Exit.Name = "B_Exit";
            this.B_Exit.UseVisualStyleBackColor = true;
            this.B_Exit.Click += new System.EventHandler(this.b_exit);
            // 
            // B_No_Exit
            // 
            resources.ApplyResources(this.B_No_Exit, "B_No_Exit");
            this.B_No_Exit.Name = "B_No_Exit";
            this.B_No_Exit.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.B_No_Exit);
            this.Controls.Add(this.B_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "exit";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button B_Exit;
        private System.Windows.Forms.Button B_No_Exit;
    }
}