using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Player player;
    public Text scoreText;
    public GameObject playButton;
    public GameObject gameOver;
    private int score;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Play()
    {
        score = 0;
        scoreText.text = score.ToString();

        gameOver.SetActive(false);
        playButton.SetActive(false);

        Time.timeScale = 1;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            // Pipes ��ü�� �����ϴ� ���� �ƴ϶� ���ӿ�����Ʈ�� Destroy�ؾ��Ѵ�.
            Destroy(pipes[i].gameObject);
        }
    }
    public void Pause()
    {
        // �÷��̾��� ��� �������� deltaTime�� ���ؼ� �����δ�.
        // �Ʒ� ������ ���ؼ� �÷��̾ ���߰� �ȴ�.
        Time.timeScale = 0;
        player.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);
        Pause();
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

}
