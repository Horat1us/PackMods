namespace PackMods
{
    partial class PackMods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PackMods));
            this.modpack = new System.Windows.Forms.RadioButton();
            this.clearpack = new System.Windows.Forms.RadioButton();
            this.start_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.apply_button = new System.Windows.Forms.Button();
            this.launcher = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // modpack
            // 
            this.modpack.AutoSize = true;
            this.modpack.Location = new System.Drawing.Point(12, 15);
            this.modpack.Name = "modpack";
            this.modpack.Size = new System.Drawing.Size(74, 17);
            this.modpack.TabIndex = 0;
            this.modpack.TabStop = true;
            this.modpack.Text = "Mod Pack";
            this.modpack.UseVisualStyleBackColor = true;
            // 
            // clearpack
            // 
            this.clearpack.AutoSize = true;
            this.clearpack.Location = new System.Drawing.Point(92, 15);
            this.clearpack.Name = "clearpack";
            this.clearpack.Size = new System.Drawing.Size(77, 17);
            this.clearpack.TabIndex = 1;
            this.clearpack.TabStop = true;
            this.clearpack.Text = "Clear Pack";
            this.clearpack.UseVisualStyleBackColor = true;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(89, 62);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(106, 23);
            this.start_button.TabIndex = 2;
            this.start_button.Text = "Start Game";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developed by Inferik";
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(8, 62);
            this.apply_button.Name = "apply_button";
            this.apply_button.Size = new System.Drawing.Size(75, 23);
            this.apply_button.TabIndex = 4;
            this.apply_button.Text = "Apply";
            this.apply_button.UseVisualStyleBackColor = true;
            this.apply_button.Click += new System.EventHandler(this.apply_button_Click);
            // 
            // launcher
            // 
            this.launcher.AutoSize = true;
            this.launcher.Location = new System.Drawing.Point(12, 39);
            this.launcher.Name = "launcher";
            this.launcher.Size = new System.Drawing.Size(144, 17);
            this.launcher.TabIndex = 5;
            this.launcher.Text = "Start with WOTLauncher";
            this.launcher.UseVisualStyleBackColor = true;
            this.launcher.CheckedChanged += new System.EventHandler(this.launcher_CheckedChanged);
            // 
            // PackMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 116);
            this.Controls.Add(this.launcher);
            this.Controls.Add(this.apply_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.clearpack);
            this.Controls.Add(this.modpack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PackMods";
            this.Text = "PackMods";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton modpack;
        private System.Windows.Forms.RadioButton clearpack;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button apply_button;
        private System.Windows.Forms.CheckBox launcher;
    }
}

