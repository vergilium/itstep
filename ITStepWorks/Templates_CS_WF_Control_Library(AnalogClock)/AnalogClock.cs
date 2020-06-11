using System;
using System.Collections.Generic;
using System.Runtime;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_AnalogClock
{
    public partial class AnalogClock : UserControl {
        private float[] sin = new float[360];
        private float[] cos = new float[360];

        public AnalogClock()
        {
            InitializeComponent();
        }

        private void AnalogClock_Load(object sender, EventArgs e) {
            for (int i = 0; i < 360; ++i) {
                sin[i] = (float)Math.Sin(i * Math.PI / 180.0);
                cos[i] = (float)Math.Cos(i * Math.PI / 180.0);
            }
        }

        private void AnalogClock_Paint(object sender, PaintEventArgs e) {
            Graphics gr = e.Graphics;
            Font Cityfont = new Font(this.Font.FontFamily.Name, 25, FontStyle.Bold);
            int baseRadius =
                (ClientSize.Width > ClientSize.Height ?
                    ClientSize.Height : ClientSize.Width) / 2 - 20;

            PointF centerPoint = new PointF(
                ClientSize.Width / 2.0F, ClientSize.Height / 2.0F);

            SizeF cityNameSize = gr.MeasureString(sSityName, Cityfont);
            gr.DrawString(sSityName, Cityfont, new SolidBrush(colorSityName),
                new PointF(centerPoint.X - cityNameSize.Width / 2.0F,
                centerPoint.Y - cityNameSize.Height - 20));

            ////////Отрисовка контура
            gr.DrawEllipse(new Pen(colorContur, uConturWidth),
                centerPoint.X - baseRadius,
                centerPoint.Y - baseRadius,
                baseRadius * 2, baseRadius * 2);

            for (int i = 1; i < 13; ++i) {
                gr.DrawLine(new Pen(colorContur, uConturWidth),
                        new PointF(
                            baseRadius * cos[(i * 30) % 360] + centerPoint.X,
                            baseRadius * sin[(i * 30) % 360] + centerPoint.Y),
                        new PointF(
                            (baseRadius - 10) * cos[(i * 30) % 360] + centerPoint.X,
                            (baseRadius - 10) * sin[(i * 30) % 360] + centerPoint.Y)
                    );
                string str = Convert.ToString(i);
                SizeF size = gr.MeasureString(str, this.Font);

                gr.DrawString(str, fontDigits, new SolidBrush(colorDigits),
                    (baseRadius + uDigitsIndent) * cos[(i * 30 + 270) % 360] + centerPoint.X - size.Width / 2 - uDigitsShift,
                    (baseRadius + uDigitsIndent) * sin[(i * 30 + 270) % 360] + centerPoint.Y - size.Height / 2,
                    StringFormat.GenericTypographic);
            }

            gr.FillEllipse(new SolidBrush(colorHands),
                centerPoint.X - baseRadius / 8,
                centerPoint.Y - baseRadius / 8,
                baseRadius / 4, baseRadius / 4);

            DateTime dt =  DateTime.Now;


            DrawArrow(gr, new Pen(colorHands, uHandSecWidth), baseRadius - 10, dt.Second * 6);

            DrawArrow(gr, new Pen(colorHands, uHandMinWidth), baseRadius - 20, dt.Minute * 6);

            DrawArrow(gr, new Pen(colorHands, uHandHourWidth), baseRadius - 30,
                dt.Minute / 2 + dt.Hour % 12 * 30);
        }

        void DrawArrow(Graphics gr, Pen pen, int len, int angle) {
            PointF centerPoint = new PointF(
                ClientSize.Width / 2.0F, ClientSize.Height / 2.0F);

            gr.DrawLine(pen, centerPoint,
                new PointF(
                    len * cos[(angle + 270) % 360] + centerPoint.X,
                    len * sin[(angle + 270) % 360] + centerPoint.Y));
        }

        private void clockTimer_Tick(object sender, EventArgs e) {
            Invalidate();
        }
    }
}
