using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class SendData : MonoBehaviour
{
    //tutourial code from https://www.youtube.com/watch?v=2-tUwIQmBNE&ab_channel=1MinUnityTutorials
    //and https://www.youtube.com/watch?v=z9b5aRfrz7M&ab_channel=LuzanBaral

    [SerializeField] InputField username;
    [SerializeField] InputField age;
//    [SerializeField] InputField score;

    private string lvl1score;
    private string lvl1totalshot;
    private string lvl1left;
    private string lvl1right;
    private string lvl1total;

    private string lvl2playertime;
    private string lvl2aitime;
    private string lvl2idle;

    private string lvl3score;
    private string lvl3aitime;
    private string lvl3idle;

    private string lvl4score;
    private string lvl4aitime;
    private string lvl4idle;

    private string lvl5score;
    private string lvl5totalshot;
    private string lvl5left;
    private string lvl5right;
    private string lvl5total;

    string URL = "https://docs.google.com/forms/u/0/d/e/1FAIpQLSdoX8tl_U82WV-PL8N3RgAG0Dd03NkoqbnFJv6KNTT8_9nD6Q/formResponse";

    private void Start()
    {
        lvl1score = Savedatalvl1.lvl1score.ToString();
        lvl1totalshot = Savedatalvl1.lvl1totalshot.ToString();
        lvl1left = Savedatalvl1.lvl1left.ToString();
        lvl1right = Savedatalvl1.lvl1right.ToString();
        lvl1total = Savedatalvl1.lvl1total.ToString();

        lvl2playertime = RandomObjectToTarget.playertime.ToString();
        lvl2aitime = RandomObjectToTarget.aitime.ToString();
        lvl2idle = IdleLevel2.idletime.ToString();

        lvl3score = Teleport.lvl3score.ToString();
        lvl3aitime = Npc_Move_LVL3.aitime.ToString();
        lvl3idle = IdleLevel3.idletime.ToString();

        lvl4score = RandomObjectToBoard.lvl4score.ToString();
        lvl4aitime = NPC_Move_LVL4.aitime.ToString();
        lvl4idle = IdleLevel4.idletime.ToString();

        lvl5score = Savedatalvl5.lvl5score.ToString();
        lvl5totalshot = Savedatalvl5.lvl5totalshot.ToString();
        lvl5left = Savedatalvl5.lvl5left.ToString();
        lvl5right = Savedatalvl5.lvl5right.ToString();
        lvl5total = Savedatalvl5.lvl5total.ToString();

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;           
    
    }

    
    public void Send()
    {
        StartCoroutine(Post(username.text, age.text,
            lvl1score, lvl1totalshot, lvl1left, lvl1right, lvl1total,
            lvl2playertime, lvl2aitime, lvl2idle,
            lvl3score, lvl3aitime, lvl3idle,
            lvl4score, lvl4aitime, lvl4idle,
            lvl5score, lvl5totalshot, lvl5left, lvl5right, lvl5total));
    }

    IEnumerator Post(string name,string age,
        string lvl1score, string lvl1totalshot, string lvl1left, string lvl1right, string lvl1total,
        string lvl2playertime, string lvl2aitime, string lvl2idle,
        string lvl3score, string lvl3aitime, string lvl3idle,
        string lvl4score, string lvl4aitime, string lvl4idle,
        string lvl5score, string lvl5totalshot, string lvl5left, string lvl5right, string lvl5total)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.76079519", name);
        form.AddField("entry.2129698526", age);

        form.AddField("entry.178324438", lvl1score);
        form.AddField("entry.648517239", lvl1totalshot);
        form.AddField("entry.1985608981", lvl1left);
        form.AddField("entry.1099424950", lvl1right);
        form.AddField("entry.1492406362", lvl1total);

        form.AddField("entry.508069866", lvl2playertime);
        form.AddField("entry.427737820", lvl2aitime);
        form.AddField("entry.39654408", lvl2idle);

        form.AddField("entry.30668957", lvl3score);
        form.AddField("entry.85023085", lvl3aitime);
        form.AddField("entry.1494547338", lvl3idle);

        form.AddField("entry.239258476", lvl4score);
        form.AddField("entry.772920097", lvl4aitime);
        form.AddField("entry.1604901270", lvl4idle);

        form.AddField("entry.1235257130", lvl5score);
        form.AddField("entry.1605903358", lvl5totalshot);
        form.AddField("entry.119500767", lvl5left);
        form.AddField("entry.1775718831", lvl5right);
        form.AddField("entry.505038930", lvl5total);

        UnityWebRequest www = UnityWebRequest.Post(URL, form);

        yield return www.SendWebRequest();
    }

  
}