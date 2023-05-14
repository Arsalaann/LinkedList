namespace LinkedList{
    class Program{
        public static void Main(){
            LinkList list=new LinkList(),root=null;
            root=list.AddNode(56,root);
            list.AddNode(70,root);

            list.Insert(root,56,70,30);

            //root=list.Pop(root);

            list.PopLast(root);

            list.DisplayList(root);
        }
    }
}