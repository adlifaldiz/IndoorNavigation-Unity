using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollScript : MonoBehaviour
{
    public ScrollRect Scrollview;
    public GameObject ScrollContent;
    public GameObject ScrollItemP;

    // Start is called before the first frame update
    void Start()
    {
        List<string> itemsed = new List<string>();
        itemsed.Add("kursi");
        itemsed.Add("kasur");
        itemsed.Add("meja");
        itemsed.Add("sofa");
        itemsed.Add("laptop");
        itemsed.Add("lampu");
        itemsed.Add("lantai");
        itemsed.Add("karpet");
        itemsed.Add("TV");
        itemsed.Add("udud");
        itemsed.Add("korek");
        itemsed.Add("tas");
        //used to show list
        GenerateList(itemsed);
        //used to remove list 
        RemoveList();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateList(List<string> listed)
    {
        string items;
        for (int x = 0; x < listed.Count;x++)
        {
            items = listed[x];
       
            GameObject ScrollItemOBJ = Instantiate(ScrollItemP);
            ScrollItemOBJ.transform.SetParent(ScrollContent.transform, false);
            ScrollItemOBJ.transform.Find("Item").gameObject.GetComponent<Text>().text = items;
        }

        Scrollview.verticalNormalizedPosition = 1;

    }

    public void RemoveList()
    {
        for (var i = ScrollContent.transform.childCount - 1; i >= 0; i--)
        {
            var GameOBJ = ScrollContent.transform.GetChild(i);
            GameOBJ.transform.parent = null;
            Destroy(GameOBJ);
        }

        Scrollview.verticalNormalizedPosition = 1;

    }
}
