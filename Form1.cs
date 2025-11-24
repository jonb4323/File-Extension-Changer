using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FileExtensionChanger
{
    public partial class Form1 : Form
    {
        private string[] extensions;
        private string selectedFilePath;     
        private string selectedExtension;   
        private int only_one; 

        public Form1() {
            InitializeComponent();

            // Hook up button events (designer already wires button1_Click for INPUT)
            start_btn.Click += start_btn_Click;
            select_file_from_list_btn.Click += select_file_from_list_btn_Click;
        }

        private void Form1_Load(object sender, EventArgs e) {
            status_label.Text = "Idle";

            try
            {
                // Make sure we load the extensions file from the same folder as the EXE
                string extFilePath = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory,
                    "file_extenstions.txt"
                );

                if (!File.Exists(extFilePath)) {
                    MessageBox.Show(
                        "The file 'file_extenstions.txt' was not found.\n\n" +
                        "Expected at:\n" + extFilePath,
                        "Extension list missing",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                extensions = File.ReadAllLines(extFilePath)
                                 .Where(line => !string.IsNullOrWhiteSpace(line))
                                 .Select(line => line.Trim())
                                 .Distinct()
                                 .ToArray();

                listBox1.Items.Clear();
                listBox1.Items.AddRange(extensions);
            }
            catch (Exception ex) {
                MessageBox.Show(
                    "Error loading extensions:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // INPUT button (wired in designer as button1_Click)
        private void button1_Click(object sender, EventArgs e) {
            only_one = 0;
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    selectedFilePath = openFileDialog.FileName;
                    status_label.Text = "File selected";
                }
            }
        }

        // "Select Ext." button
        private void select_file_from_list_btn_Click(object sender, EventArgs e) {
            if (listBox1.SelectedItem == null) {
                MessageBox.Show(
                    "Please select an extension from the list first.",
                    "No extension selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            selectedExtension = listBox1.SelectedItem.ToString();
            status_label.Text = "Extension: " + selectedExtension;
        }

        // GO button
        private void start_btn_Click(object sender, EventArgs e) {
            only_one = 1;
            if (string.IsNullOrEmpty(selectedFilePath))
            {
                MessageBox.Show(
                    "Please select a file first using the INPUT button.",
                    "No file selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (string.IsNullOrEmpty(selectedExtension)) {
                MessageBox.Show(
                    "Please select an extension from the list and click 'Select Ext.'.",
                    "No extension selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            try {
                status_label.Text = "Converting...";

                // Desktop path
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

                // Clean extension (remove dot if user put ".txt")
                string newExt = selectedExtension.Trim();
                if (newExt.StartsWith("."))
                    newExt = newExt.Substring(1);

                // New file name on desktop
                string newFileName = Path.GetFileNameWithoutExtension(selectedFilePath) + "." + newExt;
                string destinationPath = Path.Combine(desktopPath, newFileName);

                // Copy the file to the desktop with the new extension
                File.Copy(selectedFilePath, destinationPath, true);

                status_label.Text = "DONE";

                if (only_one == 1) {
                    MessageBox.Show(
                        "File converted and saved to your Desktop as:\n\n" + destinationPath,
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                status_label.Text = "Idle";
            }
            catch (Exception ex) {
                status_label.Text = "Error";

                MessageBox.Show(
                    "Something went wrong while converting the file:\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
