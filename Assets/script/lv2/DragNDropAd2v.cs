using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DragNDropAdv2 : MonoBehaviour
{
    public AudioClip clkpieceaudio;
    public Sprite[] Levels;

    public GameObject EndMenu,time;
    public GameObject SelectedPiece;
    public star2 instanstar=new star2();
    public AudioSettings sound=new AudioSettings();
    private Vector2 screenBounds;
    public 
    int OIL = 1;
    public int PlacedPieces = 0;
   public int levelRun;
     public bool isInstan1 = true, isInstan2 = true, isInstan3 = true;
    public GameObject[] picwin;
    public bool isOn;
    void Start()
    {
        // Commented out the unnecessary initialization code
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.transform != null && hit.transform.CompareTag("PuzzleAdv"))
            {
                if (!hit.transform.GetComponent<PiecesAdv2>().InRightPosition)
                {
                    SelectedPiece = hit.transform.gameObject;
                    SelectedPiece.GetComponent<PiecesAdv2>().Selected = true;
                    sound.sfxAudio[0].Play();
                   // AudioSource.PlayClipAtPoint(clkpieceaudio, transform.position, 0.1f);
                    SelectedPiece.GetComponent<SortingGroup>().sortingOrder = OIL;
                    OIL++;
                }
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (SelectedPiece != null)
            {
                SelectedPiece.GetComponent<PiecesAdv2>().Selected = false;
                SelectedPiece = null;
            }
        }

        if (SelectedPiece != null)
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            SelectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        if (PlacedPieces == 8)
        {
            
            //FindAnyObjectByType<level1>().star[0].SetActive(true);
            if (isInstan1)
            {
                print(isInstan1);
                instanstar.spawn(); 
                StartCoroutine(instanstar.shooter(0, instanstar.starTransform, isInstan1));
                isInstan1 = false;
            }
            
        }
        if (PlacedPieces == 16)
        {
            
            if (isInstan2) 
            {
                instanstar.spawn();
                StartCoroutine(instanstar.shooter(1, instanstar.starTransform, isInstan2)); 
                isInstan2 = false;
            }
        }
        if (PlacedPieces == 24)
        {
            sound.sfxAudio[2].Play();
        }
        if (PlacedPieces == 25)
        {
            time.SetActive(true);
            // isOn = false;
            FindAnyObjectByType<level2>().inOn = false;
            int op=-1;
            op++;
            
            if (isInstan3) 
            {
                instanstar.spawn();
                StartCoroutine(instanstar.shooter(2, instanstar.starTransform,isInstan3));
                isInstan3 = false;
            }
            picwin[op].SetActive(true);
            EndMenu.SetActive(true);
        }

    }
    public void levelup()
    {
       
    }
    public void btnclosstar()
    {
        time.SetActive(false);
        FindAnyObjectByType<level2>().inOn = true;
        foreach (var star in instanstar.starlist) {
            Destroy(star.gameObject);
        }
        instanstar.starlist.Clear();
        EndMenu.SetActive(false);
        PlacedPieces = FindAnyObjectByType<level2>().piece;
        PlacedPieces = 0;
        isInstan1 =  isInstan2 =  isInstan3 = true;
        for (int i = 0;i< 3; i++)
        {

            FindAnyObjectByType<level2>().star[i].SetActive(false);
        }
        
        print(false);
    }

    // Add any necessary methods here

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Levels");
    }
}