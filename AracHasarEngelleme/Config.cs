using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
namespace AracHasarEngelleme
{
    public class Config : IRocketPluginConfiguration
    {
        public void LoadDefaults()
        {
            hasarAcik = true;
            tekerlekHasarAcik = true;
        }

        public bool hasarAcik;
        public bool tekerlekHasarAcik;
    }
}
