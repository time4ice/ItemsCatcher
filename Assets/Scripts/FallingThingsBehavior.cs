using UnityEngine;

public class FallingThingsBehavior : MonoBehaviour
{
    public float lifeTime;

    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player")) return;
        var score = collision.gameObject.GetComponent<BallBehavior>().score;
        int currentScore = int.Parse(score.text);

        switch (gameObject.tag)
        {
            case "Good":
                score.text = (currentScore + 1).ToString();
                break;
            case "Bad":
                score.text = (currentScore - 1).ToString();
                break;
        }
        Destroy(gameObject);
    }
}
