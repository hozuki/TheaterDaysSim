using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using OpenMLTD.MilliSim.Contributed.Scores;
using OpenMLTD.MilliSim.Contributed.Scores.Extending;
using OpenMLTD.MilliSim.Core;

namespace OpenMLTD.MilliSim.Extension.Contributed.Scores.StandardScoreFormats.Mltd {
    [MilliSimPlugin(typeof(IScoreFormat))]
    [UsedImplicitly(ImplicitUseKindFlags.InstantiatedWithFixedConstructorSignature)]
    public sealed class Unity3DScoreFormat : ScoreFormat {

        public override string PluginID => "plugin.score.mltd.unity3d";

        public override string PluginName => "MLTD Unity3D Score Format";

        public override string PluginDescription => "MLTD Unity3D score format reader and compiler factory.";

        public override string PluginAuthor => "OpenMLTD";

        public override Version PluginVersion => MyVersion;

        public override bool CanReadAsSource => true;

        public override bool CanReadAsCompiled => true;

        public override bool CanBeCompiled => true;

        public override bool CanWriteSource => false;

        public override bool CanWriteCompiled => false;

        public override IScoreReader CreateReader() {
            return new Unity3DScoreReader();
        }

        public override IScoreWriter CreateWriter() {
            return new Unity3DScoreWriter();
        }

        public override IScoreCompiler CreateCompiler() {
            return new Unity3DScoreCompiler();
        }

        public override bool SupportsReadingFileType(string fileName) {
            fileName = fileName.ToLowerInvariant();
            return SupportedReadExtensions.Any(ext => fileName.EndsWith(ext));
        }

        public override IReadOnlyList<string> SupportedReadExtensions => Unity3DReadExtensions;

        public override IReadOnlyList<string> SupportedWriteExtensions => Unity3DWriteExtensions;

        public override string FormatDescription => "MLTD Unity3D Score File";

        internal static readonly string[] Unity3DReadExtensions = { ".unity3d", ".unity3d.lz4" };

        internal static readonly string[] Unity3DWriteExtensions = new string[0];

        private static readonly Version MyVersion = new Version(1, 0, 0, 0);

    }
}
