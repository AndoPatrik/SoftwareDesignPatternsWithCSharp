Singleton (Creational)
=======

Intent
-----------
Ensure a class has only one instance and provide a global point of access to it. Responsible for creating and maintaining its own unique instance. For encapsulation, you can either instantiate it on start(eager) or first use of the object(lazy). 

Motivation
-----------
There are situations when in a project we need only one instance of an object to be created and shared. Outside from the class new instance cannot be created, but can be retrieved. Creating Singleton is more appropriate than creating global variables. 

UML
-----------
![Singleton UML](https://www.researchgate.net/profile/Armando_Rene_Narvaez_Contreras/publication/314175216/figure/fig8/AS:467513608806409@1488475338499/Singleton-pattern-class-diagram.png)

Implementation
-----------
* Private constructor (prevents obj creation)
* Static method to get the obj

Consequences
-----------
Advantages
* Takes carte of concurrent acces to shared resource
* Share common data (config)
* Easy to maintain (Single global access point)
* Reduce overhead of instantiatinmg heavy objects again and again
* 

Drawbacks
* Violate the single responsiblity principle (able to control their own creation and lifecycle)
* Global instance may lead to hidden data exposure

Known uses
-----------
* Logging
* Caches
* Thread pools
* Configuration settings
* DB connections
* Windows registry

Related Patterns
-----------
* Builder
* Factory
* Prototype



