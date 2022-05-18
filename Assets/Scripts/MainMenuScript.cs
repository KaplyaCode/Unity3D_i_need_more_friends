using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource menutip;
    public Animator anim;

    public void StartNewGame(){
        anim.Play("Fading");
    }
    public void OpenLoadMenu(){
        
    }
    public void ExitGame(){
        Application.Quit();
    }
    public void SetLowQuality(){
        QualitySettings.SetQualityLevel(0, true);
    }
    public void SetMediumQuality(){
        QualitySettings.SetQualityLevel(1, true);
    }
    public void SetHighQuality(){
        QualitySettings.SetQualityLevel(2, true);
    }
    
    public void PlaySound(){
        menutip.pitch = Random.Range(0.9f, 1.1f);
        menutip.Play();
    }
}