using UnityEngine;
using UnityEngine.UI;

public class gg : MonoBehaviour
{
    public Text gameOverText;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("prot"))
        {
            gameOverText.text = "Game Over";
        }
    }
}
