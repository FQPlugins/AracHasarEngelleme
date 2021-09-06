using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rocket.API;
using Rocket.Core.Plugins;
using SDG.Unturned;
using Steamworks;

namespace AracHasarEngelleme
{
    public class Main : RocketPlugin<Config>
    {
        protected override void Load()
        {
            VehicleManager.onDamageVehicleRequested += new DamageVehicleRequestHandler(aracHasar);
            VehicleManager.onDamageTireRequested += new DamageTireRequestHandler(tekerlekHasar);
        }

        protected override void Unload()
        {
            
        }

        private void aracHasar(CSteamID instigatorSteamID, InteractableVehicle vehicle, ref ushort pendingTotalDamage, ref bool canRepair, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {

            if (Configuration.Instance.hasarAcik)
            {
                shouldAllow = false;
            }
            else
            {
                shouldAllow = true;
            }
        }

        private void tekerlekHasar(CSteamID instigatorSteamID, InteractableVehicle vehicle, int tireIndex, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            if (Configuration.Instance.tekerlekHasarAcik)
            {
                shouldAllow = false;
            }
            else
            {
                shouldAllow = true;
            }
        }

    }
}
