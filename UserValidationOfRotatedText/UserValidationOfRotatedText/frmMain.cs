using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UserValidationOfRotatedText
{
    public partial class frmMain : Form
    {
        private List<RotatedText> m_rotatedTexts = new List<RotatedText>();
        private Random m_random = new Random(DateTime.Now.Millisecond);

        public frmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContent.Text))
            {
                MessageBox.Show("原始内容区域必须要填写中文字符内容");
                txtContent.Focus();
                return;
            }

            using (Graphics g = this.picBoard.CreateGraphics())
            {                
                m_rotatedTexts.Clear();
                foreach (char c in txtContent.Text)
                {
                    RotatedText newRt = new RotatedText(c.ToString(), g,m_random);
                    bool isPositionOK = true;
                    int textWidth = Convert.ToInt32(newRt.Bound.Width);
                    int textHeight = Convert.ToInt32(newRt.Bound.Height);

                    do
                    {
                        isPositionOK = true;

                        newRt.InitPosition(new PointF(m_random.Next(textWidth, Convert.ToInt32(picBoard.Width - newRt.Bound.Width)), m_random.Next(textHeight, Convert.ToInt32(picBoard.Height - newRt.Bound.Height))));

                        foreach (RotatedText rt in m_rotatedTexts)
                        {
                            if (rt.Bound.IntersectsWith(newRt.Bound))
                            {
                                isPositionOK = false;
                                break;
                            }
                        }
                    }
                    while (!isPositionOK);

                    m_rotatedTexts.Add(newRt);
                }
            }

            picBoard.Refresh();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            foreach (RotatedText rt in m_rotatedTexts)
            {
                if (rt.Angle != TextRatetedAngle.Degree0)
                {
                    MessageBox.Show("还有字符位置不正确");
                    return;
                }
            }

            MessageBox.Show("文本位置检测成功，所有字符的位置都正确");
        }

        private void picBoard_Paint(object sender, PaintEventArgs e)
        {
            foreach(RotatedText rt in m_rotatedTexts)
            {
                rt.DrawText(e.Graphics);
            }
        }

        private void picBoard_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (RotatedText rt in m_rotatedTexts)
            {
                if (rt.Bound.Contains(e.Location))
                {
                    if (e.Button == System.Windows.Forms.MouseButtons.Left)
                    {
                        rt.RotateTextClockwise();
                    }
                    else
                    {
                        rt.RotateTextAnticlockwise();
                    }

                    picBoard.Refresh();
                    break;
                }
            }
        }
    }
}
