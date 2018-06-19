using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour
{
    int mp = 53;

    //Magic関数
    void Magic() {

        for(mp = 53; mp > 0 ; mp = mp-5) {
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        Debug.Log("MPが足りないため魔法が使えない。");
    }


    // Use this for initialization
    void Start()
    {
        // 配列の宣言
        int[] points = new int[5];

        points[0] = 1;
        points[1] = 2;
        points[2] = 3;
        points[3] = 4;
        points[4] = 5;


        // For文を使って正順表示させる
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(points[i]);
        }

        // For文を使って逆順に表示させる
        for (int i = 4; i > -1; i--)
        {
            Debug.Log(points[i]);
        }

        Magic();    

    }




    // Update is called once per frame
    void Update()
    {

    }
}