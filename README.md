# Snack-Attack
![image](https://drive.google.com/uc?export=view&id=1fbyJY0SGviDN2HYMm29Z_7djszhKTxg4)
A CS 345 Game Development Fundamentals Team Project
Newly relicensed and rebranded!
Same great crunch!

## Overview


## Feedback
Please consider filling out one of our surveys!

## Misc
This readme is a copy/paste of the WorkLog. If details are our of place, consult Assets/Documentation/WorkLog.txt


------------------------------------------------------------------------------------------------




		WORK LOG

*&T WORK LOG
*&D 2019 08 27
*&A PJM


------------------------------------------------------------------------------------------------


		CONTENTS

*&T CONTENTS
*&D 2019 08 02
*&A PJM

	General
	*&CT CONTENTS					//Names of Notes
	*&CT HELLO					//Greetings
	*&CT REMINDERS					//Do this before running
	*&CT PROGRESS					//Deliverable Breakdown and Status
	
	Game Design
	*&CT GAME DESIGN				//Game design doc
	*&CT GAME CONTENT				//Hierarchically lists deliverables
	*&CT GAME FILES					//Name and Purpose
	*&CT TUTORIALS					//Helpful documents
	
	Legal
	*&CT MEMBERS					//Roles, Names, and Contacts
	*&CT CREDITS					//Anyone's property we use


------------------------------------------------------------------------------------------------


		HELLO

*&T HELLO
*&D 2019 08 02
*&A PJM

This is the "ReadMe" for this project.
Refer to this for any questions if I am unavailable.
When you do something, please update this document to reflect the change.
	I cannot stress this enough. PLEASE update this as you work.

This document is less about logging the work, and more about what the game looks like as a result of the work.
Don't record what work you did.
Instead, record what the results of your work are.
	Did you make 3D models for plants? Update the Progress of the Level2 Props.
	Did you add a death state in code? Update the Progress of the Death Feature.
	
I recommend updating this after you have finished your work.

Thank you for reading through this,
Peter


------------------------------------------------------------------------------------------------


		REMINDERS

*&T REMINDERS
*&D 2019 08 06
*&A PJM

Set the "PropsObject", "GlobalsObject", and, "ItemsObject" to "Static" (In upper right of Inspector)
	This prevents the monsters from running into obstacles


------------------------------------------------------------------------------------------------


		PROGRESS

*&T GAME PROGRESS
*&D 2019 08 02
*&A PJM

Content									//WIP


	Levels								//WIP
	
		Level1							//
			Background					//
			Props						//
			Elements					//
			Polish						//
	
		Level2							//
			Background					//
			Props						//
			Elements					//
			Polish						//


	Characters							//WIP

		Player							//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//
			
		Timmy							//
			Model						//
			Animation					//
			Texture						//
			Script						//
			Polish						//
	
		Marshmallow						//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//
	
		Chocolate						//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//
		
		Cracker							//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//


	Items								//WIP

		Marshmellow Ammo					//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//

		Chocolate Ammo						//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//

		Cracker Ammo						//
			Model						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//

		Narration						//
			Models						//PH
			Animation					//
			Texture						//
			Script						//
			Polish						//

		Health Kit						//
			Model						//
			Animation					//
			Texture						//
			Script						//
			Polish						//


	Interaction							//WIP

		Movement						//WIP
			Player Script					//DONE
			Monster Script					//WIP
			Polish						//
		
		Looking							//WIP
			Script						//DONE
			Polish						//

		Aiming							//
			Script						//
			HUD						//
			Polish						//
		
		Projectile						//
			Script						//
			Polish						//

		Pickup							//
			Script						//
			Polish						//

		Death							//
			Script						//
			Polish						//

		Spawn							//
			Script						//
			Polish						//

		Collide							//
			Script						//
			Polish						//

		Shoot							//
			Script						//
			Polish						//
		
		Music							//
			Script						//
			Polish						//
			Song						//DONE
		

	Menus								//WIP

		Main							//
			Script						//
			Layout						//
			Polish						//

		Pause							//
			Script						//
			Layout						//
			Polish						//

		Settings						//
			Script						//
			Layout						//
			Polish						//


	Writing								//WIP
		Storyboard						//
		Scenes							//
			Start						//
			Transition					//
			End						//
	
	
	Time								//WIP
		Week 6							//DONE
		Week 7							//WIP
		Week 8							//
		Week 9							//
		Week 10							//
		Week 11							//


Codes
	//			No Progress
	//WIP		Work in Progress
	//DONE		Work Done
	//PH		Place Holder Work


------------------------------------------------------------------------------------------------


		GAME DESIGN

*&T GAME DESIGN
*&D 2019 08 02
*&A PJM

Description:
	Theme:
		Camp Roast gone bad. Cutesy aesthetic with some spooky vibes..
	Length:
		15 minutes of play.
	Feel:
		Add Juice in vein of Teleglitch, bouncy, recoil, impact, sliding.
	Play:
		Core game loop consists of moving, looting, and shooting. Player explores the environment to progress the level. Otherwise, wave shooter.
	Menus:
		Pause - Adjust Settings, Reload, Quit (to Main Menu).
		Main - New, Load, Exit (to Desktop).
		Settings - Sliders, Keybinds



What makes it unique?
	Top-down combination shooter where the enemy is both the threat and the ammo.
	The player has to manage the types of bullets vs types of enemies.
	The food goes bad - the demonic way.



Similar Games?
	Teleglitch - topdown 3d shooter with item management.
	Half Life 2 - Weapons have multiple fire modes (gravity gun).



What’s Fun?
	Sensation "Game as sense-pleasure": NO
		The only sensations come from lights and sound - we have no dedicated audio specialist and will invest in the area only with spare time.

	Fantasy "Game as make-believe": NO
		Storytelling and lore is not a major faucet of this project in favor of action.

	Narrative "Game as unfolding story": YES
		We will have snippets of storytelling through art pieces and other sketched cutscenes.

	Challenge "Game as obstacle course": YES
		Moving and Shooting are the main skills being tested. Varying the environment and item placement is our main means of accomplishing this.

	Fellowship "Game as social framework": NO
		Multiplayer is a tedious process which does not fit our budget.

	Discovery "Game as uncharted territory": YES
		Depending on investment in level design, we may make larger maps with narrative and mechanical elements to explore.

	Expression "Game as soap box": NO
		No one on the team is an acclaimed writer or jumped at the opportunity.

	Submission "Game as mindless pastime": YES
		When not exploring larger level, the player engages in wave shooter survival.

	Fields taken from: http://www.algorithmancy.8kindsoffun.com/


------------------------------------------------------------------------------------------------


		GAME CONTENT

*&T GAME CONTENT
*&D 2019 08 02
*&A PJM

Content
	Levels - Two planned, more only if time permits.
		Background - hand drawn and converted to Unity terrain if time permits.
		Props - simple models and textures at most, use to form walls, bridges, some scenes for the player.
	Enemies - Three enemies at most.
		Model - One model per enemy.
		Animation - Three animations per enemy with plans for reuse - use similar skeleton and adjust animation as fit.
		Texture - One texture per enemy, plans to expand to 3 if time permits (weapon damage).
		Script - Shared across enemies, differ on attacks.
	Items
		Ammo - add 5 units of type of ammo to player pool.
		Narration - Pause game and play audio or some other message.
		Health - add 15 health to collider.
	Interaction
		Movement - Player Moves in orthogonal directions (North, South, West, East) using the W A S D keys.
		Aiming - Player moves reticle away from player and at ground using mouse.
		Pickup - Player picks up ammo and narration from the ground and despawns the item.
		Death - Player (or enemy) plays death animation and is removed from the game manager.
		Spawn - Player (or item) is instantiated at a coordinate.
		Collide - Player (or item) collides, preventing both objects from clipping.
		Shoot - Player launches a projectile in a direction with a velocity.
	Writing
		Scenes - Any pre-sketch plans for layout or reason of sketch in game.
		Items - Any papers or narrative items strewn throughout the environment.


------------------------------------------------------------------------------------------------


		GAME FILES

*&T GAME FILES
*&D 2019 08 02
*&A PJM

Assets

	Ammo						//Items the player can pickup to refill their gun
		MarshmellowAmmo			//Marshmellow variant ammo
		ChocolateAmmo			//Chocolate variant ammo
		CrackerAmmo				//Cracker variant ammo
	
	Debug						//Tools for error prevention
		DebugMaterial			//An annoying texture for invisble objects

	Documentation				//Thoughts, Notes, Concerns
		WorkLog.txt				//This file documents thoughts and semantics
	
	Forest						//Background Resources
		Ground					//A Simple Background
		Bush					//A Simple Bush
		Rock					//A Simple Rock
		Tree1					//A Simple Tree
		Tree2					//Another Simple Tree

	Game						//Gameplay scripts
		GameManager				//Script for all gameplay external to agents

	Lighting					//Environment illumination
		SunLight				//Default Directional Light
	
	Monsters					//Enemy Agents to Player
		MarshmellowMonster		//Marshmellow variant enemy
		ChocolateMonster		//Marshmellow variant enemy
		CrackerMonster			//Marshmellow variant enemy
	
	Player						//Player Resources
		PlayerObject			//Model, Material, and Script for Player
		PlayerCameraObject		//Camera, Script, and Rig for Player

	Story						//Dramatic Elements
		Book					//Cookbook the characters find
		CampFire				//A Campfire
		Tent					//A Tent

	Scenes						//Places the player plays in
		TestScene				//Prototype designs and ideas
		Story1Scene				//First Level
		Story2Scene				//Second Level

Asset Organization
	I have organized the individual features of the project into their own respective folders
	Each feature has an object - the in-game asset/end product of code, art, and description
	At the moment these are only basic assets I threw together
	The top level of each object is:
		Model
		Code
	The Model contains a 3D model or models in an empty object
	The Code contains a C# script or scripts NOT in an empty object - these can be loose
	Any additional features must be applied to the object as a whole, so any items from the inspector or otherwise

Scene Organization
	The scenes are also organized by feature
	The TestScene is an example:
		
		GlobalsObject		//Anything affecting everything
			Ground			//People walk on this
			Sun				//People use this to see
			GameManager		//Controls Events, Scores, and Death
		
		PropsObject			//Decorative items
			Bush			//An Instance of a bush
			Rock			//An Instance of some rocks

		ItemsObject			//Gameplay items, but not agents themselves
			Book			//An Instance of the cookbook
			Camp			//An Instance of the camp fire
			Tent			//An Instance of the tent
			MarshAmmo		//An Instance of MarshmellowAmmo
			Smore1			//An Instance of Smore

		PlayersObject		//Gameplay items the player controls
			Player			//The player's character
			Camera			//The player's camera and rig
			
		MonstersObject		//Gameplay agents
			Marsh			//An Instance of MarshmellowMonster
			Choc1			//An Instance of ChocolateMonster
			Choc2			//Another Instance of ChocolateMonster
		
	There should be no loose items in the directory. Create a semantically-classed folder and place them in it.


------------------------------------------------------------------------------------------------


		TUTORIALS

*&T TUTORIALS
*&D 2019 08 02
*&A PJM

Shooting
	Survival Shooter Tutorial - 1 of 10 : Environment - Unity Official Tutorials (new)
		https://www.youtube.com/watch?v=_lP6epjupJs&feature=youtu.be
		This is my primary reference for coding this game
		Part 1 is overview and setup							DONE
		Part 2 is player animation, physics, code				DONE (Need Models)
		Part 3 is camera code									DONE (Not Used)
		Part 4 is enemy effects, navigation, animation			DONE (Need Models, Health)
		Part 5 is health ui										DONE
		Part 6 is Health, Attacking								ERR (Cannot Drag Components)
		Part 7 has Death, Despawning, Polish
		Part 8 has a scoring system
		Part 9 is a spawner
		Part 10 is a death system
		
	Juicy Breakout Code Repo
		https://github.com/grapefrukt/juicy-breakout
		Includes code examples for making a game feel better

	Shooting with Raycasts - Unity Tutorial
		https://www.youtube.com/watch?v=THnivyG0Mvo
		I will reference this for coding the reticle
	
	Simple Gaze Cursor in Unity
		https://www.immersivelimit.com/tutorials/simple-gaze-cursor-in-unity
		I already control player direction with a technique similar to this.

Menus
	A Proper Way To Pause A Game
		https://answers.unity.com/questions/1230216/a-proper-way-to-pause-a-game.html
	
	Unity 5 making a simple pause menu
		https://www.youtube.com/watch?v=PyEmRVRHWL8
	
	[Unity3D] Simple pause menu in Unity3D
		https://www.youtube.com/watch?v=tdU9ujYMA_k

Version Control
	How to use Git for Unity3D source control?
		https://stackoverflow.com/questions/18225126/how-to-use-git-for-unity3d-source-control
		Covers possible approaches and techniques.
		
	How to prepare a Unity project for git?
		https://stackoverflow.com/questions/21573405/how-to-prepare-a-unity-project-for-git
		Steps to clean up a Unity Project.
		Mostly in editor checkboxes.
	
	Github's Hello World
		https://guides.github.com/activities/hello-world/
		This is a short reminder on how to use Git, especially with Github's website.
		2 minutes, max.
		
	Github's Flow Guide
		https://guides.github.com/introduction/flow/
		Another short reminder on the proper Git flow.
	
	Daggerfall Workshop Pages and Github
		https://www.dfworkshop.net/
		I especially recommend looking at how this Github is layed out.
		This is a large project, recreating an old game in Unity.
		Note how none of the art assets are located within the repo.
	
	A successful Git branching model
		https://nvie.com/posts/a-successful-git-branching-model/
		Covers how to think about branches.
		

------------------------------------------------------------------------------------------------


		MEMBERS

*&T MEMBERS
*&D 2019 08 02
*&A PJM

PJM
	Peter J Mangelsdorf
	pjm349@drexel.edu

AKT
	Alex Tallarico
	akt54@drexel.edu

DHL
	Deirdre Liu
	dhl33@drexel.edu

AAT
	Alex Talitskaya
	aat77@drexel.edu

MIH
	Mira Holahan
	mih37@drexel.edu


------------------------------------------------------------------------------------------------


		CREDITS

*&T CREDITS
*&D 2019 08 06
*&A PJM

Kevin MacLeod's "Fluffing a Duck"
	Music from https://filmmusic.io
	"Fluffing a Duck" by Kevin MacLeod (https://incompetech.com)
	License: CC BY (http://creativecommons.org/licenses/by/4.0/)

Jesper Kyd's "Oof"
	License: ???

Sheb Wooley's "Wilhelm Scream"
	Sound from https://archive.org/
	License: CC PD (https://creativecommons.org/licenses/publicdomain/)


------------------------------------------------------------------------------------------------


























































------------------------------------------------------------------------------------------------


		METAFORMAT

*&T METAFORMAT
*&D 2017 05 22
*&A PJM

General

	I put this information at the bottom of any external notes I share.
	This is the format I use for my notes
	It is both human and machine readable
	This allows it to be searched using CTRL + F, F3, or other shortcuts in most text editors
	The tagging system provides both semantic and lookup uses:

		Global
		*&T					//Title
		*&D					//Date
		*&A					//Author
	
		Local
		
		Content
		*&CT				//Global Contents Item
		*&CH				//Local Contents Item
	
	Do not worry about needing to know this
	If you do add notes, just be warned that I will update them to fit my style



Style

	Rule of Four
		It spaces things out to make them more readable and searchable
		Things are grouped into groups of 4 when there are more than 4 of a thing

	Gradation of Information
		Information flows left to right, less detail to more detail
		I do this through indent level and listing
			Indent Level
			Listing
		I limit this to avoid endless sub details and contents
	
	Space is Pace
		Notes should be easy to look at
		Spacing things for reading is a must
		If something looks like a wall of text, break things up by spacing until it looks better
	
	Recursion
		Rules which apply at one level apply at all levels
	
	Structure
		Any structure should be denoted by a table of contents
		This builds a searchable dictionary which can be searched through and searched for
	
	Comments
		Comments are information; Information is commentary
		I use "//" indented to the right of any text to make a meta-comment
		I generally use these in tables of contents to tell you what each item is
		If I have too many details, I newline and indent under the item to add information
		Some comments need comments - this is meta-commentary
			Meta commentary can go on endlessly, and really screw up formatting
			To address this, I cut it off after a point
			If you run out of space, make the meta-commentary its own note
		Examples
			
			Double Dash					//Here is the Comment
			
			Newline
				Here is the Comment
			
			Here is the Comment
			Header						//These are normally done for lists of things (like contents)
			
			Double - Double Dash		//Here is the Comment			//And here is the comment's comment
			
			New - Newline
				Here is the comment
					And here is the comment's comment
			
	Meta Information
		I attach three things to a note:
			When it was last updated (*&D)
			What I can call it (*&T/*&H)
			Who wrote it (*&A)
	
	Linked Information
		Some information may be duplicated across many places
		I use tagging to identify these areas so they can be modified simultaneously
		If you do not know how to script, do not worry about this




Tutorials

	Markdown
		https://github.com/adam-p/markdown-here/wiki/Markdown-Cheatsheet
		I use this for Git Documentation
		
	Searching
		Hold "Ctrl" and Press "F"		//This is the default shortcut on most editors
		Type "*&H NOTE"					//This shows all notes in this note concerning NOTES
		Type "*&H NOTE EXAMPLE"			//This takes you to the specific example note
		
	Block Indenting
		Most text editors support indenting multiple lines of text
		Highlight several lines and Press "Tab"
			This should shift the highlighted region right
		Now Hold "Shift" and Press "Tab"
			This should shift the highlighted region left
	
	Theories of Logic
		https://en.wikipedia.org/wiki/Metamathematics
		Existence, truth, and what it really means to be commentary on commentary
	
	Dictionary Theory
		https://en.wikipedia.org/wiki/Associative_array
		How I came to this crazy nonsense for tagging and ordering information
	
	Windows Shortcuts
		https://www.hongkiat.com/blog/100-keyboard-shortcuts-windows/
		I recommend using these to edit text as efficiently as possible
		Macintosh generally follows the same format


------------------------------------------------------------------------------------------------


		FORMAT
		
*&T FORMAT
*&D 2017 05 22
*&A PJM

*&H CONTENTS
	
	Notes
	*&CH NOTE PROTOTYPE
	*&CH NOTE COMMENTS
	*&CH NOTE EXAMPLE
	
	Contents
	*&CH CONTENTS PROTOTYPE
	*&CH CONTENTS COMMENTS
	*&CH CONTENTS EXAMPLE




*&H NOTE PROTOTYPE

|	------------------------------------------------------------------------------------------------
|
|
|			TITLE
|
|	*&T TITLE
|	*&D YYYY MM DD
|	*&A FML
|
|	Topic
|		Information
|		Information
|		Information
|			Detail
|			Detail
|				Max Level
|
|	Next Topic
|		Information
|
|
|	------------------------------------------------------------------------------------------------
	
	
	

*&H NOTE COMMENTS

|	------------------------------------------------------------------------------------------------
|	|-------------------------------------- 96 Dashes Separator -----------------------------------|
|								//Two Newlines to Start
|			TITLE				//Two Tabs & All Caps
|								//One Newline
|	*&T TITLE					//Title Tag & All Caps
|	*&D YYYY MM DD				//Date Tag & Numerics
|	*&A FML						//Author Tag & All Caps Initials
|
|	Topic						//Capped First Letter
|		Information				//One Tab
|		Information
|		Information
|			Detail				//Two Tabs
|			Detail
|				Max Level		//Try not to go over three tabs. Move information to it's own Topic.
|								//One Newline
|	Next Topic
|		Information
|								//Two Newlines to End
|	|-------------------------------------- 96 Dashes Separator------------------------------------|
|	------------------------------------------------------------------------------------------------





*&H NOTE EXAMPLE

|	------------------------------------------------------------------------------------------------
|
|
|			BISCUITS
|
|	*&T BISCUITS
|	*&D 2017 05 22
|	*&A PJM
|
|	Ingredients
|		Flour
|		Eggs
|		Milk
|			2% or Better
|			Thickened
|				Gradient of 5% or better
|
|	Reminder
|		Don't leave in the oven too long
|
|
|	------------------------------------------------------------------------------------------------





*&H CONTENTS PROTOTYPE

|	------------------------------------------------------------------------------------------------
|
|
|	*&H LOCAL CONTENTS
|		*&CH LOCAL ITEM				//Item Description
|
|	*&T SHORT CONTENTS
|		*&CT GLOBAL ITEM			//Item Description
|	
|	
|	
|	*&T LONG CONTENTS
|		
|		Topic
|		*&CT GLOBAL TOPIC ITEM			//Description
|		
|		Next Topic
|		*&CT GLOBAL NEXT TOPIC ITEM		//Description
|
|
|	------------------------------------------------------------------------------------------------




*&H CONTENTS COMMENTS

|	------------------------------------------------------------------------------------------------
|
|
|	*&H LOCAL CONTENTS
|		*&CH LOCAL ITEM				//Item Description		//Comment describes item in a sentence
|		
|		
|		
|	*&T SHORT CONTENTS
|		*&CT GLOBAL ITEM			//Item Description
|	
|	
|	
|	*&T LONG CONTENTS
|		
|		Topic							//Topic groups items together for readability
|		*&CT GLOBAL TOPIC ITEM			//Description
|		
|		Next Topic
|		*&CT GLOBAL NEXT TOPIC ITEM		//Description
|
|
|	------------------------------------------------------------------------------------------------




*&H CONTENTS EXAMPLE

|	------------------------------------------------------------------------------------------------
|
|
|	*&H CONTENTS
|		*&CH PARCHEESI				//Rules to play the game
|
|
|
|	*&T SHORTCUTS CONTETS
|		*&CT LISTING				//Lists shortcuts by name and function
|	
|	
|	
|	*&T LISTING CONTENTS
|		
|		Quitting
|		*&CT KILL WINDOW			//Closes the actively selected application
|		
|		Copying
|		*&CT SELECT ALL				//Highlights all text available in a closure
|
|
|	------------------------------------------------------------------------------------------------


------------------------------------------------------------------------------------------------


		ABOUT

*&T ABOUT
*&D 2019 08 02
*&A PJM

I am Peter Mangelsdorf
I am a computer scientist of interactive simulation
I can be reached at pjm349@drexel.edu or peter201943@gmail.com


------------------------------------------------------------------------------------------------

