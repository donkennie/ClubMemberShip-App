
using ClubMemberShip_App;
using ClubMemberShip_App.Views;

public class Sender
{
    public static void Main(string[] arg)
    {
        IView mainview = Factory.GetMainViewObject();
        mainview.RunView();

        Console.ReadKey();
    }

}