using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace UserControl_AnalogClock {
	public partial class AnalogClock {
        [Category("Appearance")]
        [DefaultValue("Kyiv")]
        [DisplayName("City Name")]
        public string sSityName { get; set; } = "Kyiv";

        [Category("Appearance")]
        [DefaultValue("Red")]
        [DisplayName("City Color")]
        public Color colorSityName { get; set; } = Color.Red;

        [Category("Design")]
        [DefaultValue(1)]
        [DisplayName("Contur weight")]
        public uint uConturWidth { get; set; } = 1;

        [Category("Design")]
        [DefaultValue("")]
        [DisplayName("Digits color")]
        public Color colorDigits { get; set; } = Color.Black;

        [Category("Design")]
        [DisplayName("Digits Font")]
        public Font fontDigits { get; set; } = new Font(FontFamily.GenericSansSerif, 12);

        [Category("Design")]
        [DisplayName("Digits ShiftX")]
        public int uDigitsShift { get; set; } = 0;

        [Category("Design")]
        [DisplayName("Digits ident")]
        public int uDigitsIndent { get; set; } = 10;

        [Category("Design")]
        [DisplayName("Contur color")]
        public Color colorContur { get; set; } = Color.Black;

        [Category("Design")]
        [DisplayName("Hands color")]
        public Color colorHands { get; set; } = Color.Black;

        [Category("Design")]
        [DisplayName("Hands sec weight")]
        public uint uHandSecWidth { get; set; } = 2;

        [Category("Design")]
        [DisplayName("Hands sec weight")]
        public uint uHandMinWidth { get; set; } = 4;

        [Category("Design")]
        [DisplayName("Hands sec weight")]
        public uint uHandHourWidth { get; set; } = 6;
    }
}
