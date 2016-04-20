using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Week14B_Monday_Driver
{
	public partial class Form1 : Form
	{
		public DriveInfo[] Drives { get; private set; }
		public string currentDrive;
		public DirectoryInfo currentDir;
		public FileInfo[] currentFiles;
		public DirectoryInfo[] currentDirs;
		public FileSystemInfo selectedFile;
		public bool isDirectory;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Drives = DriveInfo.GetDrives();
			comboBoxDrive.Items.AddRange(Drives);
		}

		private void setupItems(DirectoryInfo currentDir)
		{
			try
			{
				listBoxFiles.Items.Clear();
				currentFiles = currentDir.GetFiles();
				currentDirs = currentDir.GetDirectories();
				currentDir = currentDir.Parent;
				listBoxFiles.Items.AddRange(currentFiles);
				listBoxFiles.Items.AddRange(currentDirs);
			}
			catch (Exception)
			{
				return;
			}
		}

		private void comboBoxDrive_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				textBoxPath.Text = comboBoxDrive.SelectedItem.ToString();
				currentDrive = textBoxPath.Text;
				listBoxFiles.Items.Clear();
				selectedFile = null;
				currentDir = Directory.CreateDirectory(currentDrive);
				setupItems(currentDir);
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show("This drive has no directories!", "Warning!");
			}
		}

		private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				selectedFile = (FileSystemInfo)listBoxFiles.SelectedItem;
				textBoxPath.Text = selectedFile.FullName;

				if ((selectedFile.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
					isDirectory = true;
				else
					isDirectory = false;
			}
			catch (Exception)
			{
				return;
			}
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			if (isDirectory && selectedFile != null)
			{
				currentDir = (DirectoryInfo)selectedFile;
				setupItems(currentDir);
			}

			else if (!isDirectory && selectedFile != null)
			{
				try
				{
					MessageBox.Show(File.ReadAllText(selectedFile.FullName), "Hello");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.StackTrace, "Hello");
				}
			}
			else
				return;
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{
			try
			{
				currentDir = currentDir.Parent;
				MessageBox.Show(currentDir.FullName);
				textBoxPath.Text = currentDir.FullName;
				setupItems(currentDir);
			}
			catch (Exception)
			{
				selectedFile = null;
				listBoxFiles.Items.Clear();
				return;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			string deleteFile = selectedFile == null ? null : "Delete file: " + selectedFile.Name;
			if (deleteFile != null && !isDirectory && (MessageBox.Show("Are sure in your selection?", deleteFile, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
			{
				selectedFile.Delete();
				setupItems(currentDir);
				textBoxPath.Text = currentDir.FullName;
				selectedFile = null;
			}
			else
				return;
		}
	}
}
