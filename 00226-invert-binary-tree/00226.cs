/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InvertTree(TreeNode root)
    {
        // Recursively traverse the tree and invert it.
        Traverse(root);

        // Return the inverted tree.
        return root;
    }

    private void Traverse(TreeNode node)
    {
        // Exit if the node is at the end of the tree.
        if (node == null)
        {
            return;
        }

        // Keep traversing left and right nodes.
        Traverse(node.left);
        Traverse(node.right);

        // At this point the root node has been visited. Swap the left and right child nodes.
        TreeNode temp = node.left;
        node.left = node.right;
        node.right = temp;
    }
}
