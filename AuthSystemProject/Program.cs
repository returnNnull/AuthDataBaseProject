// See https://aka.ms/new-console-template for more information

using AuthSystemProject;

UsersDataBaseMock db = new(100);
Authorization authorization = new(db);

string login = Console.ReadLine();
string pass = Console.ReadLine();

authorization.Login(login.Trim(), pass.Trim());

if (authorization.IsAuth())
{

    Console.WriteLine("Success");
}
else {

    Console.WriteLine("Not found...");
}

Console.ReadKey();

