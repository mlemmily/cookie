using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void doquit()
    {
        Debug.Log("game ahs been quit");
        Application.Quit();
    }

}