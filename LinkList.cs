namespace LinkedList{
    public class LinkList{
        int data;
        LinkList next=null;

        public LinkList(){}

        public LinkList(int data){
            this.data=data;
        }
        public LinkList AddNode(int data,LinkList root){
            if(root==null)
                return new LinkList(data);
            if(root.next!=null)
                root=root.next;
            root.next=new LinkList(data);
            return root;
        }

        public void DisplayList(LinkList root){
            if(root==null) return;
            while(root!=null){
                Console.Write(root.data+"-->");
                root=root.next;
            }
            Console.WriteLine();
        }
    }
}