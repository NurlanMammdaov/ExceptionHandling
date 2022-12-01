using ExpEx;

Person person = new Person();
try
{
    person.Age = 1;
}
catch (InvailedAgeException ex)
{
   Console.WriteLine(ex.Message);
}