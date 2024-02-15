using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    public Animator panelplay,panelsetting;
    public GameObject Gpnsetting;
    // Start is called before the first frame update
    void Start()
    {
        panelplay.Play("On");
        //FindAnyObjectByType<AudioSettings>().sfxAudio[0].Play();
    }
    public void btnstart()
    {

        panelplay.Play("off");
        FindAnyObjectByType<AudioManager>().sfxAudio[0].Play();
        StartCoroutine(wait1());
        
        
        
    }
    public void btnQuite()
    {
        FindAnyObjectByType<AudioManager>().sfxAudio[0].Play();
        panelplay.Play("off");
        StartCoroutine(wait());
        Application.Quit();
    }
    public void  btnSetting()
    {
        
        Gpnsetting.SetActive(true);
        FindAnyObjectByType<AudioManager>().sfxAudio[0].Play();
        panelsetting.Play("settingon");
    }
    public void btncloseSetting()
    {
        FindAnyObjectByType<AudioManager>().sfxAudio[0].Play();
        panelsetting.Play("setting");
        StartCoroutine(waitsetting());
       
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waitsetting()
    {
        yield return new WaitForSeconds(2f);
        Gpnsetting.SetActive(false);
    }
    IEnumerator wait1()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("menu");
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(2f);
       
    }
}
