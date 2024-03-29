using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    // Declare a variable 
    [SerializeField] AudioClip cubeCollisionSound;
    [SerializeField] AudioClip sphereCollisionSound;
    [SerializeField] AudioClip capsuleCollisionSound;
    [SerializeField] AudioClip cylinderCollisionSound;

    private AudioSource audioSource;
    private ScoreManager scoreManager;

    public Text scoreText;
    private int score = 0;

    // Start is called before the f1irst frame update
    void Start()
    {
        // Add a audio source component
        audioSource = GetComponent<AudioSource>();
        scoreManager = FindObjectOfType<ScoreManager>();
        UpdateScoreText();
       
    }

    // Update is called once per frame
    void Update()
    { 
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cube"))
        {
            // Play the audio for the cube 
            GetComponent<AudioSource>().PlayOneShot(cubeCollisionSound);
        }
        else if (collision.gameObject.CompareTag("Sphere"))
        {
            // Play the audio for the Sphere
            GetComponent<AudioSource>().PlayOneShot(sphereCollisionSound);
        }
        else if (collision.gameObject.CompareTag("Capsule"))
        {
            // Play the audio for the Capsule
            GetComponent<AudioSource>().PlayOneShot(capsuleCollisionSound);
        }
        else if (collision.gameObject.CompareTag("Cylinder"))
        {
            // Play the audio for the cylinder
            GetComponent<AudioSource>().PlayOneShot(cylinderCollisionSound);
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("GreenObjects"))
        {
            Debug.Log("I am Green");
            // Increase the score by 1
            scoreManager.IncreaseScore(1);
            UpdateScoreText();
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("RedObjects"))
        {
            Debug.Log("I am Red");
            // Decrease the score by 1
            scoreManager.DecreaseScore(1);
            UpdateScoreText();
        }

        // Call a method  
        CheckCompletion();
    }
    public void UpdateScoreText()
    {
        scoreText.text = "Score: " + scoreManager.GetScore();
    }

    public void CheckCompletion()
    {
        int totalCollisions = scoreManager.GetScore();
        if (totalCollisions >= 8)
        {
            Debug.Log("Game Complete!");

            // Load the game completion scene
            SceneManager.LoadScene("End_Screen");
        }
    }
}
