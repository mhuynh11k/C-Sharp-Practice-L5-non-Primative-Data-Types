//---------------------------------------------------------------------
// Question 1: Player Class
// Create a class named "Player" to represent a character in a role-playing game.
// Include attributes for the player's name, level, health points (HP), and experience points (XP).
// Implement methods to level up the player, heal the player, and gain experience points.
// Hint: Declare a class with properties for name, level, HP, and XP. Implement methods to increase level, heal HP, and gain XP.
/* Think about how players progress in a typical RPG game. Consider what actions a player can take and how they affect the player's attributes. */
public class Player
{
    public string Name { get; set; }
    public int Level { get; set; }
    public int HP { get; set; }
    public int MaxHP { get; private set; }
    public int XP { get; set; }
    public int MaxXP { get; private set; }

    public Player(string name)
    {
        Name = name;
        Level = 1;
        MaxHP = 100;
        HP = MaxHP;
        XP = 0;
        MaxXP = 100;
    }

    // Method to level up the player
    public void LevelUp()
    {
        Level++;
        MaxHP += 20; // Increase max HP by 20 for each level up
        HP = Math.Min(HP + 20, MaxHP);
        MaxXP = (int)(MaxHP * 1.5); // Increase XP required for the next level
        Console.WriteLine($"{Name} leveled up to level {Level}! Max HP is now {MaxHP} and next level needs {MaxXP} XP.");
    }

    // Method to heal the player
    public void Heal(int amount)
    {
        HP += amount;
        if (HP > MaxHP) HP = MaxHP; // Cap HP at current max HP
        Console.WriteLine($"{Name} healed for {amount} HP. Current HP: {HP}");
    }

    // Method to gain experience points
    public void GainXP(int amount)
    {
        XP += amount;
        while (XP >= MaxXP)
        {
            XP -= MaxXP;
            LevelUp();
        }
        Console.WriteLine($"{Name} gained {amount} XP. Current XP: {XP}/{MaxXP}");
    }
}
//---------------------------------------------------------------------
// Question 2: Enemy Class
// Develop a class called "Enemy" to represent adversaries in a video game.
// Include properties for the enemy's name, health points (HP), attack power, and defense.
// Implement methods to calculate damage inflicted by the enemy and to update their HP.
// Hint: Define a class with attributes for name, HP, attack power, and defense. Create methods to calculate damage and update HP.
/* Consider the role enemies play in games. They typically attack players and can be defeated by reducing their HP to zero. */

public class Enemy
{
    public string Name { get;  set; }
    public int HP { get;  set; }
    public int AttackPower { get;  set; }
    public int Defense { get;  set; }

    public Enemy(string name, int hp, int attackPower, int defense)
    {
        Name = name;
        HP = hp;
        AttackPower = attackPower;
        Defense = defense;
    }

    // Calculate damage against a target using its defense. Ensures at least 1 damage.
    public int CalculateDamage(int targetDefense)
    {
        int damage = AttackPower - targetDefense;
        return Math.Max(1, damage);
    }

    // Apply damage to this enemy's HP
    public void TakeDamage(int damage)
    {
        HP -= damage;
        if (HP < 0) HP = 0;
    }

    // Attack another enemy (or player-like object represented by defense value)
    public int AttackTarget(Enemy target)
    {
        int dmg = CalculateDamage(target.Defense);
        target.TakeDamage(dmg);
        return dmg;
    }

    public bool IsDefeated => HP <= 0;
}


//---------------------------------------------------------------------
// Question 3: Potion Class
// Design a class named "Potion" to model health-restoring items in an adventure game.
// Include properties for the potion's name, healing power, and quantity in inventory.
// Implement a method to apply the potion to a player character and restore their health.
// Hint: Define a class with attributes for name, healing power, and quantity. Create a method to apply the potion and heal the player.
/* Think about how healing items function in games. They typically restore a portion of a player's health when consumed. */
public class Potion
{
    public string Name { get;  set; }
    public int HealingPower { get;  set; }
    public int Quantity { get;  set; }

    public Potion(string name, int healingPower, int quantity)
    {
        Name = name;
        HealingPower = healingPower;
        Quantity = quantity;
    }

    // Method to apply the potion to a player character and restore their health
    public void Apply(Player player)
    {
        if (Quantity > 0)
        {
            player.Heal(HealingPower);
            Quantity--;
            Console.WriteLine($"{Name} applied. Remaining quantity: {Quantity}");
        }
        else
        {
            Console.WriteLine($"No {Name} left to apply.");
        }
    }
}
//---------------------------------------------------------------------
// Question 4: Quest Class
// Create a class called "Quest" to represent tasks or missions in a quest-based game.
// Include properties for the quest's name, description, reward, and completion status.
// Implement methods to start the quest, complete the quest, and claim the reward.
// Hint: Define a class with attributes for name, description, reward, and completion status. Implement methods to manage quest progress.
/* Consider the structure of quests in games. They often involve objectives, rewards, and tracking completion status. */
public class Quest
{
    public string Name { get;  set; }
    public string Description { get;  set; }
    public int Reward { get;  set; }
    public bool IsCompleted { get; private set; }

    public Quest(string name, string description, int reward)
    {
        Name = name;
        Description = description;
        Reward = reward;
        IsCompleted = false;
    }

    // Method to start the quest
    public void Start()
    {
        Console.WriteLine($"Quest '{Name}' started: {Description}");
    }

    // Method to complete the quest
    public void Complete()
    {
        if (!IsCompleted)
        {
            IsCompleted = true;
            Console.WriteLine($"Quest '{Name}' completed! Reward: {Reward} XP");
            return;
        }
        else
        {
            Console.WriteLine($"Quest '{Name}' is not completed.");
        }
    }
}
//---------------------------------------------------------------------
// Question 5: Inventory Class
// Develop a class named "Inventory" to manage a player's items in a role-playing game.
// Include properties for the inventory's capacity, list of items, and methods to add/remove items.
// Implement functionality to check if an item exists in the inventory and display its details.
// Hint: Define a class with attributes for capacity and a list of items. Create methods to add, remove, and search for items.
/* Think about how inventories work in games. Players can store and manage various items they collect during their adventures. */
public class Inventory
{
    public int Capacity { get;  set; }
    public List<string> Items { get; private set; }

    public Inventory(int capacity)
    {
        Capacity = capacity;
        Items = new List<string>();
    }

    // Method to add an item to the inventory
    public bool AddItem(string item)
    {
        if (Items.Count < Capacity)
        {
            Items.Add(item);
            Console.WriteLine($"{item} added to inventory.");
            return true;
        }
        else
        {
            Console.WriteLine("Inventory is full. Cannot add item.");
            return false;
        }
    }

    // Method to remove an item from the inventory
    public bool RemoveItem(string item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
            Console.WriteLine($"{item} removed from inventory.");
            return true;
        }
        else
        {
            Console.WriteLine($"{item} not found in inventory.");
            return false;
        }
    }

    // Method to check if an item in the inventory
    public bool HasItem(string item)
    {
        return Items.Contains(item);
    }

    // Method to display inventory details
    public void DisplayInventory()
    {
        Console.WriteLine("Inventory:");
        foreach (var item in Items)
        {
            Console.WriteLine($"- {item}");
        }
    }
}
//---------------------------------------------------------------------
// Question 6: Spell Class
// Design a class called "Spell" to represent magical abilities or spells in a fantasy game.
// Include properties for the spell's name, damage, mana cost, and description.
// Implement methods to cast the spell, consume mana, and display spell details.
// Hint: Define a class with attributes for name, damage, mana cost, and description. Implement methods to cast and describe the spell.
/* Consider the mechanics of spellcasting in fantasy games. Spells often have different effects, costs, and descriptions. */
public class Spell
{
    public string Name { get;  set; }
    public int Damage { get;  set; }
    public int ManaCost { get;  set; }
    public string Description { get;  set; }

    public Spell(string name, int damage, int manaCost, string description)
    {
        Name = name;
        Damage = damage;
        ManaCost = manaCost;
        Description = description;
    }

    // Method to cast the spell
    public void Cast()
    {
        Console.WriteLine($"{Name} cast! It deals {Damage} damage and costs {ManaCost} mana.");
    }

    // Method to cast the spell on an enemy target
    public void CastOn(Enemy target)
    {
        target.TakeDamage(Damage);
        Console.WriteLine($"{Name} cast on {target.Name}! {target.Name} takes {Damage} damage and now has {target.HP} HP.");
    }

    // Method to display spell details
    public void DisplayDetails()
    {
        Console.WriteLine($"Spell: {Name}\nDamage: {Damage}\nMana Cost: {ManaCost}\nDescription: {Description}");
    }
}
//---------------------------------------------------------------------
// Main Entry Point
//---------------------------------------------------------------------
class Program
{
    static void Main()
    {

        
        // Create a player object and set the name to Hero.
        Player player = new Player("Hero");
        Console.WriteLine($"Created player: {player.Name}, Level {player.Level}, HP {player.HP}/{player.MaxHP}, XP {player.XP}/{player.MaxXP}");

        // Heal the player by 10 points. The Heal method also prints the new HP.
        player.Heal(10);

        // Give the player 50 experience points first.
        player.GainXP(50);

        // Give the player another 60 experience points, enough to level up.
        player.GainXP(500);

        // Create a health potion with healing power and quantity.
        Potion potion = new Potion("Health Potion", 25, 2);
        Console.WriteLine($"Created potion: {potion.Name}, Healing {potion.HealingPower}, Quantity {potion.Quantity}");

        // Apply the potion to the player twice and then try once more when there is none left.
        potion.Apply(player);
        potion.Apply(player);
        potion.Apply(player);

        // Create an inventory that can hold 3 items.
        Inventory inventory = new Inventory(3);
        Console.WriteLine($"Created inventory with capacity {inventory.Capacity}");

        // Add items to the inventory and show messages for each action.
        inventory.AddItem("Sword");
        inventory.AddItem("Shield");
        inventory.AddItem("Health Potion");
        inventory.AddItem("Bow"); //  inventory is full.

        // Display all items currently in inventory.
        inventory.DisplayInventory();

        // Remove an item and then show inventory again.
        inventory.RemoveItem("Shield");
        inventory.DisplayInventory();

        // Check if a specific item exists in the inventory.
        Console.WriteLine($"Inventory has Sword? {inventory.HasItem("Sword")} ");

        // Create a quest and then start and complete it.
        Quest quest = new Quest("Find the Lost Key", "Search the forest for the lost key.", 120);
        quest.Start();
        quest.Complete();

        // Create an enemy and calculate how much damage it would do to a target with 8 defense.
        Enemy goblin = new Enemy("Goblin", 30, 15, 5);
        Console.WriteLine($"Created enemy: {goblin.Name}, HP {goblin.HP}, Attack {goblin.AttackPower}, Defense {goblin.Defense}");
        int damage = goblin.CalculateDamage(8);
        Console.WriteLine($"Enemy would deal {damage} damage to a target with 8 defense.");

        // Create a spell and cast it on the goblin enemy.
        Spell fireball = new Spell("Fireball", 35, 20, "A blazing ball of fire that burns a single enemy.");
        fireball.DisplayDetails();
        fireball.CastOn(goblin);

        Console.WriteLine($"After spell, {goblin.Name} HP is {goblin.HP}.");

        // Show the player's final stats at the end of the program.
        Console.WriteLine($"Final player stats: Level {player.Level}, HP {player.HP}/{player.MaxHP}, XP {player.XP}/{player.MaxXP}");

        // Keep the console open until the user presses Enter.
        Console.WriteLine("Press Enter to exit...");
        Console.ReadLine();
    }
}