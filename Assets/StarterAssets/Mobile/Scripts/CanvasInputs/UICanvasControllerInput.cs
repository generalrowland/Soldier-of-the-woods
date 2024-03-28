using UnityEngine;

namespace StarterAssets
{
    public class UICanvasControllerInput : MonoBehaviour
    {

        [Header("Output")]
        public PlayerMovement starterAssetsInputs;
        public LookAtMouse look;
        public ShootProjectilePistol shoot;

        public void VirtualMoveInput(Vector2 virtualMoveDirection)
        {
            starterAssetsInputs.MoveInput(virtualMoveDirection);
        }

        public void VirtualLookInput(Vector2 virtualLookDirection)
        {
            look.LookInput(virtualLookDirection);
        }

        public void VirtualFireInput(bool virtualFireDirection)
        {
            shoot.FireInput(virtualFireDirection);
        }
    }

}
