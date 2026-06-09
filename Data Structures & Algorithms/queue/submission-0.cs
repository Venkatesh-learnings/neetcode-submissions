public class Node{
    public int val;
    public Node next=null;
    public Node prev=null;
    public Node(int val){
        this.val=val;
        
    }
}

class Deque {
    public Node dummyHead;
    private Node dummyTail;
    public Deque() {
        dummyHead=new Node(0);
        dummyTail=new Node(0);
        dummyHead.next=dummyTail;
        dummyTail.prev=dummyHead;
    }

    public bool isEmpty() {
     return (dummyHead.next==dummyTail);
    }

    public void append(int value) {
        var node =new Node(value);
        node.prev=dummyTail.prev;
        node.next=dummyTail;
        dummyTail.prev.next=node;
        dummyTail.prev=node;
    }

    public void appendleft(int value) {
        var node=new Node(value);
        node.prev=dummyHead;
        node.next=dummyHead.next;
        
        dummyHead.next.prev=node;
        dummyHead.next=node;
    }

    public int pop() {
        if (isEmpty()) {
            return -1;
        }
        Node targetNode = this.dummyTail.prev;
        Node prevNode = targetNode.prev;
        int value = targetNode.val;

        this.dummyTail.prev = prevNode;
        prevNode.next = this.dummyTail;

        return value;
    }

    public int popleft() {
        if (isEmpty()) {
            return -1;
        }
        Node targetNode = this.dummyHead.next;
        Node nextNode = targetNode.next;
        int value = targetNode.val;

        this.dummyHead.next = nextNode;
        nextNode.prev = this.dummyHead;

        return value;
    }
}
