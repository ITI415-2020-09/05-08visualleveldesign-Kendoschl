using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.InputSystem;
using TMPro;

public class PickUp : MonoBehaviour
{
    public AudioClip coin;
    public AudioClip door;
    public AudioClip victory;
    public AudioSource audioS;
    public GameObject Block1;
    public GameObject Block2;
    public GameObject Block3;
    public GameObject Block4;
    public GameObject Block5p1;
    public GameObject Block5p2;
    public GameObject Block6;
    public GameObject EntranceBlock;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI winText;
    private int count;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("RedPickUp"))
        {
            other.gameObject.SetActive(false);
            Block1.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("BluePickUp"))
        {
            other.gameObject.SetActive(false);
            Block2.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("GreenPickUp"))
        {
            other.gameObject.SetActive(false);
            Block5p1.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("CyanPickUp"))
        {
            other.gameObject.SetActive(false);
            Block5p2.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("WhitePickUp"))
        {
            other.gameObject.SetActive(false);
            Block3.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("BlackPickUp"))
        {
            other.gameObject.SetActive(false);
            EntranceBlock.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("GreyPickUp"))
        {
            other.gameObject.SetActive(false);
            Block6.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("OrangePickUp"))
        {
            other.gameObject.SetActive(false);
            Block4.SetActive(false);
            audioS.PlayOneShot(door);
        }
        else if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            audioS.PlayOneShot(coin);
        }
        else if (other.gameObject.CompareTag("Exit"))
        {
            winText.enabled = true;
            winText.text = "You Are Free! You Got " + count.ToString() + " Points!";
            audioS.PlayOneShot(coin);
        }
    }

    void SetCountText()
    {
        countText.text = "Points: " + count.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        SetCountText();
        winText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
