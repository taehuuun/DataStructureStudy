using SinglyLinkedList;

SinglyLinkedList<int> list = new SinglyLinkedList<int>();

// 맨 처음 비어있는 리스트를 출력
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 비어있는 리스트에 1, 2를 AddLast하여 추가
// List : 1, 2
list.AddLast(1);
list.AddLast(2);
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트에 3, 4를 AddLast하여 추가
// List : 1, 2, 3, 4
list.AddLast(3);
list.AddLast(4);
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트에 0를 AddFirst하여 추가
// List : 0, 1, 2, 3, 4
list.AddFirst(0);
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트에 -1를 Add first하여 추가
// List : -1, 0, 1, 2, 3, 4
list.AddFirst(-1);
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트 에서 3에 해당하는 노드 뒤에 5를 추가
// List: -1, 0, 1, 2, 3, 5, 4
list.AddAfter(list.Find(3),5);
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트 에서 0에 해당하는 노드 뒤에 6을 추가
// List : -1, 0, 6, 1, 2, 3, 5, 4
list.AddAfter(list.Find(0),6);
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트에서 6을 찾아서 제거
// List : -1, 0, 1, 2, 3, 5, 4
list.Remove(list.Find(6));
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");

// 리스트에서 5을 찾아서 제거
// List : -1, 0, 1, 2, 3, 4
list.Remove(list.Find(5));
Console.WriteLine(list.ToString());
Console.WriteLine($"리스트 크기 : {list.Count}");