﻿namespace OsuHG
{
    public class GammaProgram
    {
        private static GammaLibrary _gamma;
        public static void Gamma()
        {
           // _gamma = new GammaLibrary();
          //  if(Program.BaseAddresses.Beatmap.Ar > 10.1)
                GammaLibrary.Set((float)Settings1.Default.highGamma);
          //  if (Program.BaseAddresses.Beatmap.Ar < 9)
          //      GammaLibrary.Set((float)Settings1.Default.lowGamma);
        }
    }
}
