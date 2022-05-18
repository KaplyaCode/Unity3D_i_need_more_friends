using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocationScript : MonoBehaviour
{
    public void NextLocation(){
        SceneManager.LoadScene("Location 1.2");
    }
}
