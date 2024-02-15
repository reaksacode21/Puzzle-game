using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class PiecesAdv : MonoBehaviour
{
    private Vector2 RightPosition;
    public bool InRightPosition;
    public bool Selected;
    public AudioClip Piecescorrectplaceaud;
    void Start()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(1.5f, -1.5f), Random.Range(-3.3f, -2f));
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, RightPosition) < 0.5f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SortingGroup>().sortingOrder = 0;
                    Camera.main.GetComponent<DragNDropAdv>().PlacedPieces++;
                    //AudioSource.PlayClipAtPoint(Piecescorrectplaceaud, transform.position, 1f);
                    FindAnyObjectByType<AudioSettings>().sfxAudio[1].Play();
                }
            }
        }
    }
}
