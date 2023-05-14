﻿namespace LinkedList{
    class Program{
        public static void Main(){
            LinkList list=new LinkList(),root=null;
            root=list.AddNode(56,root);
            list.AddNode(70,root);

            list.Insert(root,56,70,30);

            list.Insert(root,30,70,40);

            //root=list.Pop(root);

            //list.PopLast(root);



            //list.DisplayList(root);
            //list.Remove(root,40);

            list.DisplayList(root);

            list.Sort(root);

            Console.WriteLine("\nSorted List: ");
            list.DisplayList(root);
            Console.WriteLine("Size is: "+list.Size(root));

            // int outcome=list.Search(root,30);
            // if(outcome!=-1)
            //     Console.WriteLine("Node present at position: "+outcome);
            // else
            //     Console.WriteLine("Node not found....");

            
        }
    }
}