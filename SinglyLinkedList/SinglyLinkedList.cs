namespace SinglyLinkedList;

public class SinglyLinkedList<T>
{
    private Node<T>? _head;
    public int Count;

    public SinglyLinkedList()
    {
        _head = null;
        Count = 0;
    }
    
    /// <summary>
    /// 리스트의 마지막에 데이터 노드를 추가 합니다
    /// </summary>
    /// <param name="data">추가할 데이터</param>
    public void AddLast(T data)
    {
        // 데이터를 추가 하기 위한 노드 생성
        Node<T> newNode = new Node<T>(data);
        
        // 리스트에 추가된 데이터가 없을 경우
        if (Count == 0)
        {
            // 현재 헤드에 newNode를 대입
            _head = newNode;
        }
        else
        {
            // currentNode는 헤드 노드로 설정
            Node<T>? currentNode = _head;
            
            // currentNode의 다음 노드가 null이 아닐 경우 반복
            while (currentNode.Next != null)
            {
                // currentNode에 다음 노드를 설정
                currentNode = currentNode.Next;
            }
            
            // 리스트의 마지막 노드가 됨
            // 마지막 노드의 다음 노드로 newNode를 추가
            currentNode.Next = newNode;
        }
        
        // 리스트의 카운트를 증가
        Count++;
    }
    /// <summary>
    /// 리스트의 처음에 데이터 노드를 추가 합니다
    /// </summary>
    /// <param name="data">추가할 데이터</param>
    public void AddFirst(T data)
    {
        // 데이터를 추가 하기 위한 새로운 노드를 생성
        Node<T> newNode = new Node<T>(data);
        
        // 리스트가 비어있다면 
        if (Count == 0)
        {
            // 새로 추가하는 노드를 헤드 변경
            _head = newNode;
        }
        else
        {
            // 기존 헤드 노드를 임시 저장
            Node<T> headOrigin = _head;
            
            //새로 추가되는 노드의 다음 노드를 기존 헤드로 변경
            newNode.Next = headOrigin;

            // 새로 추가하는 노드를 헤드로 변경
            _head = newNode;
        }
        
        // 카운트 증가
        Count++;
    }
    public override string ToString()
    {
        // 헤드 노드를 임시 변수에 저장
        var tmp = _head;
        
        // 데이터를 저장할 문자열 변수를 초기화
        string data = "";
        
        // tmp가 null이 아닐 때까지 반복
        while (tmp != null)
        {
            // data가 비어있지 않으면 쉼표를 추가
            if (!string.IsNullOrEmpty(data))
            {
                data += ",";
            }
            
            // tmp노드의 Data 값을 문자열로 변환, data에 추가
            data += tmp.Data?.ToString();
            
            // 다음 노드로 아동
            tmp = tmp.Next;
        }
        
        // 최종적으로 생성된 문자열 데이터를 반환
        return data;
    }
}