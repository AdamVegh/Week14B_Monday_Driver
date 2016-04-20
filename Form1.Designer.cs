namespace Week14B_Monday_Driver
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
			this.listBoxFiles = new System.Windows.Forms.ListBox();
			this.comboBoxDrive = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPath = new System.Windows.Forms.TextBox();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBoxFiles
			// 
			this.listBoxFiles.FormattingEnabled = true;
			this.listBoxFiles.Location = new System.Drawing.Point(28, 110);
			this.listBoxFiles.Name = "listBoxFiles";
			this.listBoxFiles.Size = new System.Drawing.Size(426, 173);
			this.listBoxFiles.TabIndex = 0;
			this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
			// 
			// comboBoxDrive
			// 
			this.comboBoxDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDrive.FormattingEnabled = true;
			this.comboBoxDrive.Location = new System.Drawing.Point(121, 22);
			this.comboBoxDrive.Name = "comboBoxDrive";
			this.comboBoxDrive.Size = new System.Drawing.Size(333, 21);
			this.comboBoxDrive.Sorted = true;
			this.comboBoxDrive.TabIndex = 1;
			this.comboBoxDrive.SelectedIndexChanged += new System.EventHandler(this.comboBoxDrive_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(32, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Drive";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Path";
			// 
			// textBoxPath
			// 
			this.textBoxPath.Enabled = false;
			this.textBoxPath.Location = new System.Drawing.Point(121, 66);
			this.textBoxPath.Name = "textBoxPath";
			this.textBoxPath.Size = new System.Drawing.Size(333, 20);
			this.textBoxPath.TabIndex = 4;
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(28, 308);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(75, 23);
			this.buttonOpen.TabIndex = 5;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(109, 308);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(75, 23);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonBack
			// 
			this.buttonBack.Location = new System.Drawing.Point(190, 308);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(75, 23);
			this.buttonBack.TabIndex = 7;
			this.buttonBack.Text = "Back";
			this.buttonBack.UseVisualStyleBackColor = true;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 361);
			this.Controls.Add(this.buttonBack);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.textBoxPath);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBoxDrive);
			this.Controls.Add(this.listBoxFiles);
			this.MaximumSize = new System.Drawing.Size(500, 400);
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "Form1";
			this.Text = "Editing";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxFiles;
		private System.Windows.Forms.ComboBox comboBoxDrive;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPath;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonBack;
	}
}

