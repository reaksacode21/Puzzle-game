using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level2 : MonoBehaviour
{
    public void btnback()
    {
        SceneManager.LoadScene("home");
    }
    public void plagain()
    {
        SceneManager.LoadScene("l1");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (inOn)
        {
            starttime += Time.deltaTime;
            txtTime.text = "Time: " + Mathf.Max(0, Mathf.Round(starttime)).ToString();
            txttimeout.text = "YOUR TIME: " + Mathf.Max(0, Mathf.Round(starttime)).ToString();
          
        }
        //if (inOn = FindAnyObjectByType<DragNDropAdv>().isOn)
        //{
        //    txttimeout.text = txtTime.text;

        //    //txtTime.text = "Time: " + Mathf.Max(0, Mathf.Round(starttime)).ToString();
        //}

    }

    public Text txtTime,txttimeout;
    float starttime = 0;
    public bool inOn = true;
    public GameObject[] gamelevel,star;
    int op,n;
    public int piece;
    public Text txtlevel;
    public GameObject btnNext;
    public void btn()
    {
        piece = 0;
        btnNext.SetActive(false);
        inOn = true;
        starttime = 0;
        n++;
        leve(n);
        if (n <= 25)
        {
            txtlevel.text = "LEVEL:" + (n + 1).ToString();
        }
        else
        {
            txtlevel.text = "LEVEL:" + (10).ToString();
        }
        
    }
    public GameObject[] showPic;
    public void showImg()
    {
        StartCoroutine(show(op));
    }
     IEnumerator show(int op)
    {
        showPic[op].SetActive(true);
        yield return new WaitForSeconds(2f);
        showPic[op].SetActive(false);
    }

    public void leve(int n)
    {
        //op++;
        //op = FindAnyObjectByType<DragNDropAdv>().levelRun;
        op = n;
        print(op); 
        print(op);
        switch (op)
        {
            case 0:
                {
                    StartCoroutine(show(op));
                    for(int i = 0; i < op; i++){
                        gamelevel[i].SetActive(false);
                    
                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 1:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 2:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
            break;
            case 3:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 4:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 5:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 6:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 7:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 8:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 9:
                {
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
            case 10:
                {
                    FindAnyObjectByType<AudioSettings>().sfxAudio[2].Play();
                    StartCoroutine(show(op));
                    for (int i = 0; i < op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                    gamelevel[op].SetActive(true);
                    for (int i = 0; i > op; i++)
                    {
                        gamelevel[i].SetActive(false);

                    }
                }
                break;
        }
    }
    
}
