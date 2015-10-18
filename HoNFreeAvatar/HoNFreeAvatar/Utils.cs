using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoNFreeAvatar
{
    class ButtonHero : Button
    {
        public String Code;
        public List<ButtonHero> ListButtonHero;
        public int Id;
        public String HeroName;
        public ButtonHero()
        {
            ListButtonHero = new List<ButtonHero>();
            Code = "";
            Id = 0;
            HeroName = "";
        }
    }
}
