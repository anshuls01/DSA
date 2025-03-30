using System;

namespace TreeandGraph;

public class CreateTree
{
    public class Node
    {
        public int data;
        public Node left;
        public Node right;

        public Node(int value)
        {
            data = value;
            left = null;
            right = null;
        }
    }

    public Node usingQueue(int[] nums)
    {
        if(nums==null || nums.Length==0)
        {
            return null;
        }
        Node root = new Node(nums[0]);
        int i = 1;
        while(i<nums.Length)
        {
            Node current = root;
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(current);
            while(queue.Count>0 && i<nums.Length)
            {
                current = queue.Dequeue();
                if(i<nums.Length)
                {
                    if(nums[i]==null)
                    {
                        current.left = null;
                    }
                    else
                    {
                        current.left = new Node(nums[i]);
                        queue.Enqueue(current.left);
                    }
                    i++;
                }

                if(i<nums.Length)
                {
                    if(nums[i]==null)
                    {
                        current.right = null;
                    }
                    else
                    {
                        current.right = new Node(nums[i]);
                        queue.Enqueue(current.right);
                    }
                    i++;
                }
            }
        }
        return root;
    }

    public void preorderTraversal(Node root)
    {
        if(root==null)
        {
            return;
        }
        Console.WriteLine(root.data);
        preorderTraversal(root.left);
        preorderTraversal(root.right);
    }
}
