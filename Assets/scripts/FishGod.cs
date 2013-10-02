using UnityEngine;
using System.Collections;
using System.Collections.Generic; //the library for lists

public class FishGod : MonoBehaviour {
	
	//this class sets movement/destination/spawn parameters for all fish.
	
	public fish fishBlueprint;
	public fish2 fishBlueprint2;
	public int fishCount = 10;
																					//public int fishCount2 = 5;
	public List<fish> fishList = new List<fish>(); //List<Thing> is a list of Things. Everything in the list is of type Thing
	
	// Use this for initialization
	void Start () {
		
		//a counter for the while loop
		int currentFishCounter = 0; 
																					//int currentFishCounter2 = 0;
		//initial positions for both types of fish
		Vector3 fishPosition;
																					//Vector3 fishPosition2;
		
		//spawn fish at random positions while there are less than 100 fish
		while(currentFishCounter < fishCount)
		{
			//randomizer determines which fish will be chosen
			float randomizer = Random.Range(0f, 9f);
			fishPosition = Random.insideUnitSphere * 100f;
			
			//choose at random which fish to instantiate
			if(randomizer < 5f)
			{
			//cast fish as type Object so that Instantiate() can return correctly.
			fish newFish = Instantiate(fishBlueprint, fishPosition, Quaternion.identity) as fish;
			//every time a fish spawns, add it to the fishList.
			fishList.Add (newFish);	
			}
			
			else
			{
				fish2 newFish2 = Instantiate(fishBlueprint2, fishPosition, Quaternion.identity) as fish2;
			}
			
			currentFishCounter++;
		}
		
	/*	while(currentFishCounter2 < fishCount2)
		{
			fishPosition2 = Random.insideUnitSphere * 100f;
			
			//cast fish as type Object so that Instantiate() can return correctly.
			fish2 newFish2 = Instantiate(fishBlueprint2, fishPosition2, Quaternion.identity) as fish2;	
			currentFishCounter2++;
		}
	*/
	}
		
	// Update is called once per frame
	void Update () {
		
		//while the space bar is pressed, the fish god tells all fish to set destination to (0, 0, 0) 
		//not used for this homework but might as well have it in
		if (Input.GetKeyDown (KeyCode.Space))
		{	
			foreach(fish currentFish in fishList)
			{
				currentFish.destination = Vector3.zero;
			}
		}
	}
}
