using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ColScript : MonoBehaviour {
    public GameObject obj;
    public int r, g, b;
    public float sec;
    public int frame;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        sec += Time.deltaTime;
        frame += 1;

        r = Random.Range(0, 256);
        g = Random.Range(0, 256);
        b = Random.Range(0, 256);
        obj.GetComponent<Image>().color = new Color32((byte)r, (byte)g, (byte)b, 255);
    }

    private void Awake()
    {
        Application.targetFrameRate = 60;
    }
}
