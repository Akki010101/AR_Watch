﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class WatchSelect : MonoBehaviour
{
    
    public GameObject watchModel1;
    public GameObject watchModel2;
    public GameObject watchModel3;

    public GameObject w1Window;
    public GameObject w2Window;
    public GameObject w3Window;

    Animation w1WindowAnimation;
    Animation w2WindowAnimation;
    Animation w3WindowAnimation;

    void Start()
    {
        w1WindowAnimation = w1Window.GetComponent<Animation>();
        w2WindowAnimation = w2Window.GetComponent<Animation>();
        w3WindowAnimation = w3Window.GetComponent<Animation>();
    }

    public void WatchOneButtonClicked()
    {
        watchModel1.SetActive(true);
        watchModel2.SetActive(false);
        watchModel3.SetActive(false);

        w1WindowAnimation["W1_Animation"].speed = 1;
        w1WindowAnimation.Play();
    }

    public void WatchTwoButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(true);
        watchModel3.SetActive(false);

        w2WindowAnimation["W2_Animation"].speed = 1;
        w2WindowAnimation.Play();
    }

    public void WatchThreeButtonClicked()
    {
        watchModel1.SetActive(false);
        watchModel2.SetActive(false);
        watchModel3.SetActive(true);
        
        w3WindowAnimation["W3_Animation"].speed = 1;
        w3WindowAnimation.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;

        if(buttonName == "W1_Close")
        {
            w1WindowAnimation["W1_Animation"].speed = -1;
            w1WindowAnimation["W1_Animation"].time = w1WindowAnimation["W1_Animation"].length;
            w1WindowAnimation.Play();
        }
        else if(buttonName == "W2_Close")
        {
            w2WindowAnimation["W2_Animation"].speed = -1;
            w2WindowAnimation["W2_Animation"].time = w2WindowAnimation["W2_Animation"].length;
            w2WindowAnimation.Play();
        }
        else if(buttonName == "W3_Close")
        {
            w3WindowAnimation["W3_Animation"].speed = -1;
            w3WindowAnimation["W3_Animation"].time = w3WindowAnimation["W3_Animation"].length;
            w3WindowAnimation.Play();
        }
    }

   
}
