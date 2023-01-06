public class Node {
    public Node? Next;
    public Node? Prev;
    public object? Data;
}

public class LinkedList {
    public Node? Head;
    public Node? Tail;

    public int Measure() {
        Node? Current = new Node();
        Current = Head;
        int length = 0;
        while (true) {
            if (Current != Tail) {
                Current = Current!.Next;
                length += 1;
            }
            else {
                return length + 1;
            }
        } 
    }

    public void Add(object data) {
        if (Head is null) {
            Node newNode = new Node();
            newNode.Data = data;
            Head = newNode;
            Tail = Head;
        }
        else {
            Node newNode = new Node();
            newNode.Data = data;
            Tail!.Next = newNode;
            newNode.Prev = Tail;
            Tail = newNode;
        }
    }

    public void PrintAll() {
        Node? Current = new Node();
        Current = Head;
        while (true) {
            Console.WriteLine(Current!.Data);
            if (Current != Tail) {
                Current = Current.Next;
            }
            else {
                break;
            }
        } 
    }

    public object? Search(int index) {
        Node? Current = new Node();
        Current = Head;
        for (int i = 0; i < index; i++) {
            Current = Current!.Next;
        }
        return Current!.Data;
    }

    public void Delete(int index) {
        Node? Current = new Node();
        Current = Head;
        for (int i = 0; i < index; i++) {
            Current = Current!.Next;
        }
        if (Current!.Prev is null) {
            Head = Current.Next;
            Current = null;
        }
        else if (Current!.Next is null) {
            Tail = Current.Prev;
            Current = null;
        }
        else {
            Current!.Prev!.Next = Current.Next;
            Current!.Next!.Prev = Current.Prev;
            Current = null;
        }
    }
}

class Program2
{
    public static void Main (string[] args) 
    {

        LinkedList employeee1 = new LinkedList();
        employeee1.Add("Emanual Garcia");
        employeee1.Add(30.00f);
        employeee1.Add(38);

        //  SOLUTION TO EXAMPLE QUIZ

        // LinkedList employeee2 = new LinkedList();
        // employeee2.Add("Tom Jacobs");
        // employeee2.Add(27.50f);
        // employeee2.Add(40);

        // LinkedList employeee3 = new LinkedList();
        // employeee3.Add("Susanne Rachels");
        // employeee3.Add(34.70f);
        // employeee3.Add(32);

        // Console.WriteLine(employeee1.Search(0));
        // int hoursworked = (int) employeee1.Search(2);
        // float? hourlywage = (float) employeee1.Search(1);
        // float? paycheck = hourlywage * hoursworked;
        // Console.WriteLine(paycheck);

        // Console.WriteLine(employeee2.Search(0));
        // hoursworked = (int) employeee2.Search(2);
        // hourlywage = (float) employeee2.Search(1);
        // paycheck = hourlywage * hoursworked;
        // Console.WriteLine(paycheck);

        // Console.WriteLine(employeee3.Search(0));
        // hoursworked = (int) employeee3.Search(2);
        // hourlywage = (float) employeee3.Search(1);
        // paycheck = hourlywage * hoursworked;
        // Console.WriteLine(paycheck);
        
        Console.WriteLine("--------------------------------------");
        employeee1.PrintAll();
        employeee1.Delete(0);
        Console.WriteLine("--------------------------------------");
        employeee1.PrintAll();

    }
}
