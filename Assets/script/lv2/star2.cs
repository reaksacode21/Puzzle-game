using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class star2 : MonoBehaviour
{
    public GameObject starprefabe;
    public Transform currentPosition;
    public Transform[] starTransform;
    GameObject star;
    public List<GameObject> starlist;
    public void spawn()
    {
        star = Instantiate(starprefabe, currentPosition.position,Quaternion.identity);
        star.transform.localScale = new Vector3(.05f, .05f, .05f);
        starlist.Add(star);
    }
   
   public IEnumerator shooter(int positionIndex, Transform[] starTransform, bool isInstan)
    {
        while (isInstan) 
        {
            print(Time.deltaTime);
            star.transform.position = Vector3.MoveTowards(star.transform.position, new Vector3(starTransform[positionIndex].position.x, starTransform[positionIndex].position.y, -1f), 100 * Time.deltaTime);
            yield return null;
            StartCoroutine(enumerator());
            IEnumerator enumerator(){
                yield return new WaitForSeconds(1f);
            isInstan = false;
            }
        }
    }
}
