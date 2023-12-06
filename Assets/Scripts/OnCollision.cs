using UnityEngine;
using UnityEngine.UI;
public class OnCollision : MonoBehaviour
{

	public PlayerMovement movement;
	public int coinscore = 0;
	public Text coinscoretext;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;	
			FindObjectOfType<GameManager>().EndGame();
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Coin")
		{
			Debug.Log("udarili smo coin");
			coinscore++;
			coinscoretext.text = coinscore.ToString("0");
			Destroy(other.gameObject);
		}
	}

}

