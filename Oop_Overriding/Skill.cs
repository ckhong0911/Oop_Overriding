namespace Oop_Overriding
{
  /// <summary>
  /// This class extends Pokemon class.
  /// This class defind ability.
  /// </summary>
  class Skill : Pokemon
  {
    // attribute
    string ability;

    // constructor
    public Skill(string name, string ability) : base(name)
    {
      this.ability = ability;
    }

    // method
    // return ability.
    public string getAbility()
    {
      return ability;
    }

    // overriding
    public override string getName()
    {
      return "Raichu";
    }
  }
}
