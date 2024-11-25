class Police : Person
{
    private string _weapons;

                                                                            //base class is Person class
    public Police(string firstName, string lastName, int age, string weapons) :base(firstName, lastName, age)
    {
        _weapons = weapons;
    }
    public string GetPoliceInformation()
    {
                                    //this is inherited from the person class
        return $"Weapons: {_weapons}, {GetPersonInfo()}";
    }
}