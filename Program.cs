namespace LinkedList{
    class Program{
        public static void Main(){
            LinkList list=new LinkList(),root=null;
            root=list.AddNode(56,root);
            list.AddNode(70,root);

            list.Insert(root,56,70,30);

            list.DisplayList(root);
        }
    }
}