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

        public void Insert(LinkList root,int beforeNode,int afterNode,int data){
            if(root==null){
                Console.WriteLine("List is Empty...");
                return;
            }
            while(root!=null && root.next!=null && (root.data!=beforeNode && root.next.data!=afterNode))
                root=root.next;
            if(root==null)
                Console.WriteLine("Nodes not fount...");
            else{
                LinkList inMiddle=new LinkList(data);
                inMiddle.next=root.next;
                root.next=inMiddle;
            }
            
        }

        public LinkList Pop(LinkList root){
            return root.next;
        }

        public void DisplayList(LinkList root){
            if(root==null) return;
            while(root!=null){
                Console.Write(root.data+"-->");
                root=root.next;
            }
            Console.WriteLine("END");
        }
    }
}