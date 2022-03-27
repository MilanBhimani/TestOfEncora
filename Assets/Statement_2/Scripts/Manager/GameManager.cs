using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Encora.Statement.Two
{
    public class GameManager : MonoBehaviour
    {
        // public variables
        public static GameManager instance;
        public PlayersController playersController;
        public InputHandler inputHandler;
        public DataHandler dataHandler;

        private void Awake()
        {
            instance = this;
        }
    }
}
