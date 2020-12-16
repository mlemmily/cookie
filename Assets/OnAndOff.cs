using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnAndOff : MonoBehaviour
{ 
    public GameObject CanvasGameObject;

    void Update()

    {
            if (Input.GetKeyDown(KeyCode.W))
            {
                CanvasGameObject.SetActive(false);
            }
            else
            {
                CanvasGameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                CanvasGameObject.SetActive(false);
            }
            else
            {
                CanvasGameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                CanvasGameObject.SetActive(false);
            }
            else
            {
                CanvasGameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                CanvasGameObject.SetActive(false);
            }
            else
            {
                CanvasGameObject.SetActive(true);
            }
    }

}


