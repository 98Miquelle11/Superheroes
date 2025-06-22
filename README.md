# Hero duel game "Superheroes"

# Console App
A simple command-line application based two-player game, where each player selects a hero and engages in a turn-based duel. The game includes attack, heal and special abilities based on hero class.

# Classes

## Hero
#### General description:
Abstract, base class, whose parameters are implemented by individual hero classes.
#### Numeric types:
* private (enum) Colors.
#### Fields:
* private int actualHP.
#### Properties:
* public string Name,
* public int FullHP,
* public int ActualHP,
* public (enum) Colors Color,
* public bool UsedSpecialAttack.
#### Methods:
* constructor taking into account fields and properties and setting the variable actualHP to FullHP,
* public abstract void DefaultAttack,
* public abstract void Heal,
* public override string ToString.

## Knight
#### General description:
Derived class of the Hero class.
#### Methods:
* constructor taking into account fields and properties.
* public override void DefaultAttack,
* public override void Heal.

## Wizard
#### General description:
Derived class of the Hero class.
#### Methods:
* constructor taking into account fields and properties.
* public override void DefaultAttack,
* public override void Heal,
* public void SpecialAttack.
