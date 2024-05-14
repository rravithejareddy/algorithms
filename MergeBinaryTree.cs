// C# program to Merge Two Binary Trees
using System;

/* A binary tree node has data, pointer
to left child and a pointer to right child */
public class Node
{
public int data;
public Node left, right;

public Node(int data, Node left,
					Node right)
{
	this.data = data;
	this.left = left;
	this.right = right;
}

/* Helper method that allocates a new
node with the given data and NULL left
and right pointers. */
public static Node newNode(int data)
{
	return new Node(data, null, null);
}

/* Given a binary tree, print its
nodes in inorder*/
public static void inorder(Node node)
{
	if (node == null)
	{
		return;
	}

	/* first recur on left child */
	inorder(node.left);

	/* then print the data of node */
	
    Console.Write("{0:D} ", node.data);
	/* now recur on right child */
	inorder(node.right);

}

/* Method to merge given two binary trees*/
public static Node MergeTrees(Node t1, Node t2)
{
	if (t1 == null)
	{
		return t2;
	}
	if (t2 == null)
	{
		return t1;
	}
    	t1.data += t2.data;
	t1.left = MergeTrees(t1.left, t2.left);

	t1.right = MergeTrees(t1.right, t2.right);

	return t1;
}

public static bool hasPathSum(Node root, int S){
    if (root == null) return false;
        if (root.data > S) return false;
        if (root.left == null && root.right == null) return (S==root.data);

    return hasPathSum(root.left, S-root.data)||hasPathSum(root.right, S-root.data);
}

// Driver Code
public static void Main(string[] args)
{
	/* Let us construct the first Binary Tree
			1
		/ \
		2	 3
		/ \	 \
		4 5	 6
	*/

	Node root1 = newNode(1);
	root1.left = newNode(3);
	root1.right = newNode(2);
	root1.left.left = newNode(5);


	/* Let us construct the second Binary Tree
			4
		/ \
		1	 7
		/	 / \
	3	 2 6 */
	Node root2 = newNode(2);
	root2.left = newNode(1);
	root2.right = newNode(3);
	root2.left.right = newNode(4);
	root2.right.right = newNode(7);

	//Node root3 = MergeTrees(root1, root2);
    bool sum = hasPathSum(root1, 9);

	Console.Write("The Merged Binary Tree is:\n"+ sum);
	//inorder(root3);
}
}

// This code is contributed by Shrikant13
