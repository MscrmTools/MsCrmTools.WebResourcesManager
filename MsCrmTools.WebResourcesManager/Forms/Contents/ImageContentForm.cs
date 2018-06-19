using MscrmTools.WebresourcesManager.AppCode;
using Svg;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MscrmTools.WebresourcesManager.Forms.Contents
{
    public partial class ImageContentForm : BaseContentForm
    {
        private PictureBox pb;

        public ImageContentForm(MyPluginControl control, Webresource resource) : base(control, resource, isImage: true)
        {
            InitializeComponent();

            pb = new PictureBox();

            resource.ContentReplaced += Resource_ContentReplaced;

            Text = resource.Name;
        }

        protected override void ClearEvents()
        {
            Resource.ContentReplaced -= Resource_ContentReplaced;
        }

        private void ImageContentForm_Load(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void ImageContentForm_Resize(object sender, EventArgs e)
        {
            ShowImage();
        }

        private void Resource_ContentReplaced(object sender, AppCode.Args.ResourceEventArgs e)
        {
            ShowImage(true);
        }

        private void ShowImage(bool force = false)
        {
            if (Resource == null)
            {
                return;
            }

            if (SavedSize.Equals(Size) && force == false)
            {
                return;
            }

            SavedSize = Size;

            var ctrls = Controls.OfType<PictureBox>().ToList();
            foreach (var ctrl in ctrls)
            {
                Controls.Remove(ctrl);
            }

            if (pb == null)
            {
                pb = new PictureBox();
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            try
            {
                byte[] imageBytes = Convert.FromBase64String(Resource.Content);

                if (Resource.Type == (int)WebresourceType.Vector)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        using (StreamReader reader = new StreamReader(ms))
                        {
                            using (var xmlStream = new MemoryStream(Encoding.Default.GetBytes(reader.ReadToEnd())))
                            {
                                xmlStream.Position = 0;
                                SvgDocument svgDoc = SvgDocument.Open<SvgDocument>(xmlStream);

                                pb.Height = 32;
                                pb.Width = 32;
                                pb.Image = svgDoc.Draw();
                                // pb.Image = svgDoc.Draw(32, 32);
                                pb.Location = new Point(
                                    Width / 2 - pb.Width / 2,
                                    Height / 2 - pb.Height / 2);
                            }
                        }
                    }
                }
                else
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        var image = Image.FromStream(ms, true, true);

                        FrameDimension frameDimensions = new FrameDimension(image.FrameDimensionsList[0]);
                        int frames = image.GetFrameCount(frameDimensions);
                        if (frames > 1)
                        {
                            lblError.Text = @"This image is an animated GIF and cannot be rendered";
                            pnlError.Visible = true;
                        }
                        else
                        {
                            if (image.Height == 32 && image.Width == 32)
                            {
                                pb.Image = image;
                                pb.Height = pb.Image.Size.Height;
                                pb.Width = pb.Image.Size.Width;
                                pb.BackColor = Color.Blue;
                                lblError.Text = @"Entity Large icon detected (size: 32x32): A blue background has been added to provide a better display of the icon";
                                pnlError.Visible = true;
                            }
                            else if (image.Height == 71 && image.Width == 85)
                            {
                                Bitmap bm = new Bitmap(205, 83);
                                using (Graphics gr = Graphics.FromImage(bm))
                                {
                                    gr.SmoothingMode = SmoothingMode.AntiAlias;

                                    Rectangle rect = new Rectangle(0, 0, 205, 83);
                                    gr.FillRectangle(new SolidBrush(Color.FromArgb(45, 116, 234)), rect);
                                    gr.DrawImage(image, new Point(110, 6));
                                }

                                pb.Image = bm;
                                pb.Height = 83;
                                pb.Width = 205;
                                lblError.Text = @"SiteMap Area icon detected (size: 85x71): A blue background has been added to provide a better display of the icon";
                                pnlError.Visible = true;
                            }
                            else
                            {
                                pb.Image = image;
                                pb.Height = pb.Image.Size.Height;
                                pb.Width = pb.Image.Size.Width;

                                pnlError.Visible = false;
                            }

                            if (pb.Width > Width)
                                pb.Width = Width;

                            pb.Location = new Point(
                                Width / 2 - pb.Width / 2,
                                Height / 2 - pb.Height / 2);
                        }
                    }
                }

                Controls.Add(pb);
            }
            catch (Exception error)
            {
                lblError.Text = $@"An error occured while loading this web resource: {error.Message}";
                pnlError.Visible = true;
            }
        }
    }
}