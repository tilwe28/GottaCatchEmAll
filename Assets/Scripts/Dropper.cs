using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dropper : MonoBehaviour
{

    public GameObject myPrefab;
    public string anim1;
    public GameObject ball, paddle;
    private int count;
    private Text scoreText;
    private float time;
    private bool spawned;

    // Start is called before the first frame update
    void Start()
    {
        time = 0;
        count = 0;
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        paddle = GameObject.Find("Paddle");

        float rx = Random.Range(-8f, 8f);
        float rz = Random.Range(1.25f, 7.5f);
        ball = Instantiate(myPrefab, new Vector3(rx, 11f, rz), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= 3)
        {
            /*if (ball.transform.position.x < paddle.transform.position.x + 1 && ball.transform.position.x > paddle.transform.position.x - 1 && ball.transform.position.z < paddle.transform.position.z + 1 && ball.transform.position.z > paddle.transform.position.z - 1)
            {
                ball.GetComponent<Renderer>().enabled = false;
                ball.GetComponent<ParticleSystem>().Stop();
                Destroy(ball, 1.0f);
                count++;
                scoreText.text = "Score: " + count;
                if (count == 10)
                {
                    UnityEditor.EditorApplication.isPlaying = false;
                    Application.Quit();
                }
            }*/

            float rx = Random.Range(-8f, 8f);
            float rz = Random.Range(1.25f, 7.5f);
            ball = Instantiate(myPrefab, new Vector3(rx, 11f, rz), transform.rotation);
            time = 0;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        count++;
        scoreText.text = "Score: " + count;
        ball.GetComponent<Renderer>().enabled = false;
        ball.GetComponent<ParticleSystem>().Stop();
        Destroy(ball, 2f);
        if (count == 10)
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }
    }
}