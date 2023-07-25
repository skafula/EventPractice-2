using DelegatePractice;

internal class Program
{
    public static void Main()
    {
        User.UserAddedEvent += CheckIfAdult;
        User.UserAddedEvent += user => Console.WriteLine(user.Gender == Genders.Male ? " and male" : " and female"); 

        User male = new(1, "John", 21, Genders.Male);
        User female = new(2, "Victoria", 17, Genders.Female);
    }
    static void CheckIfAdult(User user)
    {
        if (user != null)
            Console.Write(user.Age >= 18 ? $"{user.Name} is adult" : $"{user.Name} is child");
    }
}