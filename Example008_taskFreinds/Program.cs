int count = 0;
int distance =10000;
int firstFriendSpeed = 1;
int secondFriendSpeed = 2;
int dogSpeed = 5;
int Friend = 0;
int Time = 0;

while ( distance > 10 );

    while (Friend == 1);
    {
        Time = distance / ( firstFriendSpeed + dogSpeed );
        Friend = 2;
        distance = distance - ( firstFriendSpeed + secondFriendSpeed ) * Time;
        count++;
    }
     while (Friend == 2);
    {
        Time = distance /( secondFriendSpeed + dogSpeed );
        Friend = 1;
        distance = distance - ( firstFriendSpeed + secondFriendSpeed ) * Time;
        count++;
    }
    
Console.Write("Собака прошла ");
Console.Write(count);
Console.WriteLine(" раз");