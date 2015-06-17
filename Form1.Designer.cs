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
            this.wotPathInput = new System.Windows.Forms.TextBox();
            this.changeWotPath = new System.Windows.Forms.Button();
            this.link = new System.Windows.Forms.LinkLabel();
            this.appName = new System.Windows.Forms.Label();
            this.appVersion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modpack
            // 
            this.modpack.AutoSize = true;
            this.modpack.Location = new System.Drawing.Point(12, 64);
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
            this.clearpack.Location = new System.Drawing.Point(93, 64);
            this.clearpack.Name = "clearpack";
            this.clearpack.Size = new System.Drawing.Size(77, 17);
            this.clearpack.TabIndex = 1;
            this.clearpack.TabStop = true;
            this.clearpack.Text = "Clear Pack";
            this.clearpack.UseVisualStyleBackColor = true;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(145, 90);
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
            this.label1.Location = new System.Drawing.Point(9, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Developed by Inferik";
            // 
            // apply_button
            // 
            this.apply_button.Location = new System.Drawing.Point(176, 61);
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
            this.launcher.Location = new System.Drawing.Point(12, 94);
            this.launcher.Name = "launcher";
            this.launcher.Size = new System.Drawing.Size(127, 17);
            this.launcher.TabIndex = 5;
            this.launcher.Text = "Using WOTLauncher";
            this.launcher.UseVisualStyleBackColor = true;
            this.launcher.CheckedChanged += new System.EventHandler(this.launcher_CheckedChanged);
            // 
            // wotPathInput
            // 
            this.wotPathInput.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wotPathInput.Location = new System.Drawing.Point(12, 33);
            this.wotPathInput.Name = "wotPathInput";
            this.wotPathInput.ReadOnly = true;
            this.wotPathInput.Size = new System.Drawing.Size(157, 20);
            this.wotPathInput.TabIndex = 6;
            // 
            // changeWotPath
            // 
            this.changeWotPath.Location = new System.Drawing.Point(176, 32);
            this.changeWotPath.Name = "changeWotPath";
            this.changeWotPath.Size = new System.Drawing.Size(75, 23);
            this.changeWotPath.TabIndex = 7;
            this.changeWotPath.Text = "Change";
            this.changeWotPath.UseVisualStyleBackColor = true;
            this.changeWotPath.Click += new System.EventHandler(this.changeWotPath_Click);
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.Location = new System.Drawing.Point(165, 117);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(87, 13);
            this.link.TabIndex = 8;
            this.link.TabStop = true;
            this.link.Text = "4cheat.ru Spetial";
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.appName.Location = new System.Drawing.Point(12, 10);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(113, 20);
            this.appName.TabIndex = 9;
            this.appName.Text = "PackMods Lite";
            // 
            // appVersion
            // 
            this.appVersion.AutoSize = true;
            this.appVersion.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.appVersion.Location = new System.Drawing.Point(216, 14);
            this.appVersion.Name = "appVersion";
            this.appVersion.Size = new System.Drawing.Size(34, 13);
            this.appVersion.TabIndex = 10;
            this.appVersion.Text = "v. 0.2";
            // 
            // PackMods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 139);
            this.Controls.Add(this.appVersion);
            this.Controls.Add(this.appName);
            this.Controls.Add(this.link);
            this.Controls.Add(this.changeWotPath);
            this.Controls.Add(this.wotPathInput);
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
        private System.Windows.Forms.TextBox wotPathInput;
        private System.Windows.Forms.Button changeWotPath;
        private System.Windows.Forms.LinkLabel link;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label appVersion;
    }
}

