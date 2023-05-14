namespace LinkedList{
    class Program{
        public static void Main(){
            LinkList list=new LinkList(),root=null;
            root=list.AddNode(56,root);
            list.AddNode(30,root);
            list.AddNode(70,root);
            list.DisplayList(root);
        }
    }
}