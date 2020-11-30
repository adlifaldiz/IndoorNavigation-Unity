using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Startnavigate : MonoBehaviour
{
    [TextArea(15,17)]
    [SerializeField]
    private string Isi_Visi;
    [TextArea(15, 17)]
    [SerializeField]
    private string Isi_Misi;

    

    

    [SerializeField]
    private Button[] tombolKamar;

    [SerializeField]
    private Kamar[] kamars;

    [SerializeField]
    private GameObject InfoKamar;
    [SerializeField]
    private GameObject MainMenu;
    [SerializeField]
    private GameObject VisiMisi;
    [SerializeField]
    private GameObject Back;
    [SerializeField]
    private GameObject Backbutton2;
    [SerializeField]
    private GameObject VisiObject;
    [SerializeField]
    private GameObject MisiObject;
    [SerializeField]
    private GameObject pickerKamar;
    [SerializeField]
    private GameObject InfosKamar;
    [SerializeField]
    private GameObject JudulInfoKamar;
    [SerializeField]
    private Image GambarInfoKamar;
    [SerializeField]
    private GameObject PenjelasanInfoKamar;

    // Start is called before the first frame update
    void Start()
    {
        initnomorkamar();
        Refresh();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Back.active)
            {
                Refresh();
            }else if (Backbutton2.active)
            {
                startkamar();
            }
            else
            {
                Application.Quit();
            }
        }
    }

    public void startnav()
    {
        SceneManager.LoadScene("TestScene");
    }

    public void Refresh()
    {
        MainMenu.SetActive(true);
        InfoKamar.SetActive(false);
        VisiMisi.SetActive(false);
        Back.SetActive(false);
        Backbutton2.SetActive(false);
    }

    public void startVisi()
    {
        MainMenu.SetActive(false);
        InfoKamar.SetActive(false);
        VisiMisi.SetActive(true);
        Back.SetActive(true);

        VisiObject.GetComponent<Text>().text = Isi_Visi;
        MisiObject.GetComponent<Text>().text = Isi_Misi;
    }

    public void startkamar()
    {
        MainMenu.SetActive(false);
        InfoKamar.SetActive(true);
        VisiMisi.SetActive(false);
        Back.SetActive(true);
        InfosKamar.SetActive(false);
        pickerKamar.SetActive(true);
    }

    public void startkamars(int nomor)
    {
        Back.SetActive(false);
        Backbutton2.SetActive(true);
        pickerKamar.SetActive(false);
        InfosKamar.SetActive(true);
        JudulInfoKamar.GetComponent<Text>().text = kamars[nomor].judul;
        PenjelasanInfoKamar.GetComponent<Text>().text = kamars[nomor].penjelasan;
        if(kamars[nomor].image != null)
        {
        GambarInfoKamar.overrideSprite = kamars[nomor].image;
        }
    }

    public void initnomorkamar()
    {
        for(int i = 0; i < tombolKamar.Length; i++)
        {
            int NOMORS = i;
            tombolKamar[i].GetComponentInChildren<Text>().text = kamars[NOMORS].judul;
            tombolKamar[i].onClick.AddListener(() => startkamars(NOMORS));
            if (kamars[NOMORS].image != null)
            {
                tombolKamar[i].GetComponentInChildren<Image>().overrideSprite = kamars[NOMORS].image;
            }


        }
    }



}

[System.Serializable]
public class Kamar
{
    public String judul;
    [TextArea(15, 17)]
    public String penjelasan;
    public Sprite image;
}
