using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
namespace Encora.Statement.Three
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        public UIManager uiManager;

        private void Awake()
        {
            instance = this;
        }
    }
}
