using System;

class FriendNode
{
    public int FriendId;
    public FriendNode Next;

    public FriendNode(int id)
    {
        FriendId = id;
        Next = null;
    }
}

class UserNode
{
    public int UserId;
    public string Name;
    public int Age;

    public FriendNode Friends;
    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Friends = null;
        Next = null;
    }
}

class SocialMedia
{
    private UserNode head;

    public SocialMedia()
    {
        head = null;
    }

    public void AddUser(int id, string name, int age)
    {
        UserNode newUser = new UserNode(id, name, age);

        if (head == null)
        {
            head = newUser;
            return;
        }

        UserNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newUser;
    }

    private UserNode FindUser(int userId)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == userId)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    public void AddFriendConnection(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
            return;

        AddFriend(user1, userId2);
        AddFriend(user2, userId1);
    }

    private void AddFriend(UserNode user, int friendId)
    {
        FriendNode newFriend = new FriendNode(friendId);

        if (user.Friends == null)
        {
            user.Friends = newFriend;
            return;
        }

        FriendNode temp = user.Friends;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newFriend;
    }

    public void RemoveFriendConnection(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
            return;

        RemoveFriend(user1, userId2);
        RemoveFriend(user2, userId1);
    }

    private void RemoveFriend(UserNode user, int friendId)
    {
        FriendNode curr = user.Friends;
        FriendNode prev = null;

        while (curr != null)
        {
            if (curr.FriendId == friendId)
            {
                if (prev == null)
                    user.Friends = curr.Next;
                else
                    prev.Next = curr.Next;
                return;
            }
            prev = curr;
            curr = curr.Next;
        }
    }

    public void DisplayFriends(int userId)
    {
        UserNode user = FindUser(userId);
        if (user == null)
            return;

        Console.WriteLine("Friends of " + user.Name + ":");

        FriendNode temp = user.Friends;
        while (temp != null)
        {
            Console.WriteLine("Friend ID: " + temp.FriendId);
            temp = temp.Next;
        }
    }

    public void FindMutualFriends(int userId1, int userId2)
    {
        UserNode user1 = FindUser(userId1);
        UserNode user2 = FindUser(userId2);

        if (user1 == null || user2 == null)
            return;

        Console.WriteLine("Mutual Friends:");

        FriendNode f1 = user1.Friends;
        while (f1 != null)
        {
            FriendNode f2 = user2.Friends;
            while (f2 != null)
            {
                if (f1.FriendId == f2.FriendId)
                    Console.WriteLine("Friend ID: " + f1.FriendId);
                f2 = f2.Next;
            }
            f1 = f1.Next;
        }
    }

    public void SearchUser(string name)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                DisplayUser(temp);
                return;
            }
            temp = temp.Next;
        }
    }

    public void SearchUser(int userId)
    {
        UserNode user = FindUser(userId);
        if (user != null)
            DisplayUser(user);
    }

    private void DisplayUser(UserNode user)
    {
        Console.WriteLine("User ID: " + user.UserId);
        Console.WriteLine("Name: " + user.Name);
        Console.WriteLine("Age: " + user.Age);
    }

    public void CountFriends()
    {
        UserNode temp = head;
        while (temp != null)
        {
            int count = 0;
            FriendNode f = temp.Friends;
            while (f != null)
            {
                count++;
                f = f.Next;
            }
            Console.WriteLine("User " + temp.UserId + " has " + count + " friends");
            temp = temp.Next;
        }
    }
}

class SocialMediaConnection
{
    static void Main(string[] args)
    {
        SocialMedia sm = new SocialMedia();

        sm.AddUser(1, "Alice", 21);
        sm.AddUser(2, "Bob", 22);
        sm.AddUser(3, "Charlie", 23);
        sm.AddUser(4, "David", 24);

        sm.AddFriendConnection(1, 2);
        sm.AddFriendConnection(1, 3);
        sm.AddFriendConnection(2, 3);
        sm.AddFriendConnection(2, 4);

        sm.DisplayFriends(1);
        sm.FindMutualFriends(1, 2);

        sm.RemoveFriendConnection(1, 3);

        sm.SearchUser("Bob");
        sm.SearchUser(4);

        sm.CountFriends();
    }
}

