using TreeandGraph;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Trees And Graphs");
CreateTree tree = new CreateTree();
int[] nums = {1,2,3,4,5,6,7};
CreateTree.Node root = tree.usingQueue(nums);
tree.preorderTraversal(root);


