using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Initialize : MonoBehaviour
{
    void Awake(){
        SceneManager.LoadScene(1);
    }
}
