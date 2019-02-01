using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHARMA_Z.Model
{
    public enum Themes
    {
        Light,
        Dark
    }
    public class SystemConfiguration
    {
        public Themes ThemeToggle { get; set; }
        public bool DisclaimerCheck { get; set; }
    }
}
