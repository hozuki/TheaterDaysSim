using OpenMLTD.MilliSim.Core;

namespace OpenMLTD.MilliSim.Contributed.Scores.Runtime {
    public class ScoreCompileOptions : Dynamic {

        public ScoreCompileOptions() {
            GlobalSpeed = 1;
            Offset = 0;
        }

        /// <summary>
        /// The global speed multiplier.
        /// </summary>
        public float GlobalSpeed {
            get => GetValue<float>(GlobalSpeedKey);
            set => SetValue(GlobalSpeedKey, value);
        }

        public static string GlobalSpeedKey => nameof(GlobalSpeed);

        /// <summary>
        /// Offset of the score, relative to standard time, in seconds.
        /// </summary>
        public float Offset {
            get => GetValue<float>(OffsetKey);
            set => SetValue(OffsetKey, value);
        }

        public static string OffsetKey => nameof(Offset);

    }
}
