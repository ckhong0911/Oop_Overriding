namespace Oop_Overriding
{
  /// <summary>
  /// This class only defind name.
  /// </summary>
  class Pokemon
  {
    // attribute
    string name;

    // constructor
    public Pokemon(string name)
    {
      this.name = name;
    }

    // method
    // return external input.
    public virtual string getName()
    {
      return name;
    }
  }
}
