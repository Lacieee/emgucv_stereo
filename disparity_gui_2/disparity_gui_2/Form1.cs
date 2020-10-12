using System;
using System.IO;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace disparity_gui_2
{
    public partial class Form1 : Form
    {
        private string author = "Kőváry László, Kaposvári Márk - BME AUT";

        private Image<Gray, byte> leftIm;
        private Image<Gray, byte> rightIm;

        private Mat show;

        public Form1()
        {
            InitializeComponent();
            lLog.Text = author;
            try
            {
                leftIm = new Image<Gray, byte>(@"C:\Users\BME\Documents\Temalab\stereo-pairs\road\imL.jpg");
                iBleft.Image = leftIm;
                rightIm = new Image<Gray, byte>(@"C:\Users\BME\Documents\Temalab\stereo-pairs\road\imR.jpg");
                iBright.Image = rightIm;
                Any_ValueChanged(this, null);
            } 
            catch(Exception ex)
            {
                lLog.Text = "Log: " + ex.Message;
            }
        }

        private void tBminDisparity_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVminDisparity.Text = tB.Value.ToString();
        }

        private void tBpreFilterCap_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVpreFilterCap.Text = tB.Value.ToString();
        }

        private void tBspecleRange_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVspecleRange.Text = tB.Value.ToString();
        }

        private void tBnumDisparities_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVnumDisparites.Text = (tB.Value).ToString();
        }

        private void tBblockSize_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVblockSize.Text = (tB.Value * 2 - 1).ToString();
        }

        private void tBP1_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVP1.Text = tB.Value.ToString();
        }

        private void tBP2_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVP2.Text = tB.Value.ToString();
        }

        private void tBdisp12MaxDiff_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVdisp12MaxDiff.Text = tB.Value.ToString();
        }

        private void tBuniquenessRatio_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVuniquenessRatio.Text = tB.Value.ToString();
        }

        private void tBspecleWindowSize_Scroll(object sender, EventArgs e)
        {
            TrackBar tB = (TrackBar)sender;
            lVspecleWindowSize.Text = tB.Value.ToString();
        }

        private void Any_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                Mat disparityMap = new Mat();
                StereoSGBM sgbm = new StereoSGBM(
                    tBminDisparity.Value,
                    tBnumDisparities.Value,
                    tBblockSize.Value * 2 - 1,
                    tBP1.Value,
                    tBP2.Value,
                    tBdisp12MaxDiff.Value,
                    tBpreFilterCap.Value,
                    tBuniquenessRatio.Value,
                    tBspecleWindowSize.Value,
                    tBspecleRange.Value,
                    (rBSBGM.Checked) ? StereoSGBM.Mode.SGBM : StereoSGBM.Mode.HH);

                sgbm.Compute(leftIm, rightIm, disparityMap);
                show = new Mat();
                disparityMap.ConvertTo(show, DepthType.Cv8U);
                
                iBdisparity.Image = show;
                lLog.Text = author;
            }
            catch (Exception ex)
            {
                lLog.Text = "Log: " + ex.Message;
            }
            GC.Collect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = "DISP_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".jpg";
            try
            {
                if (show != null)
                {
                    show.Save(fileName);
                    lLog.Text = "Sikeres mentés " + fileName;
                    using(StreamWriter sw = new StreamWriter(fileName.Replace(".jpg", ".txt")))
                    {
                        sw.WriteLine("minDisparity=" + tBminDisparity.Value);
                        sw.WriteLine("numDisparities=" + tBnumDisparities.Value);
                        sw.WriteLine("blockSize=" + (tBblockSize.Value * 2 - 1).ToString());
                        sw.WriteLine("P1=" + tBP1.Value);
                        sw.WriteLine("P2=" + tBP2.Value);
                        sw.WriteLine("disp12MaxDiff=" + tBdisp12MaxDiff.Value);
                        sw.WriteLine("preFilterCap=" + tBpreFilterCap.Value);
                        sw.WriteLine("uniquenessRatio=" + tBuniquenessRatio.Value);
                        sw.WriteLine("specleWindowSize=" + tBspecleWindowSize.Value);
                        sw.WriteLine("specleRange=" + tBspecleRange.Value);
                        sw.WriteLine("mode=" + ((rBSBGM.Checked) ? "SGBM" : "HH"));
                        sw.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                lLog.Text = "Log: " + ex.Message;
            }
        }

        private void újBalOldaliKépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Képfájlok (*.jpg), (*.jpeg), (*.png)|*.jpg;*.jpeg;*.png";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                leftIm = new Image<Gray, byte>(ofd.FileName);
                iBleft.Image = leftIm;
            }
        }

        private void újJobbOldaliKépToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Képfájlok (*.jpg), (*.jpeg), (*.png)|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rightIm = new Image<Gray, byte>(ofd.FileName);
                iBright.Image = leftIm;
            }
        }
    }
}
