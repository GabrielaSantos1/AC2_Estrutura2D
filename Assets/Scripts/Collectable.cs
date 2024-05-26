using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{

	public GameObject gemVisuals;
	public GameObject collectedParticleSystem;
	public CircleCollider2D gemCollider2D;

	private float durationOfCollectedParticleSystem;


	void Start()
	{
		durationOfCollectedParticleSystem = collectedParticleSystem.GetComponent<ParticleSystem>().main.duration;
	}

	void OnTriggerEnter2D(Collider2D theCollider)
	{
		if (theCollider.CompareTag("Player"))
		{
			GemCollected();
			GameManager.Instance.SetScore(1);

		}
	}

	void GemCollected()
	{
		gemCollider2D.enabled = false;
		gemVisuals.SetActive(false);
		collectedParticleSystem.SetActive(true);
		Invoke("DeactivateGemGameObject", durationOfCollectedParticleSystem);
		

	}

	void DeactivateGemGameObject()
	{
		gameObject.SetActive(false);
	}
}