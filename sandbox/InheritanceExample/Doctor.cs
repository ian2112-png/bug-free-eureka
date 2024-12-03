class Doctor : Person
{
    private string _tools;

                                                                            //base class is Person class
    public Doctor(string firstName, string lastName, int age, string tools) :base(firstName, lastName, age)
    {
        _tools = tools;
    }
    public string GetDoctorInformation()
    {
                                    //this is inherited from the person class
        return $"Tools: {_tools}, {GetPersonInfo()}";
    }
     public override string GetPersonInfo()
    {
        return $"Doctor Doctor. My favorite tool is {_tools}. My info is : {base.GetPersonsStats()}";
    }
}