using Decorator;

Client client = new Client();

var sample = new Gigantosaurus();

Console.WriteLine("Client: I've got a sample component:");
client.ClientCode(sample);
Console.WriteLine();

LoudGigantosarusDecorator decorator1 = new LoudGigantosarusDecorator(sample);
ExtraLoudGigantosaurusDecorator decorator2 = new ExtraLoudGigantosaurusDecorator(decorator1);
Console.WriteLine("Client: Now I've got a decorated component:");
client.ClientCode(decorator2);

Console.ReadLine();