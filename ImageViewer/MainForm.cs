using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ImageViewer
{
    public partial class MainForm : Form
    {
        private string currentDirectory = "";
        private float zoomFactor = 1.0f;
        private const float zoomIncrement = 0.25f;
        private const float minZoom = 0.25f;
        private const float maxZoom = 5.0f;

        public MainForm()
        {
            InitializeComponent();
        }

        private void loadFolderButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                // Set initial directory if we have one already
                if (!string.IsNullOrEmpty(currentDirectory))
                {
                    dialog.SelectedPath = currentDirectory;
                }

                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadImagesFromFolder(dialog.SelectedPath);
                }
            }
        }

        private void LoadImagesFromFolder(string path)
        {
            try
            {
                currentDirectory = path;
                thumbnailsPanel.Controls.Clear();
                statusLabel.Text = $"Loading images from: {path}";

                // Get all image files
                string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                var imageFiles = Directory.GetFiles(path)
                    .Where(file => imageExtensions.Contains(Path.GetExtension(file).ToLower()))
                    .ToArray();

                foreach (var file in imageFiles)
                {
                    try
                    {
                        // Create thumbnail
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        pictureBox.Margin = new Padding(5);
                        pictureBox.Tag = file;
                        pictureBox.Cursor = Cursors.Hand;

                        // Load image with error handling
                        using (var img = Image.FromFile(file))
                        {
                            pictureBox.Image = new Bitmap(img, pictureBox.Width, pictureBox.Height);
                        }

                        pictureBox.Click += PictureBox_Click;
                        thumbnailsPanel.Controls.Add(pictureBox);
                    }
                    catch (Exception ex)
                    {
                        // Skip problematic images
                        Console.WriteLine($"Error loading {file}: {ex.Message}");
                    }
                }

                // Load first image if available
                if (imageFiles.Length > 0)
                {
                    LoadImageIntoViewer(imageFiles[0]);
                }

                statusLabel.Text = $"{imageFiles.Length} images loaded from {path}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading folder: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                statusLabel.Text = "Error loading folder.";
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                string imgPath = pictureBox.Tag.ToString();
                LoadImageIntoViewer(imgPath);
            }
        }

        private void LoadImageIntoViewer(string imagePath)
        {
            try
            {
                // Clear previous image
                if (mainPictureBox.Image != null)
                {
                    mainPictureBox.Image.Dispose();
                    mainPictureBox.Image = null;
                }

                // Load new image
                mainPictureBox.Image = Image.FromFile(imagePath);
                mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                zoomFactor = 1.0f; // Reset zoom when loading a new image
                fileInfoLabel.Text = $"File: {Path.GetFileName(imagePath)} ({GetFileSize(imagePath)})";
                statusLabel.Text = $"Image loaded: {imagePath}";
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"Error loading image: {ex.Message}";
            }
        }

        private string GetFileSize(string filePath)
        {
            var info = new FileInfo(filePath);
            long bytes = info.Length;
            if (bytes < 1024)
                return $"{bytes} B";
            else if (bytes < 1024 * 1024)
                return $"{bytes / 1024.0:F1} KB";
            else
                return $"{bytes / (1024.0 * 1024.0):F1} MB";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zoomInButton_Click(object sender, EventArgs e)
        {
            ApplyZoom(zoomFactor + zoomIncrement);
        }

        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            ApplyZoom(zoomFactor - zoomIncrement);
        }

        private void ApplyZoom(float newZoom)
        {
            if (mainPictureBox.Image == null)
                return;

            // Ensure zoom factor is within boundaries
            newZoom = Math.Max(minZoom, Math.Min(maxZoom, newZoom));

            if (newZoom != zoomFactor)
            {
                zoomFactor = newZoom;

                // Change PictureBox display mode based on zoom factor
                if (zoomFactor == 1.0f)
                {
                    mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    mainPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

                    // Create a new bitmap with the adjusted size
                    int width = (int)(mainPictureBox.Image.Width * zoomFactor);
                    int height = (int)(mainPictureBox.Image.Height * zoomFactor);

                    // Save the original image
                    Image originalImage = mainPictureBox.Image;

                    // Create a new bitmap with the zoomed dimensions
                    Bitmap zoomedImage = new Bitmap(width, height);
                    using (Graphics g = Graphics.FromImage(zoomedImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.DrawImage(originalImage, 0, 0, width, height);
                    }

                    // Update the picture box
                    mainPictureBox.Image = zoomedImage;

                    // Dispose the original image if it's not the source
                    if (originalImage != mainPictureBox.Image.Tag)
                    {
                        originalImage.Dispose();
                    }
                }

                statusLabel.Text = $"Zoom: {zoomFactor:P0}";
            }
        }

        private void rotateButton_Click(object sender, EventArgs e)
        {
            if (mainPictureBox.Image != null)
            {
                // Save the original image
                Image originalImage = mainPictureBox.Image;

                // Create a new rotated image
                Bitmap rotatedImage = new Bitmap(originalImage.Height, originalImage.Width);
                using (Graphics g = Graphics.FromImage(rotatedImage))
                {
                    g.TranslateTransform(rotatedImage.Width / 2f, rotatedImage.Height / 2f);
                    g.RotateTransform(90);
                    g.TranslateTransform(-originalImage.Width / 2f, -originalImage.Height / 2f);
                    g.DrawImage(originalImage, new Point(0, 0));
                }

                // Update the picture box
                mainPictureBox.Image = rotatedImage;

                // Dispose the original image if it's not the source
                if (originalImage != mainPictureBox.Image.Tag)
                {
                    originalImage.Dispose();
                }

                statusLabel.Text = "Image rotated 90° clockwise";
            }
        }
    }
}