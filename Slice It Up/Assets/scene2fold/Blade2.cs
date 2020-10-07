using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade2 : MonoBehaviour
{
	public GameObject bladeTrailPrefab;
	public float minCuttingVelocity = .001f;

	bool isCutting = false;

	Vector2 previousPosition;

	Rigidbody2D rb;
	Camera cam;
	CircleCollider2D circleCollider;

	GameObject currentBladeTrail;

	public int s = 100;

	private gmanager2 gg;


	void Awake()
	{
		gg = GameObject.FindObjectOfType<gmanager2>();


	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.tag == "Fruit2")
		{
			gg.UpdateScore(s);

		}
	}


	void Start()
    {
		cam = Camera.main;
		rb = GetComponent<Rigidbody2D>();
		circleCollider = GetComponent<CircleCollider2D>();
	}

	// Update is called once per frame
	void Update()
    {
		if (Input.GetMouseButtonDown(0))
		{
			StartCutting();
		}
		else if (Input.GetMouseButtonUp(0))
		{
			StopCutting();
		}

		if (isCutting)
		{
			UpdateCut();
		}
	}

	void UpdateCut()
    {
		Vector2 newPosition = cam.ScreenToWorldPoint(Input.mousePosition);
		rb.position = newPosition;

		float velocity = (newPosition - previousPosition).magnitude * Time.deltaTime;
		if (velocity > minCuttingVelocity)
		{
			circleCollider.enabled = true;

		}
		else
		{
			circleCollider.enabled = false;
		}

		previousPosition = newPosition;

	}

	void StartCutting()
    {
		isCutting = true;
		currentBladeTrail = Instantiate(bladeTrailPrefab, transform);
		previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);
		circleCollider.enabled = false;
	}

	void StopCutting()
    {
		isCutting = false;
		currentBladeTrail.transform.SetParent(null);
		Destroy(currentBladeTrail, 2f);
		circleCollider.enabled = false;
	}
}
