using WinSCP;

Console.WriteLine("Enter FTP Host");
var ftpHost = Console.ReadLine();
Console.WriteLine("Enter Port");
int ftpPort;
while (!int.TryParse(Console.ReadLine(), out ftpPort))
{
    Console.Write("Invalid port. Please enter a valid integer for the port number: ");
}
Console.WriteLine("Enter FTP Username");
var ftpUser = Console.ReadLine();
Console.WriteLine("Enter FTP Password");
var ftpPassword = ReadPassword();
Console.WriteLine("Enter Local Directory Path");
var localDirectory = Console.ReadLine();
Console.WriteLine("Enter Remote Directory Path");
var remoteDirectory = Console.ReadLine();

SessionOptions sessionOptions = new SessionOptions
{
    Protocol = Protocol.Ftp,
    HostName = ftpHost,
    PortNumber = ftpPort,
    UserName = ftpUser,
    Password = ftpPassword
};

bool connected = false;
while (!connected)
{
    using (Session session = new Session())
    {
        try
        {
            session.Open(sessionOptions);
            Console.WriteLine("Connection successful!");
            connected = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Connection failed: " + ex.Message);
            Console.WriteLine("Choose an option to update:");
            Console.WriteLine("1 - Change Host");
            Console.WriteLine("2 - Change Port");
            Console.WriteLine("3 - Change Username");
            Console.WriteLine("4 - Change Password");
            Console.WriteLine("5 - Retry Connection");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter FTP Host: ");
                    ftpHost = Console.ReadLine();
                    sessionOptions.HostName = ftpHost;
                    break;
                case "2":
                    Console.Write("Enter Port: ");
                    while (!int.TryParse(Console.ReadLine(), out ftpPort))
                    {
                        Console.Write("Invalid port. Please enter a valid integer for the port number: ");
                    }
                    sessionOptions.PortNumber = ftpPort;
                    break;
                case "3":
                    Console.Write("Enter FTP Username: ");
                    ftpUser = Console.ReadLine();
                    sessionOptions.UserName = ftpUser;
                    break;
                case "4":
                    Console.Write("Enter FTP Password: ");
                    ftpPassword = Console.ReadLine();
                    sessionOptions.Password = ftpPassword;
                    break;
                case "5":
                    Console.WriteLine("Retrying connection...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Retrying connection...");
                    break;
            }
        }
    }
}

using (Session session = new Session())
{
    session.Open(sessionOptions);
    TransferOptions transferOptions = new TransferOptions { TransferMode = TransferMode.Binary };
    TransferOperationResult transferResult = session.PutFiles(localDirectory + @"\*", remoteDirectory, false, transferOptions);
    transferResult.Check();

    Console.WriteLine("Bulk upload completed.");
    foreach (TransferEventArgs transfer in transferResult.Transfers)
    {
        Console.WriteLine("Uploaded: " + transfer.FileName);
    }
}


static string ReadPassword()
{
    var password = new System.Text.StringBuilder();
    ConsoleKeyInfo key;

    do
    {
        key = Console.ReadKey(intercept: true);
        
        if (key.Key == ConsoleKey.Backspace && password.Length > 0)
        {
            password.Length--;
            Console.Write("\b \b");
        }
        else if (!char.IsControl(key.KeyChar))
        {
            password.Append(key.KeyChar);
            Console.Write("*");
        }
    } while (key.Key != ConsoleKey.Enter);

    Console.WriteLine();
    return password.ToString();
}