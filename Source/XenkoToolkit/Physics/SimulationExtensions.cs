﻿using SiliconStudio.Core.Collections;
using SiliconStudio.Xenko.Physics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XenkoToolkit.Mathematics;

namespace XenkoToolkit.Physics
{
    public static class SimulationExtensions
    {
        /// <summary>
        /// Raycasts and stops at the first hit.
        /// </summary>
        /// <param name="simulation">Physics simulation.</param>
        /// <param name="raySegment">Ray.</param>
        /// <returns></returns>
        public static HitResult Raycast(this Simulation simulation, RaySegment raySegment)
        {
            if (simulation == null)
            {
                throw new ArgumentNullException(nameof(simulation));
            }

            return simulation.Raycast(raySegment.Start, raySegment.End);
        }

        /// <summary>
        /// Raycasts and stops at the first hit.
        /// </summary>
        /// <param name="simulation">Physics simulation.</param>
        /// <param name="raySegment">Ray.</param>
        /// <param name="collisionFilterGroups">The collision group of this shape sweep</param>
        /// <param name="collisionFilterGroupFlags">The collision group that this shape sweep can collide with</param>
        /// <returns>The list with hit results.</returns>
        public static HitResult Raycast(this Simulation simulation, RaySegment raySegment, CollisionFilterGroups collisionFilterGroups, CollisionFilterGroupFlags collisionFilterGroupFlags)
        {
            if (simulation == null)
            {
                throw new ArgumentNullException(nameof(simulation));
            }

            return simulation.Raycast(raySegment.Start, raySegment.End, collisionFilterGroups, collisionFilterGroupFlags);
        }

        /// <summary>
        /// Raycasts penetrating any shape the ray encounters.
        /// </summary>
        /// <param name="simulation">Physics simulation.</param>
        /// <param name="raySegment">Ray.</param>
        /// <param name="resultsOutput">The list to fill with results.</param>
        public static void RaycastPenetrating(this Simulation simulation, RaySegment raySegment, IList<HitResult> resultsOutput)
        {
            if (simulation == null)
            {
                throw new ArgumentNullException(nameof(simulation));
            }

            simulation.RaycastPenetrating(raySegment.Start, raySegment.End, resultsOutput);
        }

        /// <summary>
        /// Raycasts penetrating any shape the ray encounters.
        /// </summary>
        /// <param name="simulation">Physics simulation.</param>
        /// <param name="raySegment">Ray.</param>
        /// <returns>The list with hit results.</returns>
        public static FastList<HitResult> RaycastPenetrating(this Simulation simulation, RaySegment raySegment)
        {
            if (simulation == null)
            {
                throw new ArgumentNullException(nameof(simulation));
            }

            return simulation.RaycastPenetrating(raySegment.Start, raySegment.End);
        }

        /// <summary>
        /// Raycasts penetrating any shape the ray encounters.
        /// Filtering by CollisionGroup
        /// </summary>
        /// <param name="simulation">Physics simulation.</param>
        /// <param name="raySegment">Ray.</param>
        /// <param name="resultsOutput">The list to fill with results.</param>
        /// <param name="collisionFilterGroups">The collision group of this shape sweep</param>
        /// <param name="collisionFilterGroupFlags">The collision group that this shape sweep can collide with</param>
        public static void RaycastPenetrating(this Simulation simulation, RaySegment raySegment, IList<HitResult> resultsOutput, CollisionFilterGroups collisionFilterGroups, CollisionFilterGroupFlags collisionFilterGroupFlags)
        {
            if (simulation == null)
            {
                throw new ArgumentNullException(nameof(simulation));
            }

            simulation.RaycastPenetrating(raySegment.Start, raySegment.End, resultsOutput, collisionFilterGroups, collisionFilterGroupFlags);
        }

        /// <summary>
        /// Raycasts penetrating any shape the ray encounters.
        /// </summary>
        /// <param name="simulation">Physics simulation.</param>
        /// <param name="raySegment">Ray.</param>
        /// <param name="collisionFilterGroups">The collision group of this shape sweep</param>
        /// <param name="collisionFilterGroupFlags">The collision group that this shape sweep can collide with</param>
        /// <returns>The list with hit results.</returns>
        public static FastList<HitResult> RaycastPenetrating(this Simulation simulation, RaySegment raySegment, CollisionFilterGroups collisionFilterGroups, CollisionFilterGroupFlags collisionFilterGroupFlags)
        {
            if (simulation == null)
            {
                throw new ArgumentNullException(nameof(simulation));
            }

            return simulation.RaycastPenetrating(raySegment.Start, raySegment.End, collisionFilterGroups, collisionFilterGroupFlags);
        }
    }
}