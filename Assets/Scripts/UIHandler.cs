using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public GameObject TextLoginSuccessful;
    public Image ImageNavMenu;
    public Image ButtonChapters; //If there are more then Three buttons chage it to an array
    public Image ButtonBack;

    public void buttonEvent(){
        Debug.Log("Login");
        //if (!TextLoginSuccessful.active)
        //{
        //    TextLoginSuccessful.SetActive(false);
        //}
        //else
        //    TextLoginSuccessful.SetActive(true);
    }
    public void navStart()
    {
        if (!ImageNavMenu.gameObject.active)
        {
            ImageNavMenu.gameObject.SetActive(true);
            StartCoroutine(startSlide(0.1f));
            Debug.Log("ImageNavMenu.gameObject.SetActive(true);");
        } else if (ImageNavMenu.gameObject.active)
        {
            StartCoroutine(startSlide(-0.1f));
            Debug.Log("StartCoroutine(startSlide(-0.1f));");
        }
        
    }
        IEnumerator startSlide(float i)
        {
        yield return new WaitForSeconds(0.01f);
        ImageNavMenu.fillAmount = ImageNavMenu.fillAmount + i;
        ButtonChapters.fillAmount = ButtonChapters.fillAmount + i;
        ButtonBack.fillAmount = ButtonBack.fillAmount + i;
        if (ImageNavMenu.fillAmount < 1 && ImageNavMenu.fillAmount > 0)
        {
            StartCoroutine(startSlide(i));
            Debug.Log("If (ImageNavMenu.fillAmount >= 1 && ImageNavMenu.fillAmount < 0) StartCoroutine(startSlide(i));");
        }
        else if (ImageNavMenu.fillAmount == 0)
        {
            ImageNavMenu.gameObject.SetActive(false);
            Debug.Log("else if (ImageNavMenu.fillAmount == 0) ImageNavMenu.fillAmount >= 1 && ImageNavMenu.fillAmount < 0 StartCoroutine(startSlide(i));");
        }
    }
    
}
