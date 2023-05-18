using UnityEngine;
using UnityEngine.InputSystem;

namespace RoguelikeFPS.Character.Player
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(PlayerInput))]
    public class PlayerController : MonoBehaviour
    {
        private const float passiveGravity = 10f;

        private CharacterController controller;
        [SerializeField]
        private CharacterAttributes attributes;
        private Vector3 velocity;
        private Vector2 horizontalMovement;
        private bool jumped;

        private void Start()
        {
            controller = GetComponent<CharacterController>();
        }

        private void Update()
        {
            ApplyMovement();
        }

        private void ApplyMovement()
        {
            ApplyHorizontalMovement();
            ApplyGravity();
            ApplyJump();
            controller.Move(velocity * Time.deltaTime);
        }

        private void ApplyHorizontalMovement()
        {
            velocity.x = horizontalMovement.x * attributes.HorizontalMovementSpeed;
            velocity.z = horizontalMovement.y * attributes.HorizontalMovementSpeed;
        }

        private void OnMove(InputValue value)
        {
            horizontalMovement = value.Get<Vector2>();
        }

        private void ApplyJump()
        {
            if (jumped)
            {
                velocity.y += attributes.JumpStrength;
            }

            jumped = false;
        }

        private void ApplyGravity()
        {
            if (controller.isGrounded)
            {
                velocity.y = -passiveGravity;
            }
            else
            {
                velocity.y -= attributes.Gravity * Time.deltaTime;
            }
        }

        private void OnJump()
        {
            if (controller.isGrounded)
            {
                jumped = true;
            }
        }
    }
}
