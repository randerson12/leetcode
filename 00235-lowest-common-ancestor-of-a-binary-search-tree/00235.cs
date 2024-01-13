/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        // If the root node is null, return null.
        if (root == null)
        {
            return null;
        }

        // If the root node is less than both p and q nodes, then get the LCA of the right subtree.
        if (root.val < p.val && root.val < q.val)
        {
            return LowestCommonAncestor(root.right, p, q);
        }
        // If the root node is greater than both p and q nodes, then get the LCA of the left subtree.
        else if (root.val > p.val && root.val > q.val)
        {
            return LowestCommonAncestor(root.left, p, q);
        }

        // If neither of the above criteria are met, return the root value.
        return root;
    }
}
