using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualDerived
	{
	////////////////////////////////////////////////////////////
	///// GENERIC CLASS
	////////////////////////////////////////////////////////////
	// Start with a generic class about animals.
	class Animal
		{
		////////////////////////////////////////////////////////////
		// VARIABLES
		private String mName; // Private so this variable can only be accessed inside this class.
		protected int mLegs; // Protected so this variable can be accessed by this class and derived classes.
		public bool mWarmblooded; // Public so this variable can be accessed by anyone. 

		////////////////////////////////////////////////////////////
		// ATTRIBUTES
		// An attribute
		public int mEyes
			{ 
			get;
			set;
			}

		// This variable is readonly attribute
		public bool mIsCute
			{
			get
				{
				if (mLegs <= 2)
					{ return true; }
				return false;
				}
			}

		// This one is writeonly attribute
		public bool mIsWarm
			{
			set 
				{ 
				if (value == true)
					{ 
					mWarmblooded = true; 
					return; 
					}
				mWarmblooded = false;
				}
			}

		////////////////////////////////////////////////////////////
		// CONSTRUCTORS
		// Default constructor.
		public Animal()
			{ 
			mEyes = 2;
			mName = "A random animal.";
			mLegs = 2;
			mWarmblooded = true;
			}

		// Constructor if values are given.
		public Animal(int eyes, String name, int legs, bool warmblooded)
			{
			mEyes = eyes;
			mName = name;
			mLegs = legs;
			mWarmblooded = warmblooded;
			}

		// Blank Destructor
		~Animal()
			{ 
			}
		////////////////////////////////////////////////////////////

		////////////////////////////////////////////////////////////
		// METHODS
		// Method to print out the information about the animal.
		public void PrintInfo()
			{
			if (mWarmblooded == true)
				{ System.Console.Write("The animal is a {0}. It has {1} eyes, {2} legs, and it is warmblooded.", mName, mEyes, mLegs); }
			else
				{ System.Console.Write("The animal is a {0}. It has {1} eyes, {2} legs, and it is coldblooded.", mName, mEyes, mLegs); }
			}
		////////////////////////////////////////////////////////////
		}

	////////////////////////////////////////////////////////////
	// SEALED CLASS
	////////////////////////////////////////////////////////////
	public sealed class Creature
		{
		// This can't be derived off of.
		}

	////////////////////////////////////////////////////////////
	// DERIVED CLASS
	////////////////////////////////////////////////////////////
	public class Mammal: Animal
		{
		// To be filled in
		}

	////////////////////////////////////////////////////////////
	// DERIVED FROM DERIVED CLASS
	////////////////////////////////////////////////////////////
	public class Human : Animal
	{
		// To be filled in
	}

	////////////////////////////////////////////////////////////
	////// MAIN CLASS
	////////////////////////////////////////////////////////////
	// Let's keep our main in a seperate class.
	class MainStartup
		{
		// Our main function.
		static void Main(string[] args)
			{

			}
		}
	////////////////////////////////////////////////////////////
	}
