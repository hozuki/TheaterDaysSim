using JetBrains.Annotations;
using Microsoft.Xna.Framework;
using OpenMLTD.MilliSim.Contributed.Scores.Animation;
using OpenMLTD.MilliSim.Contributed.Scores.Runtime;
using OpenMLTD.MilliSim.Core;

namespace OpenMLTD.MilliSim.Contributed.Scores.Extending {
    /// <summary>
    /// An interface used to calculate traces of notes.
    /// </summary>
    public interface INoteAnimationCalculator : IMilliSimPlugin {

        /// <summary>
        /// Calculate selected note's radius according to given data.
        /// </summary>
        /// <param name="note">The note whose current radius is to be calculated.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <returns>Calculated note radius.</returns>
        Vector2 GetNoteRadius([NotNull] RuntimeNote note, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculate selected note's X position according to given data.
        /// </summary>
        /// <param name="note">The note whose current X position is to be calculated.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <returns>The note's X position.</returns>
        float GetNoteX([NotNull] RuntimeNote note, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculate selected note's Y position according to given data.
        /// </summary>
        /// <param name="note">The note whose current Y position is to be calculated.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <returns>The note's Y position.</returns>
        float GetNoteY([NotNull] RuntimeNote note, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculate special note's radius according to given data.
        /// </summary>
        /// <param name="note">The note whose current radius is to be calculated.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <returns>Calculated note radius.</returns>
        Vector2 GetSpecialNoteRadius([NotNull] RuntimeNote note, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculate special note's X position according to given data.
        /// </summary>
        /// <param name="note">The special note whose current X position is to be calculated.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <returns>The note's X position.</returns>
        float GetSpecialNoteX([NotNull] RuntimeNote note, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculate special note's Y position according to given data.
        /// </summary>
        /// <param name="note">The special note whose current Y position is to be calculated.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <returns>The note's Y position.</returns>
        float GetSpecialNoteY([NotNull] RuntimeNote note, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculates parameters for hold ribbons.
        /// </summary>
        /// <param name="startNote">This note.</param>
        /// <param name="endNote">Next note.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <remarks>
        /// Bezier curves cannot become straight lines, at least not in Direct2D.
        /// So if the function should return a line, it must be indicated manually.
        /// </remarks>
        /// <returns>A <see cref="RibbonParameters"/> structure containing neccessary information.</returns>
        RibbonParameters GetHoldRibbonParameters([NotNull] RuntimeNote startNote, [NotNull] RuntimeNote endNote, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculates parameters for flick ribbons.
        /// </summary>
        /// <param name="startNote">This note.</param>
        /// <param name="endNote">Next note.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <remarks>
        /// Bezier curves cannot become straight lines, at least not in Direct2D.
        /// So if the function should return a line, it must be indicated manually.
        /// </remarks>
        /// <returns>A <see cref="RibbonParameters"/> structure containing neccessary information.</returns>
        RibbonParameters GetFlickRibbonParameters([NotNull] RuntimeNote startNote, [NotNull] RuntimeNote endNote, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

        /// <summary>
        /// Calculates parameters for slide ribbons.
        /// </summary>
        /// <param name="startNote">This note.</param>
        /// <param name="endNote">Next note.</param>
        /// <param name="now">Current time, in seconds.</param>
        /// <param name="noteMetrics">Note metrics.</param>
        /// <param name="animationMetrics">Note animation metrics.</param>
        /// <remarks>
        /// Bezier curves cannot become straight lines, at least not in Direct2D.
        /// So if the function should return a line, it must be indicated manually.
        /// </remarks>
        /// <returns>A <see cref="RibbonParameters"/> structure containing neccessary information.</returns>
        RibbonParameters GetSlideRibbonParameters([NotNull] RuntimeNote startNote, [NotNull] RuntimeNote endNote, float now, NoteMetrics noteMetrics, NoteAnimationMetrics animationMetrics);

    }
}
