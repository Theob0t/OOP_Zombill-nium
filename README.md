# OOP_Zombillenium
C# - Object Oriented and Interface Programming Project (2017-2018)

Zombillénium is an amusement park in Valenciennes area.

The theme is fear: the aim is to frighten visitors. The staff is made up of monsters and wizards. Among the monsters, we can more precisely identify the zombies (the most important in number); the vampires (the most evil); the demons (which can be very powerful), the werewolves and the ghosts (or even invisible "men").

#*GOAL OF THE PROJECT* : Create a park management software that allows the employee to add/remove a staff member easily, check which attractions they are working on, the number of admission in any attractions, if it is open, in maintenance...#

RULES : 

Each member of staff has :
- a personnel number (5-digit integer)
- an identity (surname, first name, gender)
- possibly a position in the company (trade union delegate, trainee, director, etc.). 
- There are wizards in the staff, who are characterized by a tattoo that determines their rank (novice / mega / giga / strata), and they also have a list of powers (e. g. stealing, lighting a fire, etc.) that they can enrich over time. 
- The rest of the staff consists of monsters, who are assigned to an attraction, unless their functions occupy them 100%. 
- They also have a "prize pool", a receptacle of points received (or withdrawn) that allows them to be classified among monsters. 
- This prize pool is incremented or decremented according to the work, behavior, action of the monster concerned. It can allow him to obtain certain advantages depending on his value. 
- Among monsters, demons have a force defined by an integer between 1 and 10 
- Zombies can be bluish or greyish and are defined by a degree of decomposition, integer between 1 and 10 (skeletons have a degree of decomposition of 10). 
- We know the cruelty index of werewolves (real between 0 and 4). 
- Vampires have a luminosity index (real between 0 and 3, 3 being the very bright vampire). 
- Ghost invisibility can be a valuable asset sometimes, and a ghost may therefore be required for a specific task depending on the needs.

In order to obtain a beta version of the management software fairly quickly, it was decided to consider only 4 types of attractions: 
- "RollerCoaster", have a category (sitting / inverted / bobsleigh), and are allowed from a minimum size and a minimum age. 
- Shows, take place in a specified venue (Nergal, Leviathan, Kraken, etc.), have a number of seats and play at fixed times
- "DarkRides", have a journey time, and they are done in vehicles (like the "ghost train") or on foot (like the "haunted mansion"). 
- Shops, sell either souvenirs or cotton candy, or more generally food (sandwiches, drinks, ice cream, sweets, etc.).

Each attraction has:
- an identifier (3-digit integer) 
- a name. 
- We want to know at any time if it is open or closed
- If it is in maintenance for how long. 
- Maintenance can be a repair, a major cleaning, a refurbishment, a replenishment, etc. It also requires a minimum number of monsters to operate, which can be increased according to the number of visitors. It is also possible that they may need monsters with a special feature, or a particular type. 
