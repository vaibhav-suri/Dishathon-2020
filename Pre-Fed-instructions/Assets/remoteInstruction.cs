using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class remoteInstruction : MonoBehaviour
{
    public GameObject[] particles = new GameObject[6];
    public Text txt;
    private int clickCount = 0;
    public GameObject okay;
    public GameObject buttton;
    public GameObject textt;
    public GameObject customerservice;

    private void Start()
    {
        okay.SetActive(false);
    }
    public void clicker()
    {
        clickCount++;
        if (clickCount == 0)
        {
            return;
        }
        if(clickCount == 1)
        {
            txt.text = "press red button";
            particles[0].SetActive(true);
        }
        else if (clickCount == 2)
        {
            txt.text = "press OK";
        }
        else if (clickCount == 3)
        {
            txt.text = "press yellow button";
        }
        else if (clickCount == 4)
        {
            txt.text = "press blue button";
        }
        else if (clickCount == 5)
        {
            txt.text = "press down arrow";
        }
        else if (clickCount == 6)
        {
            txt.text = "press OK";
        }
        else if (clickCount == 7)
        {
            okay.SetActive(true);
            buttton.SetActive(false);
            txt.text = "troubleshoot complete!";
            customerservice.SetActive(true);
            textt.SetActive(false);
        }
        particles[clickCount - 2].SetActive(false);
        particles[clickCount - 1].SetActive(true);
    }
    public void scenerr()
    {
        SceneManager.LoadScene("main");
    }
}
