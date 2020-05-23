﻿using Content.Server.GameObjects.Components.Movement;
using Robust.Shared.Interfaces.GameObjects;
using Robust.Shared.Map;
using Robust.Shared.Maths;

namespace Content.Server.Interfaces.GameObjects.Components.Movement
{
    // Does nothing except ensure uniqueness between mover components.
    // There can only be one.
    public interface IMoverComponent : IComponent
    {

        bool PixelMovementEnabled { get; set; }
        bool DiagonalMovementEnabled { get; set; }

        /// <summary>
        ///     Movement speed (m/s) that the entity walks.
        /// </summary>
        float CurrentWalkSpeed { get; }

        /// <summary>
        ///     Movement speed (m/s) that the entity sprints.
        /// </summary>
        float CurrentSprintSpeed { get; }


        /// <summary>
        ///     The movement speed (m/s) of the entity when it pushes off of a solid object in zero gravity.
        /// </summary>
        float CurrentPushSpeed { get; }

        /// <summary>
        ///     How far an entity can reach (in meters) to grab hold of a solid object in zero gravity.
        /// </summary>
        float GrabRange { get; }

        /// <summary>
        ///     Is the entity Moving?
        /// </summary>
        bool Moving { get; set; }

        /// <summary>
        ///     Is the entity Sprinting (running)?
        /// </summary>
        bool Sprinting { get; set; }

        /// <summary>
        ///     Calculated linear velocity direction of the entity.
        /// </summary>
        Vector2 VelocityDir { get; }

        GridCoordinates LastPosition { get; set; }
        GridCoordinates TargetPosition { get; set; }

        float StepSoundDistance { get; set; }

        /// <summary>
        ///     Toggles one of the four cardinal directions. Each of the four directions are
        ///     composed into a single direction vector, <see cref="PlayerInputMoverComponent.VelocityDir"/>. Enabling
        ///     opposite directions will cancel each other out, resulting in no direction.
        /// </summary>
        /// <param name="direction">Direction to toggle.</param>
        /// <param name="enabled">If the direction is active.</param>
        void SetVelocityDirection(Direction direction, bool enabled);
    }
}
