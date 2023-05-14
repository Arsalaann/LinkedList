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
            if(root==null){
                Console.WriteLine("No Nodes to delete");
                return null;
            }
            return root.next;
        }

        public int Search(LinkList root,int data){
            if(root==null)
                return -1;
            int ind=1;
            while(root!=null && root.data!=data){
                root=root.next;
                ind++;
            }
            if(root==null)
                return -1;
            return ind;
        }

        public void PopLast(LinkList root){
            if(root==null)
                Console.WriteLine("No Nodes to delete");
            else if(root.next==null)
                root=null;
            else{
                LinkList prev=root;
                while(root.next != null){
                    prev=root;
                    root=root.next;
                }
                prev.next=null;
            }
            
        }

        public int Size(LinkList root){
            int n=0;
            if(root==null)
                return n;
            while(root!=null){
                root=root.next;
                n++;
            }
            return n;
        }

        public void Sort(LinkList root){
            if(root==null)  return;
            LinkList st=root;
            while(st!=null){
                LinkList itr=st,sm=st;
                while(itr!=null){
                    if(itr.data<sm.data)
                        sm=itr;
                    itr=itr.next;
                }
                int tmp=st.data;
                st.data=sm.data;
                sm.data=tmp;
                st=st.next;
            }
        }

        public void Remove(LinkList root,int data){
            if(root==null){
                Console.WriteLine("No Node to remove....");
                return;
            }
            if(root.data==data){
                this.Pop(root);
                return;
            }
            LinkList prev=root;
            while(root!=null && root.data!=data){
                prev=root;
                root=root.next;
            }
            if(root==null){
                Console.WriteLine("Node not found....");
                return;
            }
            prev.next=root.next;
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