using OpenMLTD.MilliSim.Core;

namespace OpenMLTD.MilliSim.Contributed.Scores.Source {
    public class ReadSourceOptions : Dynamic {

        public ReadSourceOptions() {
            ScoreIndex = 0;
        }

        /// <summary>
        /// The global speed multiplier.
        /// </summary>
        public int ScoreIndex {
            get => GetValue<int>(GlobalSpeedKey);
            set => SetValue(GlobalSpeedKey, value);
        }

        public static string GlobalSpeedKey => nameof(ScoreIndex);

    }
}
