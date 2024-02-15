using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class manuscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        btn1.Play("idle");
        btn2.Play("idle");
        btn3.Play("idle");
    }
    public Animator btn1,btn2,btn3;
    // Update is called once per frame
    void Update()
    {
        
    }
    public void slide9()
    {
        FindAnyObjectByType<AudioSettings>().sfxAudio[0].Play();
        btn1.Play("btn1");
        StartCoroutine(wait());
       
    }
    public void slide25()
    {
        FindAnyObjectByType<AudioSettings>().sfxAudio[0].Play();
        btn2.Play("btn2");
        StartCoroutine(wait1());
       
    }
    public void slide36()
    {
        FindAnyObjectByType<AudioSettings>().sfxAudio[0].Play();
        btn3.Play("btn3");
        StartCoroutine(wait2());
       
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene("l1");
    }
    IEnumerator wait1()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene("l2");
    }
    IEnumerator wait2()
    {
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene("l3");
    }
    public  void btnhome()
    {
        SceneManager.LoadScene("home");
    }
}
