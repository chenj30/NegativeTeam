using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GenerateLevel : MonoBehaviour {

	List<string> NegativeWords;
	List<string> PositiveWords;


	// Use this for initialization
	void Start () {
		NegativeWords = new List<string> { "Abysmal", "Angry", "Annoying", "Anxious", "Apathy", "Atrocious", "Awful", "Bad", "Belligerent", 
			"Boring", "Broken", "Callous", "Clumsy", "Cold", "Collapse", "Confused", "Contrary", "Corrosive", "Crazy", "Creepy", "Cruel", 
			"Crying", "Cutting", "Dead", "Decaying", "Damaging", "Deplorable", "Depressed", "Deprived", "Deny", "Dirty", "Disgusting", "Dishonest", 
			"Distress", "Dreadful", "Enraged", "Evil", "Failure", "Fear", "Foul", "Frightening", "Ghastly", "Grim", "Gross", "Guilty", "Harmful", "Hatred", 
			"Heartless", "Horrible", "Hostile", "Hurtful", "Ignored", "Infernal", "Injurious", "Insane", "Jealousy", "Loss", "Malicious", "Mean", "Menacing", 
			"Misunderstood", "Nasty", "Negative", "Never", "Nonsense", "Objectionable", "Offensive", "Oppressive", "Painful", "Pessimistic", "Pointless", 
			"Poisonous", "Questionable", "Quit", "Rejection", "Repulsive", "Revenge", "Rotten", "Rude", "Sad", "Scary", "Severe", "Sickening", "Sobbing", 
			"Spiteful", "Stressful", "Stupid", "Suspicious", "Terrible", "Threatening", "Unfair", "Unhappy", "Unlucky", "Unwanted", "Upset", "Useless", 
			"Vicious", "Vindictive", "Wicked", "Worthless" };
		PositiveWords = new List<string> { "Accepted", "Accomplishment", "Achievement", "Admiration", "Agreeable", "Amazing", "Appealing", 
			"Approval", "Awesome", "Beautiful", "Belief", "Bliss", "Bravery", "Brilliant", "Celebration", "Charming", "Cheery", "Congratulate", 
			"Courageous", "Cute", "Delightful", "Divine", "Easy", "Effective", "Elegant", "Encourage", "Energetic", "Esteemed", "Excellent", 
			"Exciting", "Fabulous", "Fantastic", "Fortune", "Friendly", "Fun", "Generous", "Genuine", "Gorgeous", "Great", "Grin", "Handsome", 
			"Happiness", "Health", "Honesty", "Honor", "Ideal", "Imagination", "Impressive", "Intelligent", "Joyful", "Jubilant", "Kind", "Laughter", 
			"Lively", "Lucky", "Magnificent", "Marvelous", "Merit", "Motivation", "Nice", "Nurturing", "Open", "Optimism", "Perfection", "Pleasant", 
			"Popular", "Positive", "Pretty", "Productive", "Progress", "Proud", "Quality", "Refreshing", "Reliable", "Remarkable", "Respect", "Reward", 
			"Right", "Safe", "Satisfying", "Skilled", "Smile", "Special", "Spirited", "Stupendous", "Successful", "Sunny", "Super", "Supportive", 
			"Terrific", "Tranquility", "Trust", "Truth", "Upbeat", "Value", "Vibrant", "Victory", "Vitality", "Wealth", "Wonderful"};
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) {
			Debug.Log(PositiveWords[Random.Range(0, PositiveWords.Count - 1)]);
		}
		if (Input.GetKeyDown (KeyCode.N)) {
			Debug.Log(NegativeWords[Random.Range(0, PositiveWords.Count - 1)]);
		}
	}
}
