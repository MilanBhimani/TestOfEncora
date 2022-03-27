using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Encora.Statement.Two
{
    public class PlayerRemote : MonoBehaviour
    {
        // private variables
        private float moveSpeed = 4.0f;
        private Vector3 targetPos;
        
        private void Start() 
        {
            GameManager.instance.dataHandler.delegateOfPositionChanged += OnDataRecieved;
            targetPos = transform.position;
        }

        private void Update()
        {
            if(transform.position != targetPos)
            {
                transform.position = Vector3.Lerp (transform.position, targetPos, Time.deltaTime * moveSpeed);
            }
        }

        private void OnDestroy() 
        {
            GameManager.instance.dataHandler.delegateOfPositionChanged -= OnDataRecieved;
        }

        private void OnDataRecieved(string argData)
        {
            targetPos = VectorConverter.ByteArrayToVector(System.Convert.FromBase64String(argData));
            Debug.Log("Received : " + targetPos);
        }
    }
}
