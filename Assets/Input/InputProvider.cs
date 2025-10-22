using UnityEngine;
using UnityEngine.InputSystem;

namespace Input
{
    public class InputProvider : MonoBehaviour
    {
        public InputProvider instance;

        [SerializeField] private PlayerInput playerInput;
    
        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
        }

        public PlayerInput GetPlayerInput()
        {
            if (playerInput == null) return null;
        
            return playerInput;
        }
    }
}
