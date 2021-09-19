using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageManager : MonoBehaviour
{
    public Sprite t0, t1, t2, t3, t4, t5;
    public Sprite[] trashImages;
    public char[] trashAns;
    public int rand;

    private void Start()
    {
        trashImages = new Sprite[6];
        trashAns = new char[6];
        trashImages[0] = t0;
        trashImages[1] = t1;
        trashImages[2] = t2;
        trashImages[3] = t3;
        trashImages[4] = t4;
        trashImages[5] = t5;
        trashAns[0] = 'g';
        trashAns[1] = 'r';
        trashAns[2] = 'r';
        trashAns[3] = 'g';
        trashAns[4] = 'g';
        trashAns[5] = 'r';
    }

    public void changeImage()
    {
        rand = UnityEngine.Random.Range(0, 5);
        gameObject.GetComponent<Image>().sprite = trashImages[rand];
    }

    public bool checkAns(char ans)
    {
        if (ans == trashAns[rand]) return true;
        return false;
    }
}
