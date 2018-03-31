using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdleGame.ProgressBars
{
    public enum ProgressBarDisplayText { Value, CustomText };

    class HealthBar : ProgressBar
    {
        public ProgressBarDisplayText DisplayStyle;
        public String CustomText;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
            rec.Height = rec.Height - 4;
            e.Graphics.FillRectangle(Brushes.LimeGreen, 2, 2, rec.Width, rec.Height);


            string text = (DisplayStyle == ProgressBarDisplayText.Value) ? $"{Value.ToString()}/{Maximum.ToString()}" : CustomText;
            
            using (Font f = new Font(FontFamily.GenericSansSerif, 8))
            {

                SizeF len = e.Graphics.MeasureString(text, f);
                // Calculate the location of the text (the middle of progress bar)
                // Point location = new Point(Convert.ToInt32((rect.Width / 2) - (len.Width / 2)), Convert.ToInt32((rect.Height / 2) - (len.Height / 2)));
                Point location = new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
                // The commented-out code will centre the text into the highlighted area only. This will centre the text regardless of the highlighted area.
                // Draw the custom text
                e.Graphics.DrawString(text, f, Brushes.Black, location);
            }
        }

        public HealthBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }
    }
}
