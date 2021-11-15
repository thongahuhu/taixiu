using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    public bool isMute;

    public InputField playerName;

    public void Play() {
        isMute = false;

        taixiu.nameStr = playerName.text;

        Application.LoadLevel("Gameplay");
    }

    public void Quit() {
        Application.Quit();
    }
    
    public void Mute() {
        if (!isMute) {
            GetComponent<AudioSource>().Stop();
            isMute = true;
        } else if (isMute) {
            GetComponent<AudioSource>().Play();
            isMute = false;
        }
    }
}
