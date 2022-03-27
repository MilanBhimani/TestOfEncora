using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Encora.Statement.Two
{
    public class PlayerLocal : MonoBehaviour
    {
        // private variables
        private float moveSpeed = 4.0f;

        internal void MoveByUserInput(float xAxis, float zAxis)
        {
            transform.position += new Vector3(xAxis, 0.0f, zAxis) * moveSpeed * Time.deltaTime;
            GameManager.instance.dataHandler.SendData(transform.position);
        }
    }
}
