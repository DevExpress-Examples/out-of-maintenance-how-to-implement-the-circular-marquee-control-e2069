using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Win.Gauges.Linear;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;

namespace WindowsApplication1
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        int time;
        const int maxtime = 50;
        const int highlightedIndicatorsCount = 4;
        float[] opacityValues = new float[] {0.5F, 0.7F, 0.9F, 1F };

        public void ShowProgress()
        {
            ShowDialog();
        }

        static void HighlightIndicator(LinearScaleStateIndicatorComponent indicator, float opacity)
        {
            OpacityShader shader = new OpacityShader();
            shader.Opacity = opacity;
            indicator.Shader = shader;
            indicator.States[0].ShapeType = StateIndicatorShapeType.ProgressItem9;
        }


        public void SetProgress(int progress)
        {
            progress = progress % linearGauge1.Indicators.Count;
            LinearScaleStateIndicatorComponent[] highlightedIndicators = new LinearScaleStateIndicatorComponent[highlightedIndicatorsCount];
            for (int i = 0; i < highlightedIndicatorsCount; i++)
            {
                highlightedIndicators[i] = linearGauge1.Indicators[(progress + i) % linearGauge1.Indicators.Count];
            }

            foreach (LinearScaleStateIndicatorComponent indicator in linearGauge1.Indicators)
            {
                indicator.Shader = BaseColorShader.Empty;
                indicator.States[0].ShapeType = StateIndicatorShapeType.ProgressItem5;
            }
            for (int i = 0; i < highlightedIndicatorsCount; i++)
            {
                HighlightIndicator(highlightedIndicators[i], opacityValues[i]);
            }
        }

        private void timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            SetProgress(time);
            time++;
            if (time > maxtime)
            {
                timer1.Stop();
                Dispose();
            }
        }
    }
}