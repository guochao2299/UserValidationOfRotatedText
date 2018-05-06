using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;

namespace UserValidationOfRotatedText
{
    public enum TextRatetedAngle
    {
        Degree0=0,
        Degree90=90,
        Degree180=180,
        Degree270=270
    }

    public class RotatedText
    {
        public const int ROTATE_TEXT_ANGLE_STEP = 90;
        public readonly static TextRatetedAngle[] ANGLES = { TextRatetedAngle.Degree0, TextRatetedAngle.Degree90, TextRatetedAngle.Degree180, TextRatetedAngle.Degree270 };
        public readonly static Font ROTATE_TEXT_FONT= new Font("宋体", 12);
        private string m_text = string.Empty;
        private RectangleF m_bound;
        private TextRatetedAngle m_angle = TextRatetedAngle.Degree0;

        public RotatedText(string text,Graphics g,Random r)
        {
            m_text = text;

            SizeF textSize = g.MeasureString(text, ROTATE_TEXT_FONT);
            m_bound.Width = m_bound.Height = Convert.ToSingle(Math.Max(textSize.Width, textSize.Height));
            m_angle = ANGLES[r.Next(ANGLES.Length)];
        }

        public TextRatetedAngle Angle
        {
            get
            {
                return m_angle;
            }
        }

        public RectangleF Bound
        {
            get
            {
                return m_bound;
            }
        }

        public void DrawText(Graphics g)
        {
            GraphicsContainer gc = g.BeginContainer();
            StringFormat sf=new StringFormat();
            
            try
            {
                // 显示边框
                //g.DrawRectangle(Pens.Red, m_bound.X, m_bound.Y, m_bound.Width, m_bound.Height);
                sf.Alignment= StringAlignment.Center;
                sf.LineAlignment= StringAlignment.Center;

                // 显示旋转中心
                //PointF pCenter = new PointF(m_bound.X + m_bound.Width / 2, m_bound.Y + m_bound.Height / 2);
                //g.DrawEllipse(Pens.Red, pCenter.X - 2, pCenter.Y - 2, 4, 4);
                g.TranslateTransform(m_bound.X + m_bound.Width / 2, m_bound.Y + m_bound.Height / 2);
                g.RotateTransform((Int32)m_angle);

                RectangleF tmpBound = new RectangleF(new PointF(-m_bound.Width / 2, -m_bound.Height / 2), m_bound.Size);                
                g.DrawString(m_text, ROTATE_TEXT_FONT, Brushes.Green, tmpBound, sf);
            }
            catch (Exception ex)
            {
                throw new Exception("绘制旋转文本失败，错误消息为：" + ex.Message, ex);
            }
            finally
            {
                sf.Dispose();
                g.EndContainer(gc);
            }
        }

        public void InitPosition(PointF p)
        {
            m_bound.Location = p;
        }

        private void UpdateTextPosition(int step)
        {
            int currAngle = (int)Angle;
            int nextAngle = (currAngle + step) % 360;
            if (nextAngle < 0)
            {
                nextAngle += 360;
            }

            m_angle = (TextRatetedAngle)nextAngle;
        }
        public void RotateTextClockwise()
        {
            UpdateTextPosition(ROTATE_TEXT_ANGLE_STEP);
        }
        public void RotateTextAnticlockwise()
        {
            UpdateTextPosition(-ROTATE_TEXT_ANGLE_STEP);
        }
    }
}
