using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encora.Statement.Two
{
    public class InputHandler : MonoBehaviour
    {
        private void Update()
        {
            UserInput();
        }

        private void UserInput()
        {
            if (Input.GetKey(KeyCode.W) ||
                Input.GetKey(KeyCode.A) ||
                Input.GetKey(KeyCode.S) ||
                Input.GetKey(KeyCode.D))
            {
                GameManager.instance.playersController.localPlayer.MoveByUserInput(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            }
        }
    }
}
